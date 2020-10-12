namespace MouseM_ster
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.setTimerBtn = new System.Windows.Forms.Button();
			this.hourTB = new System.Windows.Forms.TextBox();
			this.minTB = new System.Windows.Forms.TextBox();
			this.secTB = new System.Windows.Forms.TextBox();
			this.msTB = new System.Windows.Forms.TextBox();
			this.itvTB = new System.Windows.Forms.TextBox();
			this.setItvBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.timeStopBtn = new System.Windows.Forms.Button();
			this.stateLb = new System.Windows.Forms.Label();
			this.timerLb = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.mouseLb = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.itvLb = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.msgLb = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.testBtn = new System.Windows.Forms.Button();
			this.timeUpdateBtn1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nowBtn = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// setTimerBtn
			// 
			this.setTimerBtn.Location = new System.Drawing.Point(519, 48);
			this.setTimerBtn.Name = "setTimerBtn";
			this.setTimerBtn.Size = new System.Drawing.Size(94, 32);
			this.setTimerBtn.TabIndex = 0;
			this.setTimerBtn.Text = "定时开始";
			this.setTimerBtn.UseVisualStyleBackColor = true;
			this.setTimerBtn.Click += new System.EventHandler(this.setTimerBtn_Click);
			// 
			// hourTB
			// 
			this.hourTB.Location = new System.Drawing.Point(19, 51);
			this.hourTB.Name = "hourTB";
			this.hourTB.Size = new System.Drawing.Size(100, 25);
			this.hourTB.TabIndex = 2;
			this.hourTB.Text = "13";
			// 
			// minTB
			// 
			this.minTB.Location = new System.Drawing.Point(146, 51);
			this.minTB.Name = "minTB";
			this.minTB.Size = new System.Drawing.Size(100, 25);
			this.minTB.TabIndex = 3;
			this.minTB.Text = "59";
			// 
			// secTB
			// 
			this.secTB.Location = new System.Drawing.Point(273, 51);
			this.secTB.Name = "secTB";
			this.secTB.Size = new System.Drawing.Size(100, 25);
			this.secTB.TabIndex = 4;
			this.secTB.Text = "59";
			// 
			// msTB
			// 
			this.msTB.Location = new System.Drawing.Point(400, 51);
			this.msTB.Name = "msTB";
			this.msTB.Size = new System.Drawing.Size(100, 25);
			this.msTB.TabIndex = 5;
			this.msTB.Text = "700";
			// 
			// itvTB
			// 
			this.itvTB.Location = new System.Drawing.Point(146, 112);
			this.itvTB.Name = "itvTB";
			this.itvTB.Size = new System.Drawing.Size(100, 25);
			this.itvTB.TabIndex = 6;
			this.itvTB.Text = "100";
			// 
			// setItvBtn
			// 
			this.setItvBtn.Location = new System.Drawing.Point(273, 108);
			this.setItvBtn.Name = "setItvBtn";
			this.setItvBtn.Size = new System.Drawing.Size(100, 32);
			this.setItvBtn.TabIndex = 7;
			this.setItvBtn.Text = "设定间隔";
			this.setItvBtn.UseVisualStyleBackColor = true;
			this.setItvBtn.Click += new System.EventHandler(this.setItvBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(125, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = ":";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(252, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = ":";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(379, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(15, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "+";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 15);
			this.label4.TabIndex = 11;
			this.label4.Text = "点击间隔（ms）";
			// 
			// timeStopBtn
			// 
			this.timeStopBtn.Location = new System.Drawing.Point(639, 48);
			this.timeStopBtn.Name = "timeStopBtn";
			this.timeStopBtn.Size = new System.Drawing.Size(94, 32);
			this.timeStopBtn.TabIndex = 13;
			this.timeStopBtn.Text = "定时取消";
			this.timeStopBtn.UseVisualStyleBackColor = true;
			this.timeStopBtn.Click += new System.EventHandler(this.timeStopBtn_Click);
			// 
			// stateLb
			// 
			this.stateLb.AutoSize = true;
			this.stateLb.Location = new System.Drawing.Point(638, 95);
			this.stateLb.Name = "stateLb";
			this.stateLb.Size = new System.Drawing.Size(37, 15);
			this.stateLb.TabIndex = 14;
			this.stateLb.Text = "状态";
			// 
			// timerLb
			// 
			this.timerLb.AutoSize = true;
			this.timerLb.Location = new System.Drawing.Point(726, 153);
			this.timerLb.Name = "timerLb";
			this.timerLb.Size = new System.Drawing.Size(52, 15);
			this.timerLb.TabIndex = 15;
			this.timerLb.Text = "未定时";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(638, 153);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 15);
			this.label6.TabIndex = 16;
			this.label6.Text = "定时";
			// 
			// mouseLb
			// 
			this.mouseLb.AutoSize = true;
			this.mouseLb.Location = new System.Drawing.Point(726, 124);
			this.mouseLb.Name = "mouseLb";
			this.mouseLb.Size = new System.Drawing.Size(37, 15);
			this.mouseLb.TabIndex = 17;
			this.mouseLb.Text = "暂停";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(638, 183);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 15);
			this.label8.TabIndex = 18;
			this.label8.Text = "间隔";
			// 
			// itvLb
			// 
			this.itvLb.AutoSize = true;
			this.itvLb.Location = new System.Drawing.Point(726, 183);
			this.itvLb.Name = "itvLb";
			this.itvLb.Size = new System.Drawing.Size(47, 15);
			this.itvLb.TabIndex = 19;
			this.itvLb.Text = "100ms";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(638, 124);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 15);
			this.label10.TabIndex = 20;
			this.label10.Text = "鼠标";
			// 
			// msgLb
			// 
			this.msgLb.AutoSize = true;
			this.msgLb.Location = new System.Drawing.Point(16, 212);
			this.msgLb.Name = "msgLb";
			this.msgLb.Size = new System.Drawing.Size(37, 15);
			this.msgLb.TabIndex = 21;
			this.msgLb.Text = "信息";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(379, 107);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(247, 30);
			this.label5.TabIndex = 22;
			this.label5.Text = "按F1键控制暂停/继续，\r\n定时器必须先取消再重新设定时间！";
			// 
			// testBtn
			// 
			this.testBtn.Location = new System.Drawing.Point(500, 195);
			this.testBtn.Name = "testBtn";
			this.testBtn.Size = new System.Drawing.Size(94, 32);
			this.testBtn.TabIndex = 23;
			this.testBtn.Text = "test";
			this.testBtn.UseVisualStyleBackColor = true;
			this.testBtn.Visible = false;
			this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
			// 
			// timeUpdateBtn1
			// 
			this.timeUpdateBtn1.Location = new System.Drawing.Point(273, 166);
			this.timeUpdateBtn1.Name = "timeUpdateBtn1";
			this.timeUpdateBtn1.Size = new System.Drawing.Size(145, 32);
			this.timeUpdateBtn1.TabIndex = 24;
			this.timeUpdateBtn1.Text = "时间校对（测试）";
			this.timeUpdateBtn1.UseVisualStyleBackColor = true;
			this.timeUpdateBtn1.Click += new System.EventHandler(this.timeUpdateBtn_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(922, 28);
			this.menuStrip1.TabIndex = 25;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 菜单ToolStripMenuItem
			// 
			this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明ToolStripMenuItem});
			this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
			this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.菜单ToolStripMenuItem.Text = "菜单";
			// 
			// 说明ToolStripMenuItem
			// 
			this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
			this.说明ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
			this.说明ToolStripMenuItem.Text = "说明";
			this.说明ToolStripMenuItem.Click += new System.EventHandler(this.说明ToolStripMenuItem_Click);
			// 
			// nowBtn
			// 
			this.nowBtn.Location = new System.Drawing.Point(759, 48);
			this.nowBtn.Name = "nowBtn";
			this.nowBtn.Size = new System.Drawing.Size(94, 32);
			this.nowBtn.TabIndex = 26;
			this.nowBtn.Text = "现在";
			this.nowBtn.UseVisualStyleBackColor = true;
			this.nowBtn.Click += new System.EventHandler(this.nowBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(922, 249);
			this.Controls.Add(this.nowBtn);
			this.Controls.Add(this.timeUpdateBtn1);
			this.Controls.Add(this.testBtn);
			this.Controls.Add(this.msgLb);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.itvLb);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.mouseLb);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.timerLb);
			this.Controls.Add(this.stateLb);
			this.Controls.Add(this.timeStopBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.setItvBtn);
			this.Controls.Add(this.itvTB);
			this.Controls.Add(this.msTB);
			this.Controls.Add(this.secTB);
			this.Controls.Add(this.minTB);
			this.Controls.Add(this.hourTB);
			this.Controls.Add(this.setTimerBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "MouseM@ster v0.1.1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button setTimerBtn;
		private System.Windows.Forms.TextBox hourTB;
		private System.Windows.Forms.TextBox minTB;
		private System.Windows.Forms.TextBox secTB;
		private System.Windows.Forms.TextBox msTB;
		private System.Windows.Forms.TextBox itvTB;
		private System.Windows.Forms.Button setItvBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button timeStopBtn;
		private System.Windows.Forms.Label stateLb;
		private System.Windows.Forms.Label timerLb;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label mouseLb;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label itvLb;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label msgLb;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button testBtn;
		private System.Windows.Forms.Button timeUpdateBtn1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
		private System.Windows.Forms.Button nowBtn;
	}
}

