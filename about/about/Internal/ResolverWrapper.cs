using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace WindowsApplication1.Internal
{
	// Token: 0x02000015 RID: 21
	internal class ResolverWrapper
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00008F80 File Offset: 0x00007180
		internal static void smethod_0()
		{
			if (!ResolverWrapper.watcherWrapper)
			{
				ResolverWrapper.watcherWrapper = true;
				AppDomain currentDomain = AppDomain.CurrentDomain;
				currentDomain.AssemblyResolve += ResolverWrapper.CalculateWrapper;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00008FB4 File Offset: 0x000071B4
		private static Assembly CalculateWrapper(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			Assembly result;
			lock (ResolverWrapper.m_ConfigWrapper)
			{
				string text = resolveEventArgs_0.Name.Trim();
				object obj = ResolverWrapper.m_ConfigWrapper[text];
				if (obj == null)
				{
					try
					{
						RSACryptoServiceProvider.UseMachineKeyStore = true;
						string text2 = ResolverWrapper.PushWrapper(text);
						byte[] bytes = Encoding.Unicode.GetBytes(text2);
						string text3 = "b0494a1f-4bd3-" + Convert.ToBase64String(DefinitionWrapper.IncludeUtils(bytes));
						Stream manifestResourceStream = typeof(ResolverWrapper).Assembly.GetManifestResourceStream(text3);
						if (manifestResourceStream != null)
						{
							try
							{
								BinaryReader binaryReader = new BinaryReader(manifestResourceStream);
								binaryReader.BaseStream.Position = 0L;
								byte[] array = new byte[manifestResourceStream.Length];
								binaryReader.Read(array, 0, array.Length);
								binaryReader.Close();
								bool flag2 = false;
								Assembly assembly = null;
								try
								{
									assembly = Assembly.Load(array);
								}
								catch (FileLoadException)
								{
									flag2 = true;
								}
								catch (BadImageFormatException)
								{
									flag2 = true;
								}
								if (flag2)
								{
									string path = Path.Combine(Path.GetTempPath(), text3);
									string path2 = Path.Combine(path, text2 + ".dll");
									if (!File.Exists(path2))
									{
										Directory.CreateDirectory(Path.GetDirectoryName(path2));
										FileStream fileStream = new FileStream(path2, FileMode.Create, FileAccess.Write);
										fileStream.Write(array, 0, array.Length);
										fileStream.Close();
									}
									assembly = Assembly.LoadFile(path2);
									ResolverWrapper.m_ConfigWrapper.Add(text, assembly);
								}
								else
								{
									ResolverWrapper.m_ConfigWrapper.Add(text, assembly);
								}
								return assembly;
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
					result = null;
				}
				else
				{
					result = (Assembly)obj;
				}
			}
			return result;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000091CC File Offset: 0x000073CC
		private static string PushWrapper(string string_0)
		{
			string text = string_0.Trim();
			int num = text.IndexOf(',');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			return text;
		}

		// Token: 0x0400003A RID: 58
		private static Hashtable m_ConfigWrapper = new Hashtable();

		// Token: 0x0400003B RID: 59
		private static bool watcherWrapper = false;
	}
}
