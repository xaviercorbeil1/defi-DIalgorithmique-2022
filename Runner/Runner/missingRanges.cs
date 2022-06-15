using System.Linq;

public class Solution
{
	public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
	{
		List<string> result = new List<string>();


		if (lower != nums[0])
		{
			result.Add($"{lower} -> {nums[0]}");
		}

		for (int i = 1; i < nums.Length; i++)
		{
			int n = nums[i - 1];
			int n2 = nums[i];

			if (n + 1 != n2)
			{
				if ((n2 - n) == 2)
				{
					result.Add($"{n2 - 1}");
				}
				else
				{
					result.Add($"{n + 1 } -> {n2 - 1}");
				}

			}
		}

		if (upper != nums.Last())
		{
			result.Add($"{nums.Last() + 1} -> {upper}");
		}

		return result;
	}
}