public class Solution
{
	public int Calculate(string s)
	{

		for (int i = s.Length - 2; i > 0; i--)
		{
			if (s[i] == '-')
			{
				return Calculate(s.Substring(0, i)) - Calculate(s.Substring(i + 1));
			}
			if (s[i] == '+')
			{
				return Calculate(s.Substring(i + 1)) + Calculate(s.Substring(0, i));
			}
		}

		for (int i = s.Length - 2; i > 0; i--)
		{
			if (s[i] == '/')
			{
				return Calculate(s.Substring(0, i)) / Calculate(s.Substring(i + 1));
			}
			if (s[i] == '*')
			{
				return Calculate(s.Substring(i + 1)) * Calculate(s.Substring(0, i));
			}
		}

		return Int32.Parse(s.Trim());
	}
}