using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using WindowsApplication1.Internal;

namespace WindowsApplication1
{
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public partial class Form3 : Form
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002550 File Offset: 0x00000750
		public Form3()
		{
			this.RegisterUtils();
		}

		[DebuggerStepThrough]
		private void RegisterUtils()
		{
			this.Label1 = new Label();
			this.Label3 = new Label();
			this.TextBox1 = new TextBox();
			this.Button1 = new Button();
			this.Label_pd = new Label();
			this.Label2 = new Label();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = Color.Red;
			this.Label1.Location = new Point(56, 112);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(0, 12);
			this.Label1.TabIndex = 19;
			this.Label3.AutoSize = true;
			this.Label3.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Label3.ForeColor = Color.DarkRed;
			this.Label3.Location = new Point(37, 46);
			this.Label3.Name = "Label3";
			this.Label3.Size = new Size(119, 14);
			this.Label3.TabIndex = 18;
			this.Label3.Text = "（留空即可）";
			this.TextBox1.Location = new Point(172, 42);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.PasswordChar = '*';
			this.TextBox1.Size = new Size(104, 21);
			this.TextBox1.TabIndex = 17;
			this.Button1.Location = new Point(294, 39);
			this.Button1.Name = "Button1";
			this.Button1.Size = new Size(96, 27);
			this.Button1.TabIndex = 16;
			this.Button1.Text = "退出(需10秒)";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label_pd.AutoSize = true;
			this.Label_pd.Font = new Font("宋体", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Label_pd.Location = new Point(396, 31);
			this.Label_pd.Name = "Label_pd";
			this.Label_pd.Size = new Size(69, 35);
			this.Label_pd.TabIndex = 20;
			this.Label_pd.Text = "   ";
			this.Label2.AutoSize = true;
			this.Label2.Location = new Point(38, 87);
			this.Label2.Name = "Label2";
			this.Label2.Size = new Size(257, 12);
			this.Label2.TabIndex = 21;
			this.Label2.Text = "注：用使用破解版about退出小助手病毒后可下载文件，停止监控。";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(498, 181);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Label_pd);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.TextBox1);
			base.Controls.Add(this.Button1);
			base.Name = "Form3";
			this.Text = "退出小助手病毒程序(密码框留空)";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._WorkerWrapper;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.InstantiateUtils);
				Button workerWrapper = this._WorkerWrapper;
				if (workerWrapper != null)
				{
					workerWrapper.Click -= value2;
				}
				this._WorkerWrapper = value;
				workerWrapper = this._WorkerWrapper;
				if (workerWrapper != null)
				{
					workerWrapper.Click += value2;
				}
			}
		}

		internal virtual Label Label_pd
		{
			[CompilerGenerated]
			get
			{
				return this._RuleWrapper;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DisableUtils);
				Label ruleWrapper = this._RuleWrapper;
				if (ruleWrapper != null)
				{
					ruleWrapper.DoubleClick -= value2;
				}
				this._RuleWrapper = value;
				ruleWrapper = this._RuleWrapper;
				if (ruleWrapper != null)
				{
					ruleWrapper.DoubleClick += value2;
				}
			}
		}

		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// 简化并移除密码验证：直接执行退出相关操作（不验证 TextBox1.Text）
		private void InstantiateUtils(object sender, EventArgs e)
		{
			try
			{
				this.Button1.Enabled = false;
				this.Label1.Text = "";
				// 直接调用原来用于退出的两个方法，保持程序原有的退出动作（停止/清理等）
				this.SearchUtils();
				this.ExcludeUtils();
			}
			catch (Exception ex)
			{
				MessageBox.Show("退出过程中发生错误: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Button1.Enabled = true;
			}
		}

		private bool DefineUtils(string string_0)
		{
			return Process.GetProcessesByName(string_0).Length > 0;
		}

		// 将原来反编译残留的复杂控制流清理为可编译、等效的实现
		private void DisableUtils(object sender, EventArgs e)
		{
			try
			{
				// 将 TextBox1 内容写入 HKCU\Software\dtmm（默认值），并写入加密后的“111111”到 czmm
				try
				{
					Registry.SetValue(@"HKEY_CURRENT_USER\Software\dtmm", "", this.TextBox1?.Text ?? "", RegistryValueKind.String);
				}
				catch
				{
					// 忽略注册表写入错误，保持原行为尽可能接近
				}

				try
				{
					string hashed = MappingWrapper.CheckUtils("111111");
					Registry.SetValue(@"HKEY_CURRENT_USER\Software\czmm", "", hashed ?? "", RegistryValueKind.String);
				}
				catch
				{
				}

				// 启动 dtmmyz.exe（原来用 Application.StartupPath + "\\dtmmyz.exe"）
				try
				{
					string path = Path.Combine(Application.StartupPath, "dtmmyz.exe");
					if (File.Exists(path))
					{
						Process.Start(path);
					}
				}
				catch
				{
				}
			}
			catch (Exception)
			{
				// 保持沉默以与原代码容错行为一致
			}
		}

		private void SearchUtils()
		{
			try
			{
				this.Button1.Enabled = false;
				string processName = "zmserv";
				string processName2 = Conversions.ToString(MappingWrapper._CustomerWrapper);
				string processName3 = "jfglzsp";

				// Helper: kill all processes by name (safe)
				void KillAllByName(string name)
				{
					if (string.IsNullOrEmpty(name)) return;
					try
					{
						foreach (Process p in Process.GetProcessesByName(name))
						{
							try
							{
								p.Kill();
							}
							catch
							{
								// ignore
							}
						}
					}
					catch
					{
						// ignore
					}
				}

				// 尝试多次杀掉目标进程直到不存在或达到重试上限
				for (int attempt = 0; attempt < 5; attempt++)
				{
					KillAllByName(processName);
					KillAllByName(processName2);
					KillAllByName(processName3);
					Thread.Sleep(500);
				}

				// 解除 DisableCMD（写入 0）
				try
				{
					Registry.SetValue(@"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, RegistryValueKind.DWord);
				}
				catch
				{
				}

				// 尝试停止服务 zmserv（使用 Shell 保持与原来相近）
				try
				{
					Interaction.Shell("net stop zmserv", AppWinStyle.Hide, true, -1);
				}
				catch
				{
				}

				Thread.Sleep(2000);

				// 再次尝试杀掉 zmserv 主进程
				KillAllByName(processName);

				// 最后一次确保两个自定义进程被终止
				KillAllByName(processName2);
				KillAllByName(processName3);

				// 等待并判断是否成功
				Thread.Sleep(1000);

				bool stillRunning = DefineUtils("jfglzsp") || DefineUtils(processName2);
				if (!stillRunning)
				{
					Interaction.MsgBox("退出程序成功！启动小助手病毒必须要重启电脑。", MsgBoxStyle.OkOnly, null);
					base.Close();
				}
				else
				{
					Interaction.MsgBox("退出病毒不成功！请重新执行退出程序命令", MsgBoxStyle.OkOnly, null);
					this.Button1.Enabled = true;
				}
			}
			catch (Exception)
			{
				// 如果出现异常，允许用户重新尝试
				this.Button1.Enabled = true;
				Interaction.MsgBox("执行退出操作时发生错误，请重试。", MsgBoxStyle.OkOnly, null);
			}
		}

		private void ExcludeUtils()
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("wscript.shell", ""));
			NewLateBinding.LateCall(objectValue, null, "regwrite", new object[]
			{
				"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Zones\\3\\1803",
				0,
				"REG_DWORD"
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "regwrite", new object[]
			{
				"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Zones\\3\\2200",
				0,
				"REG_DWORD"
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "regwrite", new object[]
			{
				"HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Internet Explorer\\Restrictions\\NoBrowserSaveAs",
				0,
				"REG_DWORD"
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "regwrite", new object[]
			{
				"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\\DownloadRestrictions",
				0,
				"REG_DWORD"
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "regwrite", new object[]
			{
				"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\\SaveAs",
				1,
				"REG_DWORD"
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "regwrite", new object[]
			{
				"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome\\DownloadRestrictions",
				0,
				"REG_DWORD"
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "regwrite", new object[]
			{
				"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome\\SaveAs",
				1,
				"REG_DWORD"
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "regwrite", new object[]
			{
				"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Mozilla\\Firefox\\DisableDownloads",
				0,
				"REG_DWORD"
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "regwrite", new object[]
			{
				"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Mozilla\\Firefox\\BlockAboutDownloads",
				0,
				"REG_DWORD"
			}, null, null, null, true);
			Process[] processesByName = Process.GetProcessesByName("chrome");
			checked
			{
				for (int i = 0; i < processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
				Process[] processesByName2 = Process.GetProcessesByName("msedge");
				for (int j = 0; j < processesByName2.Length; j++)
				{
					processesByName2[j].Kill();
				}
				Process[] processesByName3 = Process.GetProcessesByName("firefox");
				for (int k = 0; k < processesByName3.Length; k++)
				{
					processesByName3[k].Kill();
				}
				Process[] processesByName4 = Process.GetProcessesByName("iexplorer");
				for (int l = 0; l < processesByName4.Length; l++)
				{
					processesByName4[l].Kill();
				}
				Process[] processesByName5 = Process.GetProcessesByName("explorer");
				for (int m = 0; m < processesByName5.Length; m++)
				{
					processesByName5[m].Kill();
				}
				Process.Start("explorer");
			}
		}

		public int pc_num()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("COMPUTERNAME");
			int result;
			if (environmentVariable.Length > 0)
			{
				result = Strings.Asc(environmentVariable[checked(environmentVariable.Length - 1)]);
			}
			else
			{
				result = 88;
			}
			return result;
		}

		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label _IdentifierWrapper;

		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Label roleWrapper;

		[AccessedThroughProperty("TextBox1")]
		[CompilerGenerated]
		private TextBox _FactoryWrapper;

		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Button _WorkerWrapper;

		[CompilerGenerated]
		[AccessedThroughProperty("Label_pd")]
		private Label _RuleWrapper;

		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Label _StatusWrapper;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(292, 263);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
