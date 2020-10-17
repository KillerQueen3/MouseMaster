using MouseM_ster.Tool;
using System.Text.RegularExpressions;

namespace MouseM_ster.Controller
{
	class MainCon
	{
		STimer timer;
		MouseRun run;
		MainForm f;
		TimeUpdater tu;

		public int keyPause = 112; //F1

		public MainCon(MainForm form)
		{
			timer = new STimer();
			f = form;
			run = new MouseRun();
			tu = new TimeUpdater();
			timer.SetTask(task);
			run.Start();
			run.ChangePause();
		}

		public void task()
		{
			run.Resume();
			
			f.timerMsg();
		}

		public void StartClick()
		{
			run.Start();
		}

		public void setPauseKey(int k)
		{
			keyPause = k;
		}

		public bool IsTimerRunning()
		{
			return timer.IsRunning();
		}

		public bool StartTimer()
		{
			return timer.Start();
		}

		private string regax = "^[0-9]+$";

		public bool SetMouseInterval(string raw)
		{

			if (Regex.IsMatch(raw, regax))
			{
				int itv = int.Parse(raw);
				if (itv > 0)
				{
					run.SetInterval(itv);
					return true;
				}
			}
			return false;
		}

		public bool SetTimerTarget(string hh, string mm, string ss, string mms)
		{
			string[] vs = { hh, mm, ss, mms };
			int[] nums = new int[4];
			for (int i = 0; i < 4; i++)
			{
				if (!Regex.IsMatch(vs[i], regax))
				{
					return false;
				}
				else
				{
					int t = int.Parse(vs[i]);
					nums[i] = t;
				}
			}
			if (nums[0] < 24 && nums[1] < 60 && nums[2] < 60 && nums[3] < 1000)
			{
				timer.SetTarget(nums[0], nums[1], nums[2], nums[3]);
				return true;
			}
			return false;
		}

		public bool UpdateTime()
		{
			if (tu.getNetTime() && tu.SetLocalTime(200))
				return true;
			return false;
		}

		public void StopTimer()
		{
			timer.Stop();
		}

		public void PauseClick()
		{
			run.ChangePause();
		}

		public void StopAll()
		{
			run.Stop();
			timer.Stop();
		}
	}
}
