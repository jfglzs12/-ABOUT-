using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1.Internal
{
	// Token: 0x0200000D RID: 13
	[StandardModule]
	internal sealed class MappingWrapper
	{
		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CryptAcquireContext(ref IntPtr intptr_0, string string_0, string string_1, int int_0, int int_1);

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CryptCreateHash(IntPtr intptr_0, int int_0, IntPtr intptr_1, int int_1, ref IntPtr intptr_2);

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CryptHashData(IntPtr intptr_0, byte[] byte_0, int int_0, int int_1);

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CryptGetHashParam(IntPtr intptr_0, int int_0, byte[] byte_0, ref int int_1, int int_2);

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool CryptDestroyHash(IntPtr intptr_0);

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool CryptReleaseContext(IntPtr intptr_0, int int_0);

		public static string CheckUtils(string string_0)
		{
			string result;
			using (SHA256 sha = SHA256.Create())
			{
				byte[] array = sha.ComputeHash(Encoding.UTF8.GetBytes(string_0 + "bfdshgs"));
				StringBuilder stringBuilder = new StringBuilder();
				foreach (byte b in array)
				{
					stringBuilder.Append(b.ToString("x2"));
				}
				result = stringBuilder.ToString();
			}
			return result;
		}

		// 重新实现：对称加密（DES）并返回 Base64（简化并去除反编译痕迹）
		public static string CustomizeUtils(string input)
		{
			if (input == null) return null;
			try
			{
				string marker = "zm2025jfglzs";
				string key = marker.Substring(0, 8);
				string iv = marker.Substring(1, 8);
				using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
				{
					des.Key = Encoding.UTF8.GetBytes(key);
					des.IV = Encoding.UTF8.GetBytes(iv);
					using (MemoryStream ms = new MemoryStream())
					using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
					using (StreamWriter sw = new StreamWriter(cs))
					{
						sw.Write(input);
						sw.Flush();
						cs.FlushFinalBlock();
						return Convert.ToBase64String(ms.ToArray());
					}
				}
			}
			catch
			{
				return null;
			}
		}

		// 重新实现：从 Base64 解密（对应 CustomizeUtils）
		public static string InvokeUtils(string input)
		{
			if (input == null) return null;
			try
			{
				string marker = "zm2025jfglzs";
				string key = marker.Substring(0, 8);
				string iv = marker.Substring(1, 8);
				using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
				{
					des.Key = Encoding.UTF8.GetBytes(key);
					des.IV = Encoding.UTF8.GetBytes(iv);
					byte[] buffer = Convert.FromBase64String(input);
					using (MemoryStream ms = new MemoryStream(buffer))
					using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Read))
					using (StreamReader sr = new StreamReader(cs))
					{
						return sr.ReadToEnd();
					}
				}
			}
			catch
			{
				return null;
			}
		}

		// 重新实现：字符每位 -10（对应原 CallUtils）
		public static string CallUtils(string input)
		{
			if (input == null) return null;
			try
			{
				var sb = new StringBuilder(input.Length);
				foreach (char c in input)
				{
					sb.Append((char)(c - 10));
				}
				return sb.ToString();
			}
			catch
			{
				return null;
			}
		}

		// 重新实现：字符每位 +10（对应原 RateUtils）
		public static string RateUtils(string input)
		{
			if (input == null) return null;
			try
			{
				var sb = new StringBuilder(input.Length);
				foreach (char c in input)
				{
					sb.Append((char)(c + 10));
				}
				return sb.ToString();
			}
			catch
			{
				return null;
			}
		}

		public static string CollectUtils()
		{
			string hostNameOrAddress = Dns.GetHostName().ToString();
			string result = "";
			foreach (IPAddress ipaddress in Dns.GetHostEntry(hostNameOrAddress).AddressList)
			{
				if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
				{
					result = ipaddress.ToString();
					return result;
				}
			}
			return result;
		}

		public static string _CustomerWrapper;
		public static string infoWrapper;
		private const int _TokenizerWrapper = 1;
		private const int m_RefWrapper = -268435456;
		private const int m_PrototypeWrapper = 32771;
		private const int m_SpecificationWrapper = 2;
	}
}
