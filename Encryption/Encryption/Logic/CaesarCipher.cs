using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.Logic
{
	public static class CaesarCipher
	{
		public static string Encrypt(string text, int key)
		{
			StringBuilder result = new StringBuilder();

			foreach (char ch in text)
			{
				if (char.IsLetter(ch))
				{
					char baseChar = char.IsUpper(ch) ? 'A' : 'a';
					char encryptedChar = (char)((((ch - baseChar) + key) % 26) + baseChar);
					result.Append(encryptedChar);
				}
				else
				{
					result.Append(ch);
				}
			}

			return result.ToString();
		}

		public static string Decrypt(string text, int key)
		{
			StringBuilder result = new StringBuilder();

			foreach (char ch in text)
			{
				if (char.IsLetter(ch))
				{
					char baseChar = char.IsUpper(ch) ? 'A' : 'a';
					char decryptedChar = (char)((((ch - baseChar - key + 26) % 26) + baseChar));
					result.Append(decryptedChar);
				}
				else
				{
					result.Append(ch);
				}
			}

			return result.ToString();
		}
	}
}
