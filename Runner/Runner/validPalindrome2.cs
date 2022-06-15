public class Solution
{
	public bool ValidPalindrome(string s)
	{

		if (s.Length == 1) return true; //ex : a

		if (s.Length == 2) return s[0] == s[1]; //ex: aa

		var reversedResponse = new String(s.Reverse().ToArray());

		for (int i = 0; i < s.Length; i++)
		{
			string maybePalindrom = s.Remove(i, 1);
			string maybeReversedResponse = reversedResponse.Remove(s.Length - 1 - i, 1);

			if (maybeReversedResponse.Equals(maybePalindrom)) return true;
		}

		return false;
	}
}