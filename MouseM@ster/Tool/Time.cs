using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MouseM_ster.Tool
{
	class STimer
	{
		DateTime target = new DateTime();
		uint targetTick;
		volatile bool running = false;

		volatile bool stop = false;

		Action task;

		[DllImport("winmm")]
		static extern uint timeGetTime();

		public STimer()
		{

		}

		public void PrintNow()
		{
			Console.WriteLine(timeGetTime());
		}

		public void SetTask(Action task)
		{
			this.task = task;
		}

		public void SetTarget(int h, int m, int s, int ms)
		{
			DateTime now = DateTime.Now;
			target = new DateTime(now.Year, now.Month, now.Day,
				h, m, s, ms);
			long now_target = ToUnixMillis(target) - ToUnixMillis(now);
			if (now_target > 0)
			{
				uint x = (uint)now_target;
				targetTick = x + timeGetTime();
			}
			else
			{
				targetTick = 0;
			}
		}

		private static long ToUnixMillis(DateTime date)
		{
			DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			TimeSpan diff = date.ToUniversalTime() - origin;
			return (long)diff.TotalMilliseconds;
		}

		public bool Start()
		{
			stop = false;
			if (!running)
			{
				running = true;
				ThreadStart threadStart = new ThreadStart(run);
				Thread thread = new Thread(threadStart);
				thread.Start();
				return true;
			} else
			{
				Console.WriteLine("already running!");
				return false;
			}			
		}

		public bool IsRunning()
		{
			return running;
		}

		public void Stop()
		{
			stop = true;
		}

		private void run()
		{
			Tool.MouseRun.timeBeginPeriod(1);
			do
			{
				Thread.Sleep(1);
			} while (timeGetTime() < targetTick && !stop);

			if (!stop)
			{
				Console.WriteLine("run task!");
				task();
			}
			running = false;
			Tool.MouseRun.timeEndPeriod(1);
		}
	}


	public class TimeUpdater
	{

		private const string url = "http://worldtimeapi.org/api/timezone/Asia/Shanghai";
		private DateTime netTime;
		private bool OK = false;

		public TimeUpdater()
		{

		}

		public bool getNetTime()
		{
			WebRequest wrt = null;
			WebResponse wrp = null;
			try
			{
				wrt = WebRequest.Create(url);
				wrp = wrt.GetResponse();

				string html = string.Empty;
				using (Stream stream = wrp.GetResponseStream())
				{
					using (StreamReader sr = new StreamReader(stream, Encoding.UTF8))
					{
						html = sr.ReadToEnd();
					}
				}
				JObject jObject = (JObject)JsonConvert.DeserializeObject(html, new JsonSerializerSettings()
				{
					DateParseHandling = Newtonsoft.Json.DateParseHandling.None
				});
				string time = jObject["utc_datetime"].ToString();
				netTime = DateTime.Parse(time).ToLocalTime();
				OK = true;
			}
			catch (WebException)
			{
				Console.WriteLine("error!");
				OK = false;
				return false;
			}
			catch (Exception)
			{
				Console.WriteLine("error!");
				OK = false;
				return false;
			}
			finally
			{
				if (wrp != null)
					wrp.Close();
				if (wrt != null)
					wrt.Abort();
			}
			
			return true;
		}

		//设置系统时间的API函数
		[DllImport("kernel32.dll")]
		private static extern bool SetLocalTime(ref SYSTEMTIME time);

		[StructLayout(LayoutKind.Sequential)]
		private struct SYSTEMTIME
		{
			public short year;
			public short month;
			public short dayOfWeek;
			public short day;
			public short hour;
			public short minute;
			public short second;
			public short milliseconds;
		}

		public bool SetLocalTime(short lag)
		{
			if (!OK)
			{
				return false;
			}

			SYSTEMTIME st;
			st.year = (short)netTime.Year;
			st.month = (short)netTime.Month;
			st.dayOfWeek = (short)netTime.DayOfWeek;
			st.day = (short)netTime.Day;
			st.hour = (short)netTime.Hour;
			st.minute = (short)netTime.Minute;
			st.second = (short)netTime.Second;
			st.milliseconds = (short)(netTime.Millisecond + lag);
			bool rt = SetLocalTime(ref st);
			return rt;
		}
	}
}

