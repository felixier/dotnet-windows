using System;
using System.Collections.Generic;
using System.Text;

namespace Caesar
{
	class Ceasar
	{
		public const int LENGTH = 4;
		static int[] _original = new int[LENGTH];
		static int[] _ciphered = new int[LENGTH];
		static int[] _key = new int[LENGTH];

		static int[] string2array(string value)
		{
			int[] arr = new int[LENGTH];
			for(int i = 0; i < LENGTH; i++)
			{
				arr[i] = Convert.ToInt32(value[i].ToString());
			}
			return arr;
		}

		static string array2string(int[] arr)
		{
			StringBuilder value = new StringBuilder(LENGTH);
			for(int i = 0; i < LENGTH; i++)
			{
				value.Append(arr[i]);
			}
			return value.ToString();
		}

		public static string Encipher(string original, string key, bool reverse)
		{
			_original = string2array(original);
			_key = string2array(key);
			for(int i = 0; i < LENGTH; i++)
			{
				_ciphered[i] = (_original[i] + _key[i]) % 10;
			}
			if(reverse)
			{
				Array.Reverse(_ciphered);
			}
			return array2string(_ciphered);
		}

		public static string Decipher(string ciphered, string key,bool reverse)
		{
			_ciphered = string2array(ciphered);
			if(reverse)
			{
				Array.Reverse(_ciphered);
			}
			_key = string2array(key);
			for(int i = 0; i < LENGTH; i++)
			{
				_original[i] = (_ciphered[i] + 10 - _key[i]) % 10;
			}
			return array2string(_original);
		}
	}
}
