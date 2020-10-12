using MouseM_ster.Controller;
using MouseM_ster.Tool;
using System;
using System.Windows.Forms;

namespace MouseM_ster
{
	public partial class MainForm : Form
	{
		private KeyEventHandler myKeyEventHandeler = null;//按键钩子
		private KeyboardHook k_hook = new KeyboardHook();

		MainCon con;

		private bool pauseFlag = true;

		private const int KEY_MOUSE_PAUSE = 112; //F1
	

		private void hook_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == KEY_MOUSE_PAUSE)
			{
				pauseFlag = !pauseFlag;
				con.PauseClick();
				if (pauseFlag)
				{
					showMsg("暂停");
					mouseLb.Text = "暂停";
				}
				else
				{
					showMsg("继续");
					mouseLb.Text = "运行中";
				}
			}
			Console.WriteLine("按下按键" + e.KeyValue);
		}

		public void startListen()
		{
			myKeyEventHandeler = new KeyEventHandler(hook_KeyDown);
			k_hook.KeyDownEvent += myKeyEventHandeler;//钩住键按下
			k_hook.Start();//安装键盘钩子
		}

		public void stopListen()
		{
			if (myKeyEventHandeler != null)
			{
				k_hook.KeyDownEvent -= myKeyEventHandeler;//取消按键事件
				myKeyEventHandeler = null;
				k_hook.Stop();//关闭键盘钩子
			}
		}

		public void timerMsg()
		{
			pauseFlag = false;
			mouseLb.Text = "定时开始";
			timerLb.Text = "启动！";
			showMsg("定时器触发！");
		}

		public MainForm()
		{
			InitializeComponent();
			System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
			con = new MainCon(this);
			startListen();
			con.SetMouseInterval(itvTB.Text);
			con.SetTimerTarget(hourTB.Text, minTB.Text, secTB.Text, msTB.Text);
		}


		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			con.StopAll();
			stopListen();
		}

		private void setItvBtn_Click(object sender, EventArgs e)
		{
			if (con.SetMouseInterval(itvTB.Text))
			{
				showMsg("间隔设定成功：" + itvTB.Text);
				itvLb.Text = itvTB.Text + "ms";
			}
			else
			{
				showMsg("间隔设定失败");
			}
		}

		private void showMsg(string msg)
		{
			msgLb.Text = msg;
		}

		private void setTimerBtn_Click(object sender, EventArgs e)
		{
			if (!con.IsTimerRunning())
			{
				if (con.SetTimerTarget(hourTB.Text, minTB.Text, secTB.Text, msTB.Text) && con.StartTimer())
				{
					showMsg("定时成功！");
					timerLb.Text = String.Format("已定时=>{0}:{1}:{2}+{3}", hourTB.Text, minTB.Text, secTB.Text, msTB.Text);
				}
				else
				{
					showMsg("定时失败！");
				}
			}
			else
			{
				showMsg("定时器已在运行！");
			}
		}

		private void timeStopBtn_Click(object sender, EventArgs e)
		{
			con.StopTimer();
			showMsg("取消定时");
			timerLb.Text = "定时取消";
		}

		private void testBtn_Click(object sender, EventArgs e)
		{
			con.UpdateTime();
		}

		private void timeUpdateBtn_Click(object sender, EventArgs e)
		{
			if (con.UpdateTime())
			{
				showMsg("时间校对成功！");
			}
			else
			{
				showMsg("时间校对失败！");
			}
		}

		private void 说明ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("用于定时开始进行鼠标左键连点，也可使用快捷键控制鼠标连点及暂停。\n" +
				"定时精度:~2ms。\n时间校对精度:根据网络状况而定(本程序设定200ms延迟修正值)。\n" +
				"时间校准api:http://worldtimeapi.org/api/timezone/Asia/Shanghai", "说明");
		}

		private void nowBtn_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			hourTB.Text = now.Hour.ToString();
			minTB.Text = now.Minute.ToString();
			secTB.Text = now.Second.ToString();
			msTB.Text = now.Millisecond.ToString();
		}
	}
}
