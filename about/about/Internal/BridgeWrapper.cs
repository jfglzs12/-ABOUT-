using System;
using System.Runtime.InteropServices;

namespace WindowsApplication1.Internal
{
	// Token: 0x02000016 RID: 22
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
	internal sealed class BridgeWrapper : Attribute
	{
		// Token: 0x0600009C RID: 156 RVA: 0x000026BC File Offset: 0x000008BC
		public bool ComputeWrapper()
		{
			return this.m_RegistryWrapper;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000026C4 File Offset: 0x000008C4
		public void AddWrapper(bool bool_0)
		{
			this.m_RegistryWrapper = bool_0;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000026CD File Offset: 0x000008CD
		public bool RegisterWrapper()
		{
			return this.m_HelperWrapper;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000026D5 File Offset: 0x000008D5
		public void InstantiateWrapper(bool bool_0)
		{
			this.m_HelperWrapper = bool_0;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000026DE File Offset: 0x000008DE
		public string DisableWrapper()
		{
			return this.initializerWrapper;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000026E6 File Offset: 0x000008E6
		public void SearchWrapper(string string_0)
		{
			this.initializerWrapper = string_0;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000026EF File Offset: 0x000008EF
		public bool RestartWrapper()
		{
			return this._MerchantWrapper;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000026F7 File Offset: 0x000008F7
		public void LogoutWrapper(bool bool_0)
		{
			this._MerchantWrapper = bool_0;
		}

		// Token: 0x0400003C RID: 60
		private bool m_RegistryWrapper = true;

		// Token: 0x0400003D RID: 61
		private bool m_HelperWrapper = true;

		// Token: 0x0400003E RID: 62
		private bool _MerchantWrapper = true;

		// Token: 0x0400003F RID: 63
		private string initializerWrapper = "";
	}
}
