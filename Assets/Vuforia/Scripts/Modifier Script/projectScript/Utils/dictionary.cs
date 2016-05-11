//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.IO;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
	public class dictionary
	{
		private static dictionary s_instance;
		private string[] words; 

		public static dictionary instance {
			get { return s_instance == null ? load () : s_instance; }
		}


		private dictionary (string[] words)
		{
			this.words = words;
		}

		private static bool isWordOK(string word){
			if (word.Length < 1)
				return false;

			foreach (char c in word){
				if(!TextUtils.isAlpha(c))
					return false;
			}

			return true;
		}

		public static dictionary load(){
			if (s_instance != null)
				return s_instance;

			HashSet<string> wordList = new HashSet<string> ();

			TextAsset asset = Resources.Load ("word") as TextAsset;
			TextReader src = new StringReader(asset.text);

			while (src.Peek () != -1) {
					string word = src.ReadLine();
				if(isWordOK(word))
					wordList.Add(word);
			}

			Resources.UnloadAsset (asset);


			string[] words = new string[wordList.Count];
			wordList.CopyTo (words);

			s_instance = new dictionary (words);
			return s_instance;

		}

		public string next(int limit){
			int index = (int) (Random.value * (words.Length - 1));

			return words[index];
		}
	}
}

