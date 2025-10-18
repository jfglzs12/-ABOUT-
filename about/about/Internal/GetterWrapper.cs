using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1.Internal
{
	// Token: 0x02000008 RID: 8
	[StandardModule]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[HideModuleName]
	[CompilerGenerated]
	internal sealed class GetterWrapper
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002371 File Offset: 0x00000571
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(GetterWrapper.resourceMan, null))
				{
					GetterWrapper.resourceMan = new ResourceManager("WindowsApplication1.Resources", typeof(GetterWrapper).Assembly);
				}
				return GetterWrapper.resourceMan;
			}
		}

		// Token: 0x17000009 RID: 9
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000023A4 File Offset: 0x000005A4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			set
			{
				GetterWrapper.resourceCulture = value;
			}
		}

		// Token: 0x0400000A RID: 10
		private static ResourceManager resourceMan;

		// Token: 0x0400000B RID: 11
		private static object resourceCulture;
	}
}
