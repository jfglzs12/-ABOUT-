using System;
using System.Windows.Forms;

namespace WindowsApplication1.Internal
{
	// Token: 0x02000014 RID: 20
	internal class ProccesorWrapper
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00008F34 File Offset: 0x00007134
		internal static void smethod_0()
		{
			if (!ProccesorWrapper.m_WriterWrapper)
			{
				ProccesorWrapper.m_WriterWrapper = true;
				try
				{
					MessageBox.Show("This assembly is protected by an unregistered version of \"IntelliLock\"!", "www.eziriz.com");
				}
				catch
				{
					ProccesorWrapper.CompareWrapper("<script language='javascript'>alert( \"This assembly is protected by an unregistered version of IntelliLock!\" );</script>");
				}
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000024B7 File Offset: 0x000006B7
		internal static void CompareWrapper(object object_0)
		{
		}

		// Token: 0x04000039 RID: 57
		private static bool m_WriterWrapper;
	}
}
