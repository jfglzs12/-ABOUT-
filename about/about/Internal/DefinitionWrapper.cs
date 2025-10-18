using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace WindowsApplication1.Internal
{
	// Token: 0x02000010 RID: 16
	internal class DefinitionWrapper
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00004D50 File Offset: 0x00002F50
		static DefinitionWrapper()
		{
			DefinitionWrapper._CandidateWrapper = false;
			DefinitionWrapper.readerWrapper = false;
			DefinitionWrapper.mapWrapper = new byte[0];
			DefinitionWrapper._ExceptionWrapper = new byte[0];
			DefinitionWrapper.paramsWrapper = new byte[0];
			DefinitionWrapper._ContainerWrapper = new byte[0];
			DefinitionWrapper.importerWrapper = IntPtr.Zero;
			DefinitionWrapper.objectWrapper = IntPtr.Zero;
			DefinitionWrapper._StructWrapper = new string[0];
			DefinitionWrapper.m_InterceptorWrapper = new int[0];
			DefinitionWrapper._ErrorWrapper = 1;
			DefinitionWrapper._PrinterWrapper = 0L;
			DefinitionWrapper.attributeWrapper = 0;
			DefinitionWrapper._PageWrapper = false;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000024B7 File Offset: 0x000006B7
		private void method_0()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004DF8 File Offset: 0x00002FF8
		internal static byte[] DeleteUtils(object object_0)
		{
			// 首先检查 object_0 是否为 null
			if (object_0 == null)
				throw new ArgumentNullException(nameof(object_0));

			// 检查 object_0 是否为 byte 数组
			if (!(object_0 is byte[]))
				throw new ArgumentException("object_0 must be a byte array", nameof(object_0));

			byte[] byteArray = (byte[])object_0;
			uint[] array = new uint[16];
			int num = 448 - byteArray.Length * 8 % 512;
			uint num2 = (uint)((num + 512) % 512);
			if (num2 == 0U)
			{
				num2 = 512U;
			}
			uint num3 = (uint)((long)byteArray.Length + (long)((ulong)(num2 / 8U)) + 8L);
			ulong num4 = (ulong)((long)byteArray.Length * 8L);
			byte[] array2 = new byte[num3];
			for (int i = 0; i < byteArray.Length; i++)
			{
				array2[i] = byteArray[i];
			}
			byte[] array3 = array2;
			int num5 = byteArray.Length;
			array3[num5] |= 128;
			for (int j = 8; j > 0; j--)
			{
				array2[(int)(checked((IntPtr)(unchecked((ulong)num3 - (ulong)((long)j)))))] = (byte)(num4 >> (8 - j) * 8 & 255UL);
			}
			uint num6 = (uint)(array2.Length * 8 / 32);
			uint num7 = 1732584193U;
			uint num8 = 4023233417U;
			uint num9 = 2562383102U;
			uint num10 = 271733878U;
			for (uint num11 = 0U; num11 < num6 / 16U; num11 += 1U)
			{
				uint num12 = num11 << 6;
				for (uint num13 = 0U; num13 < 61U; num13 += 4U)
				{
					array[(int)((UIntPtr)(num13 >> 2))] = (uint)((int)array2[(int)((UIntPtr)(num12 + (num13 + 3U)))] << 24 | (int)array2[(int)((UIntPtr)(num12 + (num13 + 2U)))] << 16 | (int)array2[(int)((UIntPtr)(num12 + (num13 + 1U)))] << 8 | (int)array2[(int)((UIntPtr)(num12 + num13))]);
				}
				uint num14 = num7;
				uint num15 = num8;
				uint num16 = num9;
				uint num17 = num10;
				DefinitionWrapper.GetUtils(ref num7, num8, num9, num10, 0U, 7, 1U, array);
				DefinitionWrapper.GetUtils(ref num10, num7, num8, num9, 1U, 12, 2U, array);
				DefinitionWrapper.GetUtils(ref num9, num10, num7, num8, 2U, 17, 3U, array);
				DefinitionWrapper.GetUtils(ref num8, num9, num10, num7, 3U, 22, 4U, array);
				DefinitionWrapper.GetUtils(ref num7, num8, num9, num10, 4U, 7, 5U, array);
				DefinitionWrapper.GetUtils(ref num10, num7, num8, num9, 5U, 12, 6U, array);
				DefinitionWrapper.GetUtils(ref num9, num10, num7, num8, 6U, 17, 7U, array);
				DefinitionWrapper.GetUtils(ref num8, num9, num10, num7, 7U, 22, 8U, array);
				DefinitionWrapper.GetUtils(ref num7, num8, num9, num10, 8U, 7, 9U, array);
				DefinitionWrapper.GetUtils(ref num10, num7, num8, num9, 9U, 12, 10U, array);
				DefinitionWrapper.GetUtils(ref num9, num10, num7, num8, 10U, 17, 11U, array);
				DefinitionWrapper.GetUtils(ref num8, num9, num10, num7, 11U, 22, 12U, array);
				DefinitionWrapper.GetUtils(ref num7, num8, num9, num10, 12U, 7, 13U, array);
				DefinitionWrapper.GetUtils(ref num10, num7, num8, num9, 13U, 12, 14U, array);
				DefinitionWrapper.GetUtils(ref num9, num10, num7, num8, 14U, 17, 15U, array);
				DefinitionWrapper.GetUtils(ref num8, num9, num10, num7, 15U, 22, 16U, array);
				DefinitionWrapper.StopUtils(ref num7, num8, num9, num10, 1U, 5, 17U, array);
				DefinitionWrapper.StopUtils(ref num10, num7, num8, num9, 6U, 9, 18U, array);
				DefinitionWrapper.StopUtils(ref num9, num10, num7, num8, 11U, 14, 19U, array);
				DefinitionWrapper.StopUtils(ref num8, num9, num10, num7, 0U, 20, 20U, array);
				DefinitionWrapper.StopUtils(ref num7, num8, num9, num10, 5U, 5, 21U, array);
				DefinitionWrapper.StopUtils(ref num10, num7, num8, num9, 10U, 9, 22U, array);
				DefinitionWrapper.StopUtils(ref num9, num10, num7, num8, 15U, 14, 23U, array);
				DefinitionWrapper.StopUtils(ref num8, num9, num10, num7, 4U, 20, 24U, array);
				DefinitionWrapper.StopUtils(ref num7, num8, num9, num10, 9U, 5, 25U, array);
				DefinitionWrapper.StopUtils(ref num10, num7, num8, num9, 14U, 9, 26U, array);
				DefinitionWrapper.StopUtils(ref num9, num10, num7, num8, 3U, 14, 27U, array);
				DefinitionWrapper.StopUtils(ref num8, num9, num10, num7, 8U, 20, 28U, array);
				DefinitionWrapper.StopUtils(ref num7, num8, num9, num10, 13U, 5, 29U, array);
				DefinitionWrapper.StopUtils(ref num10, num7, num8, num9, 2U, 9, 30U, array);
				DefinitionWrapper.StopUtils(ref num9, num10, num7, num8, 7U, 14, 31U, array);
				DefinitionWrapper.StopUtils(ref num8, num9, num10, num7, 12U, 20, 32U, array);
				DefinitionWrapper.SetupUtils(ref num7, num8, num9, num10, 5U, 4, 33U, array);
				DefinitionWrapper.SetupUtils(ref num10, num7, num8, num9, 8U, 11, 34U, array);
				DefinitionWrapper.SetupUtils(ref num9, num10, num7, num8, 11U, 16, 35U, array);
				DefinitionWrapper.SetupUtils(ref num8, num9, num10, num7, 14U, 23, 36U, array);
				DefinitionWrapper.SetupUtils(ref num7, num8, num9, num10, 1U, 4, 37U, array);
				DefinitionWrapper.SetupUtils(ref num10, num7, num8, num9, 4U, 11, 38U, array);
				DefinitionWrapper.SetupUtils(ref num9, num10, num7, num8, 7U, 16, 39U, array);
				DefinitionWrapper.SetupUtils(ref num8, num9, num10, num7, 10U, 23, 40U, array);
				DefinitionWrapper.SetupUtils(ref num7, num8, num9, num10, 13U, 4, 41U, array);
				DefinitionWrapper.SetupUtils(ref num10, num7, num8, num9, 0U, 11, 42U, array);
				DefinitionWrapper.SetupUtils(ref num9, num10, num7, num8, 3U, 16, 43U, array);
				DefinitionWrapper.SetupUtils(ref num8, num9, num10, num7, 6U, 23, 44U, array);
				DefinitionWrapper.SetupUtils(ref num7, num8, num9, num10, 9U, 4, 45U, array);
				DefinitionWrapper.SetupUtils(ref num10, num7, num8, num9, 12U, 11, 46U, array);
				DefinitionWrapper.SetupUtils(ref num9, num10, num7, num8, 15U, 16, 47U, array);
				DefinitionWrapper.SetupUtils(ref num8, num9, num10, num7, 2U, 23, 48U, array);
				DefinitionWrapper.ManageUtils(ref num7, num8, num9, num10, 0U, 6, 49U, array);
				DefinitionWrapper.ManageUtils(ref num10, num7, num8, num9, 7U, 10, 50U, array);
				DefinitionWrapper.ManageUtils(ref num9, num10, num7, num8, 14U, 15, 51U, array);
				DefinitionWrapper.ManageUtils(ref num8, num9, num10, num7, 5U, 21, 52U, array);
				DefinitionWrapper.ManageUtils(ref num7, num8, num9, num10, 12U, 6, 53U, array);
				DefinitionWrapper.ManageUtils(ref num10, num7, num8, num9, 3U, 10, 54U, array);
				DefinitionWrapper.ManageUtils(ref num9, num10, num7, num8, 10U, 15, 55U, array);
				DefinitionWrapper.ManageUtils(ref num8, num9, num10, num7, 1U, 21, 56U, array);
				DefinitionWrapper.ManageUtils(ref num7, num8, num9, num10, 8U, 6, 57U, array);
				DefinitionWrapper.ManageUtils(ref num10, num7, num8, num9, 15U, 10, 58U, array);
				DefinitionWrapper.ManageUtils(ref num9, num10, num7, num8, 6U, 15, 59U, array);
				DefinitionWrapper.ManageUtils(ref num8, num9, num10, num7, 13U, 21, 60U, array);
				DefinitionWrapper.ManageUtils(ref num7, num8, num9, num10, 4U, 6, 61U, array);
				DefinitionWrapper.ManageUtils(ref num10, num7, num8, num9, 11U, 10, 62U, array);
				DefinitionWrapper.ManageUtils(ref num9, num10, num7, num8, 2U, 15, 63U, array);
				DefinitionWrapper.ManageUtils(ref num8, num9, num10, num7, 9U, 21, 64U, array);
				num7 += num14;
				num8 += num15;
				num9 += num16;
				num10 += num17;
			}
			byte[] array4 = new byte[16];
			Array.Copy(BitConverter.GetBytes(num7), 0, array4, 0, 4);
			Array.Copy(BitConverter.GetBytes(num8), 0, array4, 4, 4);
			Array.Copy(BitConverter.GetBytes(num9), 0, array4, 8, 4);
			Array.Copy(BitConverter.GetBytes(num10), 0, array4, 12, 4);
			return array4;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000025B2 File Offset: 0x000007B2
		private static void GetUtils(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
		{
			// 检查 object_0 是否为 byte 数组
			if (!(object_0 is byte[] byteArray))
				throw new ArgumentException("object_0 must be a byte array", nameof(object_0));

			uint_0 = uint_1 + DefinitionWrapper.AssetUtils(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + byteArray[(int)((UIntPtr)uint_4)] + DefinitionWrapper.m_MockWrapper[(int)((UIntPtr)(uint_5 - 1U))], ushort_0);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000025DD File Offset: 0x000007DD
		private static void StopUtils(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
		{
			// 检查 object_0 是否为 byte 数组
			if (!(object_0 is byte[] byteArray))
				throw new ArgumentException("object_0 must be a byte array", nameof(object_0));

			uint_0 = uint_1 + DefinitionWrapper.AssetUtils(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + byteArray[(int)((UIntPtr)uint_4)] + DefinitionWrapper.m_MockWrapper[(int)((UIntPtr)(uint_5 - 1U))], ushort_0);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002608 File Offset: 0x00000808
		private static void SetupUtils(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
		{
			// 检查 object_0 是否为 byte 数组
			if (!(object_0 is byte[] byteArray))
				throw new ArgumentException("object_0 must be a byte array", nameof(object_0));

			uint_0 = uint_1 + DefinitionWrapper.AssetUtils(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + byteArray[(int)((UIntPtr)uint_4)] + DefinitionWrapper.m_MockWrapper[(int)((UIntPtr)(uint_5 - 1U))], ushort_0);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002630 File Offset: 0x00000830
		private static void ManageUtils(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
		{
			// 检查 object_0 是否为 byte 数组
			if (!(object_0 is byte[] byteArray))
				throw new ArgumentException("object_0 must be a byte array", nameof(object_0));

			uint_0 = uint_1 + DefinitionWrapper.AssetUtils(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + byteArray[(int)((UIntPtr)uint_4)] + DefinitionWrapper.m_MockWrapper[(int)((UIntPtr)(uint_5 - 1U))], ushort_0);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002659 File Offset: 0x00000859
		private static uint AssetUtils(uint uint_0, ushort ushort_0)
		{
			return uint_0 >> (int)(32 - ushort_0) | uint_0 << (int)ushort_0;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000266B File Offset: 0x0000086B
		internal static bool InitUtils()
		{
			if (!DefinitionWrapper._CandidateWrapper)
			{
				DefinitionWrapper.LoginUtils();
				DefinitionWrapper._CandidateWrapper = true;
			}
			return DefinitionWrapper.readerWrapper;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000549C File Offset: 0x0000369C
		internal static void LoginUtils()
		{
			try
			{
				DefinitionWrapper.readerWrapper = (bool)typeof(RijndaelManaged).Assembly.GetType("System.Security.Cryptography.CryptoConfig", false).GetMethod("get_AllowOnlyFipsAlgorithms", BindingFlags.Static | BindingFlags.Public).Invoke(null, new object[0]);
			}
			catch
			{
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000054FC File Offset: 0x000036FC
		internal static SymmetricAlgorithm InsertUtils()
		{
			SymmetricAlgorithm result = null;
			if (DefinitionWrapper.InitUtils())
			{
				try
				{
					return new AesCryptoServiceProvider();
				}
				catch
				{
					return new RijndaelManaged();
				}
			}
			result = new RijndaelManaged();
			return result;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002684 File Offset: 0x00000884
		internal static byte[] IncludeUtils(byte[] byte_0)
		{
			if (!DefinitionWrapper.InitUtils())
			{
				return new MD5CryptoServiceProvider().ComputeHash(byte_0);
			}
			return DefinitionWrapper.DeleteUtils(byte_0);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000553C File Offset: 0x0000373C
		static bool QueryUtils(int int_0)
		{
			if (DefinitionWrapper._ExceptionWrapper.Length == 0)
			{
				BinaryReader binaryReader = new BinaryReader(typeof(DefinitionWrapper).Assembly.GetManifestResourceStream("eab7545c-204f-43c0-95f7-00708c19c10f"));
				binaryReader.BaseStream.Position = 0L;
				byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
				byte[] array2 = new byte[32];
				array2[0] = 100;
				array2[0] = 163;
				array2[0] = 125;
				array2[0] = 133;
				array2[0] = 112;
				array2[0] = 12;
				array2[1] = 17;
				array2[1] = 113;
				array2[1] = 145;
				array2[2] = 92;
				array2[2] = 45;
				array2[2] = 87;
				array2[3] = 102;
				array2[3] = 196;
				array2[3] = 1;
				array2[4] = 183;
				array2[4] = 94;
				array2[4] = 100;
				array2[4] = 91;
				array2[5] = 88;
				array2[5] = 61;
				array2[5] = 197;
				array2[6] = 156;
				array2[6] = 164;
				array2[6] = 142;
				array2[6] = 84;
				array2[6] = 158;
				array2[7] = 39;
				array2[7] = 196;
				array2[7] = 115;
				array2[7] = 237;
				array2[7] = 96;
				array2[7] = 78;
				array2[8] = 144;
				array2[8] = 140;
				array2[8] = 242;
				array2[9] = 119;
				array2[9] = 134;
				array2[9] = 198;
				array2[10] = 131;
				array2[10] = 84;
				array2[10] = 160;
				array2[10] = 43;
				array2[11] = 125;
				array2[11] = 85;
				array2[11] = 129;
				array2[11] = 108;
				array2[12] = 64;
				array2[12] = 78;
				array2[12] = 238;
				array2[13] = 120;
				array2[13] = 144;
				array2[13] = 127;
				array2[13] = 122;
				array2[13] = 138;
				array2[13] = 109;
				array2[14] = 146;
				array2[14] = 122;
				array2[14] = 144;
				array2[14] = 26;
				array2[14] = 30;
				array2[15] = 98;
				array2[15] = 146;
				array2[15] = 58;
				array2[16] = 189;
				array2[16] = 146;
				array2[16] = 118;
				array2[16] = 142;
				array2[16] = 86;
				array2[16] = 66;
				array2[17] = 142;
				array2[17] = 13;
				array2[17] = 74;
				array2[18] = 118;
				array2[18] = 97;
				array2[18] = 89;
				array2[19] = 122;
				array2[19] = 97;
				array2[19] = 137;
				array2[19] = 237;
				array2[19] = 88;
				array2[19] = 27;
				array2[20] = 156;
				array2[20] = 107;
				array2[20] = 179;
				array2[20] = 116;
				array2[20] = 141;
				array2[20] = 200;
				array2[21] = 242;
				array2[21] = 98;
				array2[21] = 122;
				array2[21] = 139;
				array2[21] = 83;
				array2[22] = 124;
				array2[22] = 121;
				array2[22] = 177;
				array2[22] = 132;
				array2[22] = 104;
				array2[22] = 108;
				array2[23] = 127;
				array2[23] = 125;
				array2[23] = 144;
				array2[23] = 89;
				array2[24] = 116;
				array2[24] = 164;
				array2[24] = 106;
				array2[24] = 105;
				array2[24] = 134;
				array2[24] = 182;
				array2[25] = 135;
				array2[25] = 151;
				array2[25] = 206;
				array2[25] = 141;
				array2[25] = 217;
				array2[26] = 99;
				array2[26] = 160;
				array2[26] = 116;
				array2[27] = 96;
				array2[27] = 135;
				array2[27] = 109;
				array2[27] = 145;
				array2[27] = 219;
				array2[27] = 68;
				array2[28] = 169;
				array2[28] = 122;
				array2[28] = 160;
				array2[28] = 232;
				array2[29] = 160;
				array2[29] = 162;
				array2[29] = 112;
				array2[29] = 74;
				array2[29] = 146;
				array2[29] = 113;
				array2[30] = 113;
				array2[30] = 45;
				array2[30] = 146;
				array2[30] = 47;
				array2[31] = 159;
				array2[31] = 149;
				array2[31] = 137;
				array2[31] = 104;
				array2[31] = 49;
				byte[] rgbKey = array2;
				byte[] array3 = new byte[16];
				array3[0] = 100;
				array3[0] = 123;
				array3[0] = 182;
				array3[0] = 178;
				array3[1] = 112;
				array3[1] = 113;
				array3[1] = 17;
				array3[1] = 113;
				array3[1] = 43;
				array3[1] = 27;
				array3[2] = 149;
				array3[2] = 136;
				array3[2] = 152;
				array3[2] = 41;
				array3[3] = 87;
				array3[3] = 134;
				array3[3] = 101;
				array3[4] = 123;
				array3[4] = 114;
				array3[4] = 8;
				array3[5] = 145;
				array3[5] = 146;
				array3[5] = 21;
				array3[5] = 73;
				array3[6] = 88;
				array3[6] = 51;
				array3[6] = 135;
				array3[6] = 10;
				array3[6] = 51;
				array3[7] = 39;
				array3[7] = 196;
				array3[7] = 51;
				array3[7] = 169;
				array3[7] = 149;
				array3[7] = 198;
				array3[8] = 144;
				array3[8] = 178;
				array3[8] = 78;
				array3[8] = 213;
				array3[9] = 167;
				array3[9] = 90;
				array3[9] = 217;
				array3[10] = 161;
				array3[10] = 61;
				array3[10] = 136;
				array3[10] = 98;
				array3[10] = 128;
				array3[11] = 107;
				array3[11] = 167;
				array3[11] = 116;
				array3[11] = 43;
				array3[12] = 138;
				array3[12] = 145;
				array3[12] = 128;
				array3[12] = 32;
				array3[13] = 176;
				array3[13] = 176;
				array3[13] = 101;
				array3[13] = 105;
				array3[13] = 108;
				array3[13] = 193;
				array3[14] = 144;
				array3[14] = 87;
				array3[14] = 103;
				array3[14] = 98;
				array3[14] = 96;
				array3[14] = 31;
				array3[15] = 180;
				array3[15] = 58;
				array3[15] = 142;
				array3[15] = 142;
				array3[15] = 107;
				byte[] array4 = array3;
				byte[] publicKeyToken = typeof(DefinitionWrapper).Assembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length > 0)
				{
					array4[1] = publicKeyToken[0];
					array4[3] = publicKeyToken[1];
					array4[5] = publicKeyToken[2];
					array4[7] = publicKeyToken[3];
					array4[9] = publicKeyToken[4];
					array4[11] = publicKeyToken[5];
					array4[13] = publicKeyToken[6];
					array4[15] = publicKeyToken[7];
				}
				SymmetricAlgorithm symmetricAlgorithm = DefinitionWrapper.InsertUtils();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, array4);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				DefinitionWrapper._ExceptionWrapper = memoryStream.ToArray();
				memoryStream.Close();
				cryptoStream.Close();
				binaryReader.Close();
			}
			if (DefinitionWrapper.mapWrapper.Length == 0)
			{
				DefinitionWrapper.mapWrapper = DefinitionWrapper.ConcatWrapper(DefinitionWrapper.VerifyUtils(typeof(DefinitionWrapper).Assembly).ToString());
			}
			int num = 0;
			try
			{
				num = BitConverter.ToInt32(new byte[]
				{
					DefinitionWrapper._ExceptionWrapper[int_0],
					DefinitionWrapper._ExceptionWrapper[int_0 + 1],
					DefinitionWrapper._ExceptionWrapper[int_0 + 2],
					DefinitionWrapper._ExceptionWrapper[int_0 + 3]
				}, 0);
			}
			catch
			{
			}
			try
			{
				if (DefinitionWrapper.mapWrapper[num] == 128)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006020 File Offset: 0x00004220
		static string PrepareUtils(int int_0)
		{
			if (DefinitionWrapper.paramsWrapper.Length == 0)
			{
				BinaryReader binaryReader = new BinaryReader(typeof(DefinitionWrapper).Assembly.GetManifestResourceStream("6459b146-87a6-445f-b0ff-cfd37d1656e7"));
				binaryReader.BaseStream.Position = 0L;
				byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
				byte[] array2 = new byte[32];
				array2[0] = 92;
				array2[0] = 215;
				array2[0] = 213;
				array2[1] = 133;
				array2[1] = 110;
				array2[1] = 167;
				array2[1] = 46;
				array2[1] = 94;
				array2[2] = 145;
				array2[2] = 98;
				array2[2] = 145;
				array2[2] = 20;
				array2[2] = 106;
				array2[2] = 155;
				array2[3] = 168;
				array2[3] = 70;
				array2[3] = 139;
				array2[3] = 138;
				array2[3] = 70;
				array2[3] = 254;
				array2[4] = 142;
				array2[4] = 153;
				array2[4] = 100;
				array2[4] = 205;
				array2[4] = 112;
				array2[4] = 15;
				array2[5] = 149;
				array2[5] = 200;
				array2[5] = 65;
				array2[5] = 200;
				array2[6] = 156;
				array2[6] = 106;
				array2[6] = 150;
				array2[6] = 104;
				array2[7] = 33;
				array2[7] = 192;
				array2[7] = 202;
				array2[7] = 206;
				array2[7] = 114;
				array2[7] = 142;
				array2[8] = 140;
				array2[8] = 166;
				array2[8] = 175;
				array2[8] = 98;
				array2[8] = 158;
				array2[9] = 208;
				array2[9] = 127;
				array2[9] = 94;
				array2[9] = 131;
				array2[9] = 74;
				array2[9] = 114;
				array2[10] = 168;
				array2[10] = 162;
				array2[10] = 75;
				array2[10] = 89;
				array2[11] = 64;
				array2[11] = 126;
				array2[11] = 164;
				array2[11] = 113;
				array2[11] = 191;
				array2[12] = 125;
				array2[12] = 104;
				array2[12] = 149;
				array2[13] = 136;
				array2[13] = 88;
				array2[13] = 207;
				array2[14] = 70;
				array2[14] = 136;
				array2[14] = 17;
				array2[15] = 111;
				array2[15] = 93;
				array2[15] = 18;
				array2[15] = 99;
				array2[15] = 9;
				array2[16] = 62;
				array2[16] = 99;
				array2[16] = 37;
				array2[17] = 112;
				array2[17] = 164;
				array2[17] = 140;
				array2[18] = 141;
				array2[18] = 115;
				array2[18] = 57;
				array2[19] = 142;
				array2[19] = 98;
				array2[19] = 142;
				array2[19] = 147;
				array2[19] = 237;
				array2[20] = 18;
				array2[20] = 107;
				array2[20] = 166;
				array2[20] = 114;
				array2[20] = 108;
				array2[21] = 159;
				array2[21] = 56;
				array2[21] = 80;
				array2[22] = 122;
				array2[22] = 110;
				array2[22] = 144;
				array2[22] = 138;
				array2[22] = 196;
				array2[23] = 64;
				array2[23] = 78;
				array2[23] = 128;
				array2[23] = 212;
				array2[24] = 169;
				array2[24] = 126;
				array2[24] = 155;
				array2[24] = 84;
				array2[24] = 159;
				array2[25] = 154;
				array2[25] = 102;
				array2[25] = 41;
				array2[26] = 154;
				array2[26] = 151;
				array2[26] = 143;
				array2[26] = 108;
				array2[26] = 121;
				array2[26] = 167;
				array2[27] = 144;
				array2[27] = 178;
				array2[27] = 29;
				array2[28] = 92;
				array2[28] = 116;
				array2[28] = 24;
				array2[29] = 76;
				array2[29] = 186;
				array2[29] = 121;
				array2[29] = 226;
				array2[30] = 92;
				array2[30] = 179;
				array2[30] = 88;
				array2[30] = 113;
				array2[30] = 82;
				array2[30] = 220;
				array2[31] = 127;
				array2[31] = 159;
				array2[31] = 67;
				array2[31] = 144;
				array2[31] = 54;
				array2[31] = 239;
				byte[] array3 = array2;
				byte[] array4 = new byte[16];
				array4[0] = 92;
				array4[0] = 147;
				array4[0] = 70;
				array4[0] = 60;
				array4[1] = 138;
				array4[1] = 95;
				array4[1] = 102;
				array4[1] = 109;
				array4[1] = 130;
				array4[1] = 1;
				array4[2] = 98;
				array4[2] = 145;
				array4[2] = 220;
				array4[3] = 109;
				array4[3] = 101;
				array4[3] = 86;
				array4[3] = 239;
				array4[4] = 70;
				array4[4] = 163;
				array4[4] = 122;
				array4[4] = 110;
				array4[4] = 70;
				array4[4] = 172;
				array4[5] = 133;
				array4[5] = 135;
				array4[5] = 86;
				array4[5] = 29;
				array4[6] = 164;
				array4[6] = 112;
				array4[6] = 215;
				array4[7] = 149;
				array4[7] = 200;
				array4[7] = 114;
				array4[7] = 104;
				array4[7] = 49;
				array4[8] = 156;
				array4[8] = 58;
				array4[8] = 23;
				array4[9] = 103;
				array4[9] = 157;
				array4[9] = 204;
				array4[10] = 202;
				array4[10] = 206;
				array4[10] = 126;
				array4[10] = 178;
				array4[10] = 184;
				array4[11] = 159;
				array4[11] = 139;
				array4[11] = 236;
				array4[12] = 126;
				array4[12] = 107;
				array4[12] = 176;
				array4[12] = 124;
				array4[12] = 85;
				array4[12] = 200;
				array4[13] = 236;
				array4[13] = 75;
				array4[13] = 210;
				array4[14] = 98;
				array4[14] = 162;
				array4[14] = 166;
				array4[14] = 239;
				array4[15] = 95;
				array4[15] = 116;
				array4[15] = 123;
				array4[15] = 71;
				array4[15] = 136;
				array4[15] = 7;
				byte[] array5 = array4;
				byte[] publicKeyToken = typeof(DefinitionWrapper).Assembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length > 0)
				{
					array5[1] = publicKeyToken[0];
					array5[3] = publicKeyToken[1];
					array5[5] = publicKeyToken[2];
					array5[7] = publicKeyToken[3];
					array5[9] = publicKeyToken[4];
					array5[11] = publicKeyToken[5];
					array5[13] = publicKeyToken[6];
					array5[15] = publicKeyToken[7];
				}
				for (int i = 0; i < array5.Length; i++)
				{
					array3[i] ^= array5[i];
				}
				if (int_0 == -1)
				{
					SymmetricAlgorithm symmetricAlgorithm = DefinitionWrapper.InsertUtils();
					symmetricAlgorithm.Mode = CipherMode.CBC;
					ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
					MemoryStream memoryStream = new MemoryStream();
					CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.FlushFinalBlock();
					DefinitionWrapper.paramsWrapper = memoryStream.ToArray();
					memoryStream.Close();
					cryptoStream.Close();
					binaryReader.Close();
					array = DefinitionWrapper.paramsWrapper;
				}
				int num = array.Length % 4;
				int num2 = array.Length / 4;
				byte[] array6 = new byte[array.Length];
				int num3 = array3.Length / 4;
				uint num4 = 0U;
				if (num > 0)
				{
					num2++;
				}
				for (int j = 0; j < num2; j++)
				{
					int num5 = j % num3;
					int num6 = j * 4;
					uint num7 = (uint)(num5 * 4);
					uint num8 = (uint)((int)array3[(int)((UIntPtr)(num7 + 3U))] << 24 | (int)array3[(int)((UIntPtr)(num7 + 2U))] << 16 | (int)array3[(int)((UIntPtr)(num7 + 1U))] << 8 | (int)array3[(int)((UIntPtr)num7)]);
					uint num9 = 255U;
					int num10 = 0;
					uint num11;
					if (j == num2 - 1 && num > 0)
					{
						num11 = 0U;
						num4 += num8;
						for (int k = 0; k < num; k++)
						{
							if (k > 0)
							{
								num11 <<= 8;
							}
							num11 |= (uint)array[array.Length - (1 + k)];
						}
					}
					else
					{
						num4 += num8;
						num7 = (uint)num6;
						num11 = (uint)((int)array[(int)((UIntPtr)(num7 + 3U))] << 24 | (int)array[(int)((UIntPtr)(num7 + 2U))] << 16 | (int)array[(int)((UIntPtr)(num7 + 1U))] << 8 | (int)array[(int)((UIntPtr)num7)]);
					}
					uint num12 = num4;
					num4 += 1U;
					uint num13 = num12;
					uint num14 = num12;
					num14 ^= num14 >> 25;
					num14 += 1394801171U;
					num14 ^= num14 << 5;
					num14 += 927231359U;
					num14 ^= num14 >> 3;
					num14 += 2120992678U;
					num14 = 684982272U + num14;
					num12 = num13 + (uint)num14;
					num4 = num12;
					if (j == num2 - 1 && num > 0)
					{
						uint num15 = num4 ^ num11;
						for (int l = 0; l < num; l++)
						{
							if (l > 0)
							{
								num9 <<= 8;
								num10 += 8;
							}
							array6[num6 + l] = (byte)((num15 & num9) >> num10);
						}
					}
					else
					{
						uint num16 = num4 ^ num11;
						array6[num6] = (byte)(num16 & 255U);
						array6[num6 + 1] = (byte)((num16 & 65280U) >> 8);
						array6[num6 + 2] = (byte)((num16 & 16711680U) >> 16);
						array6[num6 + 3] = (byte)((num16 & 4278190080U) >> 24);
					}
				}
				DefinitionWrapper.paramsWrapper = array6;
			}
			int num17 = BitConverter.ToInt32(DefinitionWrapper.paramsWrapper, int_0);
			try
			{
				byte[] array7 = new byte[num17];
				Array.Copy(DefinitionWrapper.paramsWrapper, int_0 + 4, array7, 0, num17);
				return Encoding.Unicode.GetString(array7, 0, array7.Length);
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006D44 File Offset: 0x00004F44
		static string CancelUtils(int int_0)
		{
			if (DefinitionWrapper._ContainerWrapper.Length == 0)
			{
				BinaryReader binaryReader = new BinaryReader(typeof(DefinitionWrapper).Assembly.GetManifestResourceStream("6459b146-87a6-445f-b0ff-cfd37d1656e7"));
				binaryReader.BaseStream.Position = 0L;
				byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
				byte[] array2 = new byte[32];
				array2[0] = 92;
				array2[0] = 215;
				array2[0] = 213;
				array2[1] = 133;
				array2[1] = 110;
				array2[1] = 167;
				array2[1] = 46;
				array2[1] = 94;
				array2[2] = 145;
				array2[2] = 98;
				array2[2] = 145;
				array2[2] = 20;
				array2[2] = 106;
				array2[2] = 155;
				array2[3] = 168;
				array2[3] = 70;
				array2[3] = 139;
				array2[3] = 138;
				array2[3] = 70;
				array2[3] = 254;
				array2[4] = 142;
				array2[4] = 153;
				array2[4] = 100;
				array2[4] = 205;
				array2[4] = 112;
				array2[4] = 15;
				array2[5] = 149;
				array2[5] = 200;
				array2[5] = 65;
				array2[5] = 200;
				array2[6] = 156;
				array2[6] = 106;
				array2[6] = 150;
				array2[6] = 104;
				array2[7] = 33;
				array2[7] = 192;
				array2[7] = 202;
				array2[7] = 206;
				array2[7] = 114;
				array2[7] = 142;
				array2[8] = 140;
				array2[8] = 166;
				array2[8] = 175;
				array2[8] = 98;
				array2[8] = 158;
				array2[9] = 208;
				array2[9] = 127;
				array2[9] = 94;
				array2[9] = 131;
				array2[9] = 74;
				array2[9] = 114;
				array2[10] = 168;
				array2[10] = 162;
				array2[10] = 75;
				array2[10] = 89;
				array2[11] = 64;
				array2[11] = 126;
				array2[11] = 164;
				array2[11] = 113;
				array2[11] = 191;
				array2[12] = 125;
				array2[12] = 104;
				array2[12] = 149;
				array2[13] = 136;
				array2[13] = 88;
				array2[13] = 207;
				array2[14] = 70;
				array2[14] = 136;
				array2[14] = 17;
				array2[15] = 111;
				array2[15] = 93;
				array2[15] = 18;
				array2[15] = 99;
				array2[15] = 9;
				array2[16] = 62;
				array2[16] = 99;
				array2[16] = 37;
				array2[17] = 112;
				array2[17] = 164;
				array2[17] = 140;
				array2[18] = 141;
				array2[18] = 115;
				array2[18] = 57;
				array2[19] = 142;
				array2[19] = 98;
				array2[19] = 142;
				array2[19] = 147;
				array2[19] = 237;
				array2[20] = 18;
				array2[20] = 107;
				array2[20] = 166;
				array2[20] = 114;
				array2[20] = 108;
				array2[21] = 159;
				array2[21] = 56;
				array2[21] = 80;
				array2[22] = 122;
				array2[22] = 110;
				array2[22] = 144;
				array2[22] = 138;
				array2[22] = 196;
				array2[23] = 64;
				array2[23] = 78;
				array2[23] = 128;
				array2[23] = 212;
				array2[24] = 169;
				array2[24] = 126;
				array2[24] = 155;
				array2[24] = 84;
				array2[24] = 159;
				array2[25] = 154;
				array2[25] = 102;
				array2[25] = 41;
				array2[26] = 154;
				array2[26] = 151;
				array2[26] = 143;
				array2[26] = 108;
				array2[26] = 121;
				array2[26] = 167;
				array2[27] = 144;
				array2[27] = 178;
				array2[27] = 29;
				array2[28] = 92;
				array2[28] = 116;
				array2[28] = 24;
				array2[29] = 76;
				array2[29] = 186;
				array2[29] = 121;
				array2[29] = 226;
				array2[30] = 92;
				array2[30] = 179;
				array2[30] = 88;
				array2[30] = 113;
				array2[30] = 82;
				array2[30] = 220;
				array2[31] = 127;
				array2[31] = 159;
				array2[31] = 67;
				array2[31] = 144;
				array2[31] = 54;
				array2[31] = 239;
				byte[] array3 = array2;
				byte[] array4 = new byte[16];
				array4[0] = 92;
				array4[0] = 147;
				array4[0] = 70;
				array4[0] = 60;
				array4[1] = 138;
				array4[1] = 95;
				array4[1] = 102;
				array4[1] = 109;
				array4[1] = 130;
				array4[1] = 1;
				array4[2] = 98;
				array4[2] = 145;
				array4[2] = 220;
				array4[3] = 109;
				array4[3] = 101;
				array4[3] = 86;
				array4[3] = 239;
				array4[4] = 70;
				array4[4] = 163;
				array4[4] = 122;
				array4[4] = 110;
				array4[4] = 70;
				array4[4] = 172;
				array4[5] = 133;
				array4[5] = 135;
				array4[5] = 86;
				array4[5] = 29;
				array4[6] = 164;
				array4[6] = 112;
				array4[6] = 215;
				array4[7] = 149;
				array4[7] = 200;
				array4[7] = 114;
				array4[7] = 104;
				array4[7] = 49;
				array4[8] = 156;
				array4[8] = 58;
				array4[8] = 23;
				array4[9] = 103;
				array4[9] = 157;
				array4[9] = 204;
				array4[10] = 202;
				array4[10] = 206;
				array4[10] = 126;
				array4[10] = 178;
				array4[10] = 184;
				array4[11] = 159;
				array4[11] = 139;
				array4[11] = 236;
				array4[12] = 126;
				array4[12] = 107;
				array4[12] = 176;
				array4[12] = 124;
				array4[12] = 85;
				array4[12] = 200;
				array4[13] = 236;
				array4[13] = 75;
				array4[13] = 210;
				array4[14] = 98;
				array4[14] = 162;
				array4[14] = 166;
				array4[14] = 239;
				array4[15] = 95;
				array4[15] = 116;
				array4[15] = 123;
				array4[15] = 71;
				array4[15] = 136;
				array4[15] = 7;
				byte[] array5 = array4;
				byte[] publicKeyToken = typeof(DefinitionWrapper).Assembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length > 0)
				{
					array5[1] = publicKeyToken[0];
					array5[3] = publicKeyToken[1];
					array5[5] = publicKeyToken[2];
					array5[7] = publicKeyToken[3];
					array5[9] = publicKeyToken[4];
					array5[11] = publicKeyToken[5];
					array5[13] = publicKeyToken[6];
					array5[15] = publicKeyToken[7];
				}
				for (int i = 0; i < array5.Length; i++)
				{
					array3[i] ^= array5[i];
				}
				if (int_0 == -1)
				{
					SymmetricAlgorithm symmetricAlgorithm = DefinitionWrapper.InsertUtils();
					symmetricAlgorithm.Mode = CipherMode.CBC;
					ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
					MemoryStream memoryStream = new MemoryStream();
					CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.FlushFinalBlock();
					DefinitionWrapper._ContainerWrapper = memoryStream.ToArray();
					if (DefinitionWrapper._ContainerWrapper.Length > 0)
					{
						DefinitionWrapper._StructWrapper = new string[DefinitionWrapper._ContainerWrapper.Length / 4 + 1];
						DefinitionWrapper.m_InterceptorWrapper = new int[DefinitionWrapper._ContainerWrapper.Length / 4 + 1];
					}
					memoryStream.Close();
					cryptoStream.Close();
					binaryReader.Close();
					array = DefinitionWrapper._ContainerWrapper;
				}
				int num = array.Length % 4;
				int num2 = array.Length / 4;
				byte[] array6 = new byte[array.Length];
				int num3 = array3.Length / 4;
				uint num4 = 0U;
				if (num > 0)
				{
					num2++;
				}
				for (int j = 0; j < num2; j++)
				{
					int num5 = j % num3;
					int num6 = j * 4;
					uint num7 = (uint)(num5 * 4);
					uint num8 = (uint)((int)array3[(int)((UIntPtr)(num7 + 3U))] << 24 | (int)array3[(int)((UIntPtr)(num7 + 2U))] << 16 | (int)array3[(int)((UIntPtr)(num7 + 1U))] << 8 | (int)array3[(int)((UIntPtr)num7)]);
					uint num9 = 255U;
					int num10 = 0;
					uint num11;
					if (j == num2 - 1 && num > 0)
					{
						num11 = 0U;
						for (int k = 0; k < num; k++)
						{
							if (k > 0)
							{
								num11 <<= 8;
							}
							num11 |= (uint)array[array.Length - (1 + k)];
						}
						num4 += num8;
					}
					else
					{
						num7 = (uint)num6;
						num11 = (uint)((int)array[(int)((UIntPtr)(num7 + 3U))] << 24 | (int)array[(int)((UIntPtr)(num7 + 2U))] << 16 | (int)array[(int)((UIntPtr)(num7 + 1U))] << 8 | (int)array[(int)((UIntPtr)num7)]);
						num4 += num8;
					}
					uint num12 = num4;
					uint num13 = num4;
					num13 ^= num13 >> 25;
					num13 += 1394801171U;
					num13 ^= num13 << 5;
					num13 += 927231359U;
					num13 ^= num13 >> 3;
					num13 += 2120992678U;
					num13 = 684982272U + num13;
					num4 = num12 + (uint)num13;
					if (j == num2 - 1 && num > 0)
					{
						uint num14 = num4 ^ num11;
						for (int l = 0; l < num; l++)
						{
							if (l > 0)
							{
								num9 <<= 8;
								num10 += 8;
							}
							array6[num6 + l] = (byte)((num14 & num9) >> num10);
						}
					}
					else
					{
						uint num15 = num4 ^ num11;
						array6[num6] = (byte)(num15 & 255U);
						array6[num6 + 1] = (byte)((num15 & 65280U) >> 8);
						array6[num6 + 2] = (byte)((num15 & 16711680U) >> 16);
						array6[num6 + 3] = (byte)((num15 & 4278190080U) >> 24);
					}
				}
				DefinitionWrapper._ContainerWrapper = array6;
				if (DefinitionWrapper._ContainerWrapper.Length > 0)
				{
					DefinitionWrapper._StructWrapper = new string[DefinitionWrapper._ContainerWrapper.Length / 4 + 1];
					DefinitionWrapper.m_InterceptorWrapper = new int[DefinitionWrapper._ContainerWrapper.Length / 4 + 1];
				}
				Assembly assembly = typeof(DefinitionWrapper).Assembly;
				if (IntPtr.Size == 4)
				{
					DefinitionWrapper.attributeWrapper = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt32();
				}
				DefinitionWrapper._PrinterWrapper = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt64();
			}
			int num16 = int_0 / 4;
			if (DefinitionWrapper.m_InterceptorWrapper[num16] > 0)
			{
				return ((string[])DefinitionWrapper._StructWrapper)[DefinitionWrapper.m_InterceptorWrapper[num16]];
			}
			int num17 = BitConverter.ToInt32(DefinitionWrapper._ContainerWrapper, int_0);
			if (DefinitionWrapper.importerWrapper == IntPtr.Zero)
			{
				DefinitionWrapper.importerWrapper = DefinitionWrapper.OpenProcess(16U, 1, (uint)Process.GetCurrentProcess().Id);
			}
			byte[] array7 = new byte[4];
			if (IntPtr.Size == 4)
			{
				DefinitionWrapper.ReadProcessMemory(DefinitionWrapper.importerWrapper, new IntPtr(DefinitionWrapper.attributeWrapper + num17), array7, 4U, out DefinitionWrapper.objectWrapper);
			}
			else
			{
				DefinitionWrapper.ReadProcessMemory(DefinitionWrapper.importerWrapper, new IntPtr(DefinitionWrapper._PrinterWrapper + (long)num17), array7, 4U, out DefinitionWrapper.objectWrapper);
			}
			int num18 = BitConverter.ToInt32(array7, 0);
			array7 = new byte[num18];
			if (IntPtr.Size == 4)
			{
				DefinitionWrapper.ReadProcessMemory(DefinitionWrapper.importerWrapper, new IntPtr(DefinitionWrapper.attributeWrapper + num17 + 4), array7, Convert.ToUInt32(num18), out DefinitionWrapper.objectWrapper);
			}
			else
			{
				DefinitionWrapper.ReadProcessMemory(DefinitionWrapper.importerWrapper, new IntPtr(DefinitionWrapper._PrinterWrapper + (long)num17 + 4L), array7, Convert.ToUInt32(num18), out DefinitionWrapper.objectWrapper);
			}
			byte[] array8 = DefinitionWrapper.ValidateWrapper(array7);
			string @string = Encoding.Unicode.GetString(array8, 0, array8.Length);
			DefinitionWrapper.m_InterceptorWrapper[num16] = DefinitionWrapper._ErrorWrapper;
			((string[])DefinitionWrapper._StructWrapper)[DefinitionWrapper._ErrorWrapper] = @string;
			DefinitionWrapper._ErrorWrapper++;
			return @string;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00007BA0 File Offset: 0x00005DA0
		internal static string RunUtils(string string_0)
		{
			byte[] array = Convert.FromBase64String(string_0);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		// Token: 0x0600007B RID: 123
		[DllImport("kernel32.dll")]
		private static extern int VirtualProtect(IntPtr intptr_0, int int_0, int int_1, ref int int_2);

		// Token: 0x0600007C RID: 124 RVA: 0x00007BC4 File Offset: 0x00005DC4
		[DefinitionWrapper.SingletonWrapper(typeof(DefinitionWrapper.SingletonWrapper.QueueWrapper<object>[]))]
		static void UpdateUtils()
		{
			if (!DefinitionWrapper._PageWrapper)
			{
				DefinitionWrapper._PageWrapper = true;
				BinaryReader binaryReader = new BinaryReader(typeof(DefinitionWrapper).Assembly.GetManifestResourceStream("b969ce11-c390-40b1-9301-6945b7eeb14a"));
				binaryReader.BaseStream.Position = 0L;
				byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
				byte[] array2 = new byte[32];
				array2[0] = 165;
				array2[0] = 111;
				array2[0] = 113;
				array2[0] = 33;
				array2[0] = 165;
				array2[1] = 97;
				array2[1] = 160;
				array2[1] = 75;
				array2[1] = 97;
				array2[2] = 92;
				array2[2] = 138;
				array2[2] = 128;
				array2[2] = 92;
				array2[3] = 140;
				array2[3] = 98;
				array2[3] = 108;
				array2[3] = 140;
				array2[4] = 20;
				array2[4] = 158;
				array2[4] = 216;
				array2[4] = 163;
				array2[4] = 132;
				array2[4] = 141;
				array2[4] = 20;
				array2[5] = 93;
				array2[5] = 108;
				array2[5] = 92;
				array2[5] = 93;
				array2[6] = 64;
				array2[6] = 111;
				array2[6] = 110;
				array2[6] = 64;
				array2[7] = 16;
				array2[7] = 159;
				array2[7] = 136;
				array2[7] = 192;
				array2[7] = 137;
				array2[7] = 45;
				array2[7] = 16;
				array2[8] = 82;
				array2[8] = 100;
				array2[8] = 131;
				array2[8] = 82;
				array2[9] = 194;
				array2[9] = 70;
				array2[9] = 167;
				array2[9] = 194;
				array2[10] = 72;
				array2[10] = 91;
				array2[10] = 225;
				array2[10] = 106;
				array2[10] = 72;
				array2[11] = 56;
				array2[11] = 23;
				array2[11] = 186;
				array2[11] = 46;
				array2[11] = 56;
				array2[12] = 245;
				array2[12] = 90;
				array2[12] = 152;
				array2[12] = 86;
				array2[12] = 245;
				array2[13] = 110;
				array2[13] = 52;
				array2[13] = 102;
				array2[13] = 93;
				array2[13] = 90;
				array2[13] = 39;
				array2[13] = 110;
				array2[14] = 236;
				array2[14] = 144;
				array2[14] = 120;
				array2[14] = 236;
				array2[15] = 63;
				array2[15] = 88;
				array2[15] = 82;
				array2[15] = 63;
				array2[16] = 66;
				array2[16] = 145;
				array2[16] = 157;
				array2[16] = 66;
				array2[17] = 205;
				array2[17] = 167;
				array2[17] = 90;
				array2[17] = 83;
				array2[17] = 37;
				array2[17] = 205;
				array2[18] = 145;
				array2[18] = 100;
				array2[18] = 33;
				array2[18] = 137;
				array2[18] = 222;
				array2[18] = 145;
				array2[19] = 110;
				array2[19] = 160;
				array2[19] = 96;
				array2[19] = 148;
				array2[19] = 110;
				array2[20] = 73;
				array2[20] = 94;
				array2[20] = 142;
				array2[20] = 91;
				array2[20] = 109;
				array2[20] = 73;
				array2[21] = 159;
				array2[21] = 118;
				array2[21] = 170;
				array2[21] = 66;
				array2[21] = 152;
				array2[21] = 117;
				array2[21] = 159;
				array2[22] = 101;
				array2[22] = 134;
				array2[22] = 233;
				array2[22] = 190;
				array2[22] = 101;
				array2[23] = 48;
				array2[23] = 91;
				array2[23] = 96;
				array2[23] = 48;
				array2[24] = 33;
				array2[24] = 162;
				array2[24] = 161;
				array2[24] = 149;
				array2[24] = 87;
				array2[24] = 33;
				array2[25] = 15;
				array2[25] = 167;
				array2[25] = 100;
				array2[25] = 146;
				array2[25] = 15;
				array2[26] = 150;
				array2[26] = 52;
				array2[26] = 91;
				array2[26] = 124;
				array2[26] = 156;
				array2[26] = 96;
				array2[26] = 150;
				array2[27] = 87;
				array2[27] = 105;
				array2[27] = 104;
				array2[27] = 113;
				array2[27] = 143;
				array2[27] = 79;
				array2[27] = 87;
				array2[28] = 55;
				array2[28] = 210;
				array2[28] = 156;
				array2[28] = 55;
				array2[29] = 178;
				array2[29] = 159;
				array2[29] = 81;
				array2[29] = 195;
				array2[29] = 108;
				array2[29] = 178;
				array2[30] = 42;
				array2[30] = 130;
				array2[30] = 146;
				array2[30] = 87;
				array2[30] = 117;
				array2[30] = 168;
				array2[30] = 42;
				array2[31] = 131;
				array2[31] = 117;
				array2[31] = 94;
				array2[31] = 206;
				array2[31] = 131;
				byte[] array3 = array2;
				byte[] array4 = new byte[16];
				array4[0] = 146;
				array4[0] = 146;
				array4[0] = 111;
				array4[1] = 121;
				array4[1] = 27;
				array4[1] = 102;
				array4[1] = 109;
				array4[1] = 187;
				array4[2] = 155;
				array4[2] = 129;
				array4[2] = 157;
				array4[3] = 108;
				array4[3] = 187;
				array4[3] = 156;
				array4[3] = 132;
				array4[3] = 148;
				array4[3] = 218;
				array4[4] = 42;
				array4[4] = 78;
				array4[4] = 25;
				array4[4] = 159;
				array4[4] = 160;
				array4[4] = 102;
				array4[5] = 99;
				array4[5] = 148;
				array4[5] = 80;
				array4[6] = 98;
				array4[6] = 111;
				array4[6] = 76;
				array4[7] = 100;
				array4[7] = 161;
				array4[7] = 108;
				array4[7] = 170;
				array4[8] = 167;
				array4[8] = 104;
				array4[8] = 154;
				array4[8] = 122;
				array4[8] = 101;
				array4[8] = 122;
				array4[9] = 138;
				array4[9] = 98;
				array4[9] = 119;
				array4[9] = 167;
				array4[9] = 6;
				array4[10] = 123;
				array4[10] = 95;
				array4[10] = 159;
				array4[11] = 109;
				array4[11] = 140;
				array4[11] = 136;
				array4[11] = 160;
				array4[11] = 102;
				array4[11] = 110;
				array4[12] = 94;
				array4[12] = 69;
				array4[12] = 33;
				array4[12] = 99;
				array4[12] = 222;
				array4[13] = 145;
				array4[13] = 157;
				array4[13] = 97;
				array4[13] = 144;
				array4[13] = 62;
				array4[13] = 2;
				array4[14] = 84;
				array4[14] = 168;
				array4[14] = 27;
				array4[15] = 114;
				array4[15] = 102;
				array4[15] = 56;
				byte[] array5 = array4;
				Array.Reverse(array5);
				byte[] publicKeyToken = typeof(DefinitionWrapper).Assembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length > 0)
				{
					array5[1] = publicKeyToken[0];
					array5[3] = publicKeyToken[1];
					array5[5] = publicKeyToken[2];
					array5[7] = publicKeyToken[3];
					array5[9] = publicKeyToken[4];
					array5[11] = publicKeyToken[5];
					array5[13] = publicKeyToken[6];
					array5[15] = publicKeyToken[7];
					Array.Clear(publicKeyToken, 0, publicKeyToken.Length);
				}
				for (int i = 0; i < array5.Length; i++)
				{
					array3[i] ^= array5[i];
				}
				byte[] array6 = array;
				int num = array6.Length % 4;
				int num2 = array6.Length / 4;
				byte[] array7 = new byte[array6.Length];
				int num3 = array3.Length / 4;
				uint num4 = 0U;
				if (num > 0)
				{
					num2++;
				}
				for (int j = 0; j < num2; j++)
				{
					int num5 = j % num3;
					int num6 = j * 4;
					uint num7 = (uint)(num5 * 4);
					uint num8 = (uint)((int)array3[(int)((UIntPtr)(num7 + 3U))] << 24 | (int)array3[(int)((UIntPtr)(num7 + 2U))] << 16 | (int)array3[(int)((UIntPtr)(num7 + 1U))] << 8 | (int)array3[(int)((UIntPtr)num7)]);
					uint num9 = 255U;
					int num10 = 0;
					uint num11;
					if (j == num2 - 1 && num > 0)
					{
						num4 += num8;
						num11 = 0U;
						for (int k = 0; k < num; k++)
						{
							if (k > 0)
							{
								num11 <<= 8;
							}
							num11 |= (uint)array6[array6.Length - (1 + k)];
						}
					}
					else
					{
						num7 = (uint)num6;
						num4 += num8;
						num11 = (uint)((int)array6[(int)((UIntPtr)(num7 + 3U))] << 24 | (int)array6[(int)((UIntPtr)(num7 + 2U))] << 16 | (int)array6[(int)((UIntPtr)(num7 + 1U))] << 8 | (int)array6[(int)((UIntPtr)num7)]);
					}
					num4 = num4;
					uint num12 = num4;
					uint num13 = num4;
					num13 ^= num13 >> 25;
					num13 += 1394801171U;
					num13 ^= num13 << 5;
					num13 += 927231359U;
					num13 ^= num13 >> 3;
					num13 += 2120992678U;
					num13 = 684982272U + num13;
					num4 = num12 + (uint)num13;
					if (j == num2 - 1 && num > 0)
					{
						uint num14 = num4 ^ num11;
						for (int l = 0; l < num; l++)
						{
							if (l > 0)
							{
								num9 <<= 8;
								num10 += 8;
							}
							array7[num6 + l] = (byte)((num14 & num9) >> num10);
						}
					}
					else
					{
						uint num15 = num4 ^ num11;
						array7[num6] = (byte)(num15 & 255U);
						array7[num6 + 1] = (byte)((num15 & 65280U) >> 8);
						array7[num6 + 2] = (byte)((num15 & 16711680U) >> 16);
						array7[num6 + 3] = (byte)((num15 & 4278190080U) >> 24);
					}
				}
				byte[] buffer = array7;
				Array.Clear(array5, 0, array5.Length);
				binaryReader.Close();
				binaryReader = new BinaryReader(new MemoryStream(buffer));
				binaryReader.BaseStream.Position = 0L;
				IntPtr intptr_ = IntPtr.Zero;
				Assembly assembly = typeof(DefinitionWrapper).Assembly;
				intptr_ = DefinitionWrapper.OpenProcess(56U, 1, (uint)Process.GetCurrentProcess().Id);
				DefinitionWrapper._PrinterWrapper = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt64();
				IntPtr zero = IntPtr.Zero;
				int int_ = 0;
				int num16 = binaryReader.ReadInt32();
				binaryReader.ReadInt32();
				for (int m = 0; m < num16; m++)
				{
					IntPtr intPtr = new IntPtr(DefinitionWrapper._PrinterWrapper + (long)binaryReader.ReadInt32());
					DefinitionWrapper.VirtualProtect(intPtr, 4, 4, ref int_);
					if (IntPtr.Size == 4)
					{
						DefinitionWrapper.WriteProcessMemory(intptr_, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4U, out zero);
					}
					else
					{
						DefinitionWrapper.WriteProcessMemory(intptr_, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4U, out zero);
					}
					DefinitionWrapper.VirtualProtect(intPtr, 4, int_, ref int_);
				}
				try
				{
					while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length - 1L)
					{
						int num17 = binaryReader.ReadInt32();
						IntPtr intptr_2 = new IntPtr(DefinitionWrapper._PrinterWrapper + (long)num17);
						int num18 = binaryReader.ReadInt32();
						DefinitionWrapper.VirtualProtect(intptr_2, num18 * 4, 4, ref int_);
						for (int n = 0; n < num18; n++)
						{
							Marshal.WriteInt32(new IntPtr(intptr_2.ToInt64() + (long)(n * 4)), binaryReader.ReadInt32());
						}
						DefinitionWrapper.VirtualProtect(intptr_2, num18 * 4, int_, ref int_);
					}
					DefinitionWrapper.CloseHandle(intptr_);
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00008B3C File Offset: 0x00006D3C
		internal static object VerifyUtils(Assembly assembly_0)
		{
			try
			{
				if (File.Exists(((Assembly)assembly_0).Location))
				{
					return ((Assembly)assembly_0).Location;
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(((Assembly)assembly_0).GetName().CodeBase.ToString().Replace("file:///", "")))
				{
					return ((Assembly)assembly_0).GetName().CodeBase.ToString().Replace("file:///", "");
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0]).ToString()))
				{
					return assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0]).ToString();
				}
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x0600007E RID: 126
		[DllImport("kernel32.dll")]
		private static extern int WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, [In] [Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2);

		// Token: 0x0600007F RID: 127
		[DllImport("kernel32.dll")]
		private static extern int ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, [In] [Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2);

		// Token: 0x06000080 RID: 128
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenProcess(uint uint_0, int int_0, uint uint_1);

		// Token: 0x06000081 RID: 129
		[DllImport("kernel32.dll")]
		private static extern int CloseHandle(IntPtr intptr_0);

		// Token: 0x06000082 RID: 130 RVA: 0x00008C4C File Offset: 0x00006E4C
		private static byte[] ConcatWrapper(string string_0)
		{
			byte[] array;
			using (FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				int num = 0;
				long length = fileStream.Length;
				int i = (int)length;
				array = new byte[i];
				while (i > 0)
				{
					int num2 = fileStream.Read(array, num, i);
					num += num2;
					i -= num2;
				}
			}
			return array;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00008CB4 File Offset: 0x00006EB4
		private static byte[] ValidateWrapper(byte[] byte_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = DefinitionWrapper.InsertUtils();
			symmetricAlgorithm.Key = new byte[]
			{
				61,
				126,
				3,
				67,
				252,
				140,
				233,
				218,
				44,
				119,
				104,
				141,
				72,
				209,
				92,
				163,
				71,
				153,
				190,
				241,
				155,
				192,
				252,
				116,
				252,
				27,
				146,
				229,
				29,
				121,
				95,
				50
			};
			symmetricAlgorithm.IV = new byte[]
			{
				112,
				97,
				60,
				217,
				175,
				224,
				199,
				215,
				173,
				194,
				31,
				171,
				183,
				151,
				1,
				193
			};
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
			return memoryStream.ToArray();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000269F File Offset: 0x0000089F
		private byte[] FlushWrapper()
		{
			return null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000269F File Offset: 0x0000089F
		private byte[] FillWrapper()
		{
			return null;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000269F File Offset: 0x0000089F
		private byte[] DestroyWrapper()
		{
			return null;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000269F File Offset: 0x0000089F
		private byte[] ReadWrapper()
		{
			return null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000269F File Offset: 0x0000089F
		private byte[] ViewWrapper()
		{
			return null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000269F File Offset: 0x0000089F
		private byte[] PopWrapper()
		{
			return null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00008D24 File Offset: 0x00006F24
		internal byte[] NewWrapper()
		{
			string text = "{11111-22222-40001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00008D64 File Offset: 0x00006F64
		internal byte[] InterruptWrapper()
		{
			string text = "{11111-22222-40001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00008DA4 File Offset: 0x00006FA4
		internal byte[] RemoveWrapper()
		{
			string text = "{11111-22222-50001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00008DE4 File Offset: 0x00006FE4
		internal byte[] VisitWrapper()
		{
			string text = "{11111-22222-50001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00008E24 File Offset: 0x00007024
		internal byte[] ForgotWrapper()
		{
			string text = "{11111-22222-60001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00008E64 File Offset: 0x00007064
		internal byte[] PublishWrapper()
		{
			string text = "{11111-22222-60001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00008EA4 File Offset: 0x000070A4
		internal static string TestWrapper(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			byte[] iv = DefinitionWrapper.IncludeUtils(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = DefinitionWrapper.InsertUtils();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		// Token: 0x04000029 RID: 41
		private static byte[] paramsWrapper;

		// Token: 0x0400002A RID: 42
		private static IntPtr objectWrapper;

		// Token: 0x0400002B RID: 43
		private static int _ErrorWrapper;

		// Token: 0x0400002C RID: 44
		private static long _PrinterWrapper;

		// Token: 0x0400002D RID: 45
		private static int attributeWrapper;

		// Token: 0x0400002E RID: 46
		private static bool _CandidateWrapper;

		// Token: 0x0400002F RID: 47
		private static bool _PageWrapper;

		// Token: 0x04000030 RID: 48
		private static uint[] m_MockWrapper = new uint[]
		{
			3614090360U,
			3905402710U,
			606105819U,
			3250441966U,
			4118548399U,
			1200080426U,
			2821735955U,
			4249261313U,
			1770035416U,
			2336552879U,
			4294925233U,
			2304563134U,
			1804603682U,
			4254626195U,
			2792965006U,
			1236535329U,
			4129170786U,
			3225465664U,
			643717713U,
			3921069994U,
			3593408605U,
			38016083U,
			3634488961U,
			3889429448U,
			568446438U,
			3275163606U,
			4107603335U,
			1163531501U,
			2850285829U,
			4243563512U,
			1735328473U,
			2368359562U,
			4294588738U,
			2272392833U,
			1839030562U,
			4259657740U,
			2763975236U,
			1272893353U,
			4139469664U,
			3200236656U,
			681279174U,
			3936430074U,
			3572445317U,
			76029189U,
			3654602809U,
			3873151461U,
			530742520U,
			3299628645U,
			4096336452U,
			1126891415U,
			2878612391U,
			4237533241U,
			1700485571U,
			2399980690U,
			4293915773U,
			2240044497U,
			1873313359U,
			4264355552U,
			2734768916U,
			1309151649U,
			4149444226U,
			3174756917U,
			718787259U,
			3951481745U
		};

		// Token: 0x04000031 RID: 49
		private static byte[] mapWrapper;

		// Token: 0x04000032 RID: 50
		private static int[] m_InterceptorWrapper;

		// Token: 0x04000033 RID: 51
		private static byte[] _ExceptionWrapper;

		// Token: 0x04000034 RID: 52
		private static IntPtr importerWrapper;

		// Token: 0x04000035 RID: 53
		private static bool readerWrapper;

		// Token: 0x04000036 RID: 54
		private static string[] _StructWrapper;

		// Token: 0x04000037 RID: 55
		private static byte[] _ContainerWrapper;

		// Token: 0x02000011 RID: 17
		internal class SingletonWrapper : Attribute
		{
			// Token: 0x06000092 RID: 146 RVA: 0x000026A2 File Offset: 0x000008A2
			[DefinitionWrapper.SingletonWrapper(typeof(DefinitionWrapper.SingletonWrapper.QueueWrapper<object>[]))]
			public SingletonWrapper(object object_0)
			{
			}

			// Token: 0x02000012 RID: 18
			internal class QueueWrapper<T>
			{
			}
		}

		// Token: 0x02000013 RID: 19
		[Flags]
		private enum ChildJobFlags
		{

		}
	}
}
