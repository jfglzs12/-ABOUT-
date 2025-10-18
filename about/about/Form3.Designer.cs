
namespace WindowsApplication1
{

	public partial class Form3 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00003258 File Offset: 0x00001458
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this._ItemWrapper != null)
				{
					this._ItemWrapper.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0400001C RID: 28
		private global::System.ComponentModel.IContainer _ItemWrapper;
	}
}
