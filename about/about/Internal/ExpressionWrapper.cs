using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1.Internal
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[StandardModule]
	[HideModuleName]
	internal sealed class ExpressionWrapper
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000223E File Offset: 0x0000043E
		[HelpKeyword("My.Computer")]
		internal static WrapperWrapper FlushUtils
		{
			[DebuggerHidden]
			get
			{
				return ExpressionWrapper.m_ModelWrapper.CalcUtils();
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000224A File Offset: 0x0000044A
		[HelpKeyword("My.Application")]
		internal static UtilsWrapper DestroyUtils
		{
			[DebuggerHidden]
			get
			{
				return ExpressionWrapper.setterWrapper.CalcUtils();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002256 File Offset: 0x00000456
		[HelpKeyword("My.User")]
		internal static User ViewUtils
		{
			[DebuggerHidden]
			get
			{
				return ExpressionWrapper.m_MethodWrapper.CalcUtils();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002262 File Offset: 0x00000462
		[HelpKeyword("My.Forms")]
		internal static ExpressionWrapper.SystemWrapper NewUtils
		{
			[DebuggerHidden]
			get
			{
				return ExpressionWrapper.m_PublisherWrapper.CalcUtils();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000226E File Offset: 0x0000046E
		[HelpKeyword("My.WebServices")]
		internal static ExpressionWrapper.PredicateWrapper RemoveUtils
		{
			[DebuggerHidden]
			get
			{
				return ExpressionWrapper._ComparatorWrapper.CalcUtils();
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly ExpressionWrapper.TestsWrapper<WrapperWrapper> m_ModelWrapper = new ExpressionWrapper.TestsWrapper<WrapperWrapper>();

		// Token: 0x04000002 RID: 2
		private static readonly ExpressionWrapper.TestsWrapper<UtilsWrapper> setterWrapper = new ExpressionWrapper.TestsWrapper<UtilsWrapper>();

		// Token: 0x04000003 RID: 3
		private static readonly ExpressionWrapper.TestsWrapper<User> m_MethodWrapper = new ExpressionWrapper.TestsWrapper<User>();

		// Token: 0x04000004 RID: 4
		private static ExpressionWrapper.TestsWrapper<ExpressionWrapper.SystemWrapper> m_PublisherWrapper = new ExpressionWrapper.TestsWrapper<ExpressionWrapper.SystemWrapper>();

		// Token: 0x04000005 RID: 5
		private static readonly ExpressionWrapper.TestsWrapper<ExpressionWrapper.PredicateWrapper> _ComparatorWrapper = new ExpressionWrapper.TestsWrapper<ExpressionWrapper.PredicateWrapper>();

		// Token: 0x02000005 RID: 5
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class SystemWrapper
		{
			// Token: 0x0600000B RID: 11 RVA: 0x00002728 File Offset: 0x00000928
			[DebuggerHidden]
			private static T PostUtils<T>(T Instance) where T : Form, new()
			{
				T result;
				if (Instance != null && !Instance.IsDisposed)
				{
					result = Instance;
				}
				else
				{
					if (ExpressionWrapper.SystemWrapper.m_CallbackWrapper != null)
					{
						if (ExpressionWrapper.SystemWrapper.m_CallbackWrapper.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						ExpressionWrapper.SystemWrapper.m_CallbackWrapper = new Hashtable();
					}
					ExpressionWrapper.SystemWrapper.m_CallbackWrapper.Add(typeof(T), null);
					try
					{
						result = Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						}), ex.InnerException);
					}
					finally
					{
						ExpressionWrapper.SystemWrapper.m_CallbackWrapper.Remove(typeof(T));
					}
				}
				return result;
			}

			// Token: 0x0600000C RID: 12 RVA: 0x0000227A File Offset: 0x0000047A
			[DebuggerHidden]
			private void ReflectUtils<T>(ref T gparam_0) where T : Form
			{
				gparam_0.Dispose();
				gparam_0 = default(T);
			}

			// Token: 0x0600000D RID: 13 RVA: 0x0000228F File Offset: 0x0000048F
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SystemWrapper()
			{
			}

			// Token: 0x0600000E RID: 14 RVA: 0x00002297 File Offset: 0x00000497
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object obj)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(obj));
			}

			// Token: 0x0600000F RID: 15 RVA: 0x000022A5 File Offset: 0x000004A5
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000010 RID: 16 RVA: 0x000022AD File Offset: 0x000004AD
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal Type WriteUtils()
			{
				return typeof(ExpressionWrapper.SystemWrapper);
			}

			// Token: 0x06000011 RID: 17 RVA: 0x000022BA File Offset: 0x000004BA
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000012 RID: 18 RVA: 0x000022C2 File Offset: 0x000004C2
			// (set) Token: 0x06000014 RID: 20 RVA: 0x000022F4 File Offset: 0x000004F4
			public Form1 Form1
			{
				get
				{
					this.m_RecordWrapper = ExpressionWrapper.SystemWrapper.PostUtils<Form1>(this.m_RecordWrapper);
					return this.m_RecordWrapper;
				}
				set
				{
					if (value != this.m_RecordWrapper)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.ReflectUtils<Form1>(ref this.m_RecordWrapper);
					}
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000013 RID: 19 RVA: 0x000022DB File Offset: 0x000004DB
			// (set) Token: 0x06000015 RID: 21 RVA: 0x00002319 File Offset: 0x00000519
			public Form3 Form3
			{
				get
				{
					this.facadeWrapper = ExpressionWrapper.SystemWrapper.PostUtils<Form3>(this.facadeWrapper);
					return this.facadeWrapper;
				}
				set
				{
					if (value != this.facadeWrapper)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.ReflectUtils<Form3>(ref this.facadeWrapper);
					}
				}
			}

			// Token: 0x04000006 RID: 6
			[ThreadStatic]
			private static Hashtable m_CallbackWrapper;

			// Token: 0x04000007 RID: 7
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Form1 m_RecordWrapper;

			// Token: 0x04000008 RID: 8
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Form3 facadeWrapper;
		}

		// Token: 0x02000006 RID: 6
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class PredicateWrapper
		{
			// Token: 0x06000016 RID: 22 RVA: 0x00002297 File Offset: 0x00000497
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object obj)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(obj));
			}

			// Token: 0x06000017 RID: 23 RVA: 0x000022A5 File Offset: 0x000004A5
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000018 RID: 24 RVA: 0x0000233E File Offset: 0x0000053E
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal Type ResetUtils()
			{
				return typeof(ExpressionWrapper.PredicateWrapper);
			}

			// Token: 0x06000019 RID: 25 RVA: 0x000022BA File Offset: 0x000004BA
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600001A RID: 26 RVA: 0x0000282C File Offset: 0x00000A2C
			[DebuggerHidden]
			private static T AwakeUtils<T>(T instance) where T : new()
			{
				T result;
				if (instance == null)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x0600001B RID: 27 RVA: 0x0000234B File Offset: 0x0000054B
			[DebuggerHidden]
			private void CreateUtils<T>(ref T gparam_0)
			{
				gparam_0 = default(T);
			}

			// Token: 0x0600001C RID: 28 RVA: 0x0000228F File Offset: 0x0000048F
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public PredicateWrapper()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class TestsWrapper<T> where T : new()
		{
			// Token: 0x0600001D RID: 29 RVA: 0x00002354 File Offset: 0x00000554
			[DebuggerHidden]
			internal T CalcUtils()
			{
				if (ExpressionWrapper.TestsWrapper<T>.indexerWrapper == null)
				{
					ExpressionWrapper.TestsWrapper<T>.indexerWrapper = Activator.CreateInstance<T>();
				}
				return ExpressionWrapper.TestsWrapper<T>.indexerWrapper;
			}

			// Token: 0x0600001E RID: 30 RVA: 0x0000228F File Offset: 0x0000048F
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public TestsWrapper()
			{
			}

			// Token: 0x04000009 RID: 9
			[CompilerGenerated]
			[ThreadStatic]
			private static T indexerWrapper;
		}
	}
}
