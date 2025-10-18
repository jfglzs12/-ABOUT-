namespace WindowsApplication1
{

	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002A44 File Offset: 0x00000C44
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.m_EventWrapper != null)
				{
					this.m_EventWrapper.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.IContainer m_EventWrapper;
	}
}
