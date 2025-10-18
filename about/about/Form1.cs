using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WindowsApplication1.Internal;

namespace WindowsApplication1
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x06000026 RID: 38 RVA: 0x000023F8 File Offset: 0x000005F8
		public Form1()
		{
			base.Load += this.MapUtils;
			this.MoveUtils();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002418 File Offset: 0x00000618
		private void VisitUtils(object sender, EventArgs e)
		{
			ExpressionWrapper.NewUtils.Form3.Show();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002429 File Offset: 0x00000629
		private void ForgotUtils(object sender, EventArgs e)
		{
			Process.Start(Application.StartupPath + "\\set.exe", Conversions.ToString(1));
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002446 File Offset: 0x00000646
		private void PublishUtils(object sender, EventArgs e)
		{
			NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Wscript.Shell", "")), null, "Run", new object[]
			{
				"http://www.jfglzs.com/"
			}, null, null, null, true);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000028BC File Offset: 0x00000ABC
		private bool TestUtils(string string_0)
		{
			return Process.GetProcessesByName(string_0).Length > 0;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000247A File Offset: 0x0000067A
		private void CompareUtils(object sender, EventArgs e)
		{
			if (!this.TestUtils("jfglzsp"))
			{
				this.Label2.Text = "关 闭";
				return;
			}
			this.Label2.Text = "正在运行中。。。";
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000024AA File Offset: 0x000006AA
		private void CalculateUtils(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.jfglzs.com");
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000024B7 File Offset: 0x000006B7
		private void PushUtils(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000024B9 File Offset: 0x000006B9
		private void ComputeUtils(object sender, EventArgs e)
		{
			MessageBox.Show("你更新你妈呢？", "涂色大师");
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000024D0 File Offset: 0x000006D0
		private void AddUtils(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.jfglzs.com/c1.html");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000028DC File Offset: 0x00000ADC
		private void MapUtils(object sender, EventArgs e)
		{
			checked
			{
				int num = DateAndTime.Month(DateAndTime.Now) * DateAndTime.Day(DateAndTime.Now);
				int num2 = num % 7;
				int num3 = num % 9;
				int num4 = num % 5;
				int num5 = num % 3;
				string text;
				if (num % 2 == 0)
				{
					text = Conversions.ToString(Strings.Chr(97 + num2)) + Conversions.ToString(Strings.Chr(98 + num3)) + Conversions.ToString(Strings.Chr(101 + num4)) + Conversions.ToString(Strings.Chr(99 + num5));
				}
				else
				{
					text = Conversions.ToString(Strings.Chr(97 + num3)) + Conversions.ToString(Strings.Chr(98 + num2)) + Conversions.ToString(Strings.Chr(101 + num5)) + Conversions.ToString(Strings.Chr(99 + num4));
				}
				MappingWrapper._CustomerWrapper = text;
				MappingWrapper.infoWrapper = text + ".exe";
				VBMath.Randomize((double)num);
				long num6 = (long)Math.Round(unchecked((double)VBMath.Rnd() * 100000.0 * 3.0 + 1.0));
				string text2 = "";
				int num7 = 1;
				do
				{
					text2 = Conversions.ToString(Strings.Chr((int)(num6 % 10L + 105L))) + text2;
					num6 /= 10L;
					num7++;
				}
				while (num7 <= 5);
				MappingWrapper._CustomerWrapper = text2;
				MappingWrapper.infoWrapper = text2 + ".exe";
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002A84 File Offset: 0x00000C84
		[DebuggerStepThrough]
		private void MoveUtils()
		{
			this.m_EventWrapper = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.MenuStrip1 = new MenuStrip();
			this.系统功能FToolStripMenuItem = new ToolStripMenuItem();
			this.设置ToolStripMenuItem = new ToolStripMenuItem();
			this.退出程序ToolStripMenuItem = new ToolStripMenuItem();
			this.访问官网ToolStripMenuItem = new ToolStripMenuItem();
			this.更新程序ToolStripMenuItem = new ToolStripMenuItem();
			this.Timer1 = new Timer(this.m_EventWrapper);
			this.Label2 = new Label();
			this.Label1 = new Label();
			this.LinkLabel1 = new LinkLabel();
			this.LinkLabel2 = new LinkLabel();
			this.MenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.MenuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.系统功能FToolStripMenuItem
			});
			this.MenuStrip1.Location = new Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new Size(682, 25);
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "MenuStrip1";
			this.系统功能FToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.设置ToolStripMenuItem,
				this.退出程序ToolStripMenuItem,
				this.访问官网ToolStripMenuItem,
				this.更新程序ToolStripMenuItem
			});
			this.系统功能FToolStripMenuItem.Name = "系统功能FToolStripMenuItem";
			this.系统功能FToolStripMenuItem.Size = new Size(98, 21);
			this.系统功能FToolStripMenuItem.Text = "系统功能（F）";
			this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
			this.设置ToolStripMenuItem.Size = new Size(124, 22);
			this.设置ToolStripMenuItem.Text = "设置";
			this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
			this.退出程序ToolStripMenuItem.Size = new Size(124, 22);
			this.退出程序ToolStripMenuItem.Text = "退出程序！！！";
			this.访问官网ToolStripMenuItem.Name = "访问官网ToolStripMenuItem";
			this.访问官网ToolStripMenuItem.Size = new Size(124, 22);
			this.访问官网ToolStripMenuItem.Text = "访问官网";
			this.更新程序ToolStripMenuItem.Name = "更新程序ToolStripMenuItem";
			this.更新程序ToolStripMenuItem.Size = new Size(124, 22);
			this.更新程序ToolStripMenuItem.Text = "更新程序";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 500;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = Color.Transparent;
			this.Label2.ForeColor = Color.Red;
			this.Label2.Location = new Point(157, 413);
			this.Label2.Name = "Label2";
			this.Label2.Size = new Size(41, 12);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Label2";
			this.Label1.AutoSize = true;
			this.Label1.BackColor = Color.Transparent;
			this.Label1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Label1.ForeColor = Color.Blue;
			this.Label1.Location = new Point(39, 412);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(125, 12);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "当前小助手工作状态：";
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.BackColor = Color.Transparent;
			this.LinkLabel1.Location = new Point(537, 308);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new Size(53, 12);
			this.LinkLabel1.TabIndex = 5;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "访问官网";
			this.LinkLabel2.AutoSize = true;
			this.LinkLabel2.BackColor = Color.Transparent;
			this.LinkLabel2.Location = new Point(268, 412);
			this.LinkLabel2.Name = "LinkLabel2";
			this.LinkLabel2.Size = new Size(53, 12);
			this.LinkLabel2.TabIndex = 6;
			this.LinkLabel2.TabStop = true;
			this.LinkLabel2.Text = "查看帮助";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
			base.ClientSize = new Size(682, 486);
			base.Controls.Add(this.LinkLabel2);
			base.Controls.Add(this.LinkLabel1);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.MenuStrip1);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.MenuStrip1;
			base.Name = "Form1";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "学生机房管理助手about破解版(适用v11.3)";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000024DD File Offset: 0x000006DD
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00003038 File Offset: 0x00001238
		internal virtual MenuStrip MenuStrip1
		{
			[CompilerGenerated]
			get
			{
				return this.tokenWrapper;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ToolStripItemClickedEventHandler value2 = new ToolStripItemClickedEventHandler(this.PushUtils);
				MenuStrip menuStrip = this.tokenWrapper;
				if (menuStrip != null)
				{
					menuStrip.ItemClicked -= value2;
				}
				this.tokenWrapper = value;
				menuStrip = this.tokenWrapper;
				if (menuStrip != null)
				{
					menuStrip.ItemClicked += value2;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000024E5 File Offset: 0x000006E5
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000024ED File Offset: 0x000006ED
		internal virtual ToolStripMenuItem 系统功能FToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000024F6 File Offset: 0x000006F6
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000307C File Offset: 0x0000127C
		internal virtual ToolStripMenuItem 设置ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this.authenticationWrapper;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ForgotUtils);
				ToolStripMenuItem toolStripMenuItem = this.authenticationWrapper;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.authenticationWrapper = value;
				toolStripMenuItem = this.authenticationWrapper;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000024FE File Offset: 0x000006FE
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000030C0 File Offset: 0x000012C0
		internal virtual ToolStripMenuItem 退出程序ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this.iteratorWrapper;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.VisitUtils);
				ToolStripMenuItem toolStripMenuItem = this.iteratorWrapper;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.iteratorWrapper = value;
				toolStripMenuItem = this.iteratorWrapper;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002506 File Offset: 0x00000706
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00003104 File Offset: 0x00001304
		internal virtual ToolStripMenuItem 访问官网ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this.m_StrategyWrapper;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PublishUtils);
				ToolStripMenuItem strategyWrapper = this.m_StrategyWrapper;
				if (strategyWrapper != null)
				{
					strategyWrapper.Click -= value2;
				}
				this.m_StrategyWrapper = value;
				strategyWrapper = this.m_StrategyWrapper;
				if (strategyWrapper != null)
				{
					strategyWrapper.Click += value2;
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000250E File Offset: 0x0000070E
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00003148 File Offset: 0x00001348
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._AlgoWrapper;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CompareUtils);
				Timer algoWrapper = this._AlgoWrapper;
				if (algoWrapper != null)
				{
					algoWrapper.Tick -= value2;
				}
				this._AlgoWrapper = value;
				algoWrapper = this._AlgoWrapper;
				if (algoWrapper != null)
				{
					algoWrapper.Tick += value2;
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002516 File Offset: 0x00000716
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0000318C File Offset: 0x0000138C
		internal virtual ToolStripMenuItem 更新程序ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this.parserWrapper;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComputeUtils);
				ToolStripMenuItem toolStripMenuItem = this.parserWrapper;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.parserWrapper = value;
				toolStripMenuItem = this.parserWrapper;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000251E File Offset: 0x0000071E
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002526 File Offset: 0x00000726
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000252F File Offset: 0x0000072F
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002537 File Offset: 0x00000737
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002540 File Offset: 0x00000740
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000031D0 File Offset: 0x000013D0
		internal virtual LinkLabel LinkLabel1
		{
			[CompilerGenerated]
			get
			{
				return this._ConfigurationWrapper;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.CalculateUtils);
				LinkLabel configurationWrapper = this._ConfigurationWrapper;
				if (configurationWrapper != null)
				{
					configurationWrapper.LinkClicked -= value2;
				}
				this._ConfigurationWrapper = value;
				configurationWrapper = this._ConfigurationWrapper;
				if (configurationWrapper != null)
				{
					configurationWrapper.LinkClicked += value2;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002548 File Offset: 0x00000748
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00003214 File Offset: 0x00001414
		internal virtual LinkLabel LinkLabel2
		{
			[CompilerGenerated]
			get
			{
				return this.m_ComposerWrapper;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.AddUtils);
				LinkLabel composerWrapper = this.m_ComposerWrapper;
				if (composerWrapper != null)
				{
					composerWrapper.LinkClicked -= value2;
				}
				this.m_ComposerWrapper = value;
				composerWrapper = this.m_ComposerWrapper;
				if (composerWrapper != null)
				{
					composerWrapper.LinkClicked += value2;
				}
			}
		}

		// Token: 0x0400000F RID: 15
		private long _FieldWrapper;

		// Token: 0x04000011 RID: 17
		[AccessedThroughProperty("MenuStrip1")]
		[CompilerGenerated]
		private MenuStrip tokenWrapper;

		// Token: 0x04000012 RID: 18
		[CompilerGenerated]
		[AccessedThroughProperty("系统功能FToolStripMenuItem")]
		private ToolStripMenuItem descriptorWrapper;

		// Token: 0x04000013 RID: 19
		[AccessedThroughProperty("设置ToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem authenticationWrapper;

		// Token: 0x04000014 RID: 20
		[AccessedThroughProperty("退出程序ToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem iteratorWrapper;

		// Token: 0x04000015 RID: 21
		[CompilerGenerated]
		[AccessedThroughProperty("访问官网ToolStripMenuItem")]
		private ToolStripMenuItem m_StrategyWrapper;

		// Token: 0x04000016 RID: 22
		[AccessedThroughProperty("Timer1")]
		[CompilerGenerated]
		private Timer _AlgoWrapper;

		// Token: 0x04000017 RID: 23
		[AccessedThroughProperty("更新程序ToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem parserWrapper;

		// Token: 0x04000018 RID: 24
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Label m_ParamWrapper;

		// Token: 0x04000019 RID: 25
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Label _BroadcasterWrapper;

		// Token: 0x0400001A RID: 26
		[AccessedThroughProperty("LinkLabel1")]
		[CompilerGenerated]
		private LinkLabel _ConfigurationWrapper;

		// Token: 0x0400001B RID: 27
		[AccessedThroughProperty("LinkLabel2")]
		[CompilerGenerated]
		private LinkLabel m_ComposerWrapper;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(292, 263);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
