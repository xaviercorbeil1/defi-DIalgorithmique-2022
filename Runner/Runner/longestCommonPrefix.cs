public class Solution
{
	public string LongestCommonPrefix(string[] strs)
	{
		string shortestWord = strs[0];

		foreach (string str in strs)
			if (str.Length < shortestWord.Length) shortestWord = str;

		var words = strs.Where(str => str != shortestWord);

		for (int i = 0; i < shortestWord.Length; i++)
		{
			foreach (string word in words)
			{
				if (word[i] != shortestWord[i])
					if (i == 0)
						return "";
					else
						return shortestWord.Substring(0, i);
			}
		}
		return shortestWord;
	}
}