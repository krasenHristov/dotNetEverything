/*
Given an integer array nums and an integer k, return the number of pairs (i, j) where i < j such that |nums[i] - nums[j]| == k.

    The value of |x| is defined as:

x if x >= 0.
-x if x < 0.


    Example 1:

Input: nums = [1,2,2,1], k = 1
Output: 4
Explanation: The pairs with an absolute difference of 1 are:
- [1,2,2,1]
    - [1,2,2,1]
    - [1,2,2,1]
    - [1,2,2,1]
Example 2:

Input: nums = [1,3], k = 3
Output: 0
Explanation: There are no pairs with an absolute difference of 3.
    Example 3:

Input: nums = [3,2,1,5,4], k = 2
Output: 3
Explanation: The pairs with an absolute difference of 2 are:
- [3,2,1,5,4]
    - [3,2,1,5,4]
    - [3,2,1,5,4]
*/

public class PairsWithAbsDifferenceSolution{
    public int CountKDifference(int[] nums, int k) {

        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int left = nums[i];
            for (int j = i+1; j < nums.Length; j++)
            {
                int right = nums[j];

                if (Math.Abs(left - right) == k)
                {
                    count++;
                }
            }
        }

        return count;
    }

    public int CountKDifference2(int[] nums, int k)
    {
        var numFrequency = new Dictionary<int, int>();
        int count = 0;

        foreach (int num in nums) {
            if (numFrequency.ContainsKey(num - k)) {
                count += numFrequency[num - k];
            }

            if (numFrequency.ContainsKey(num + k)) {
                count += numFrequency[num + k];
            }

            if (numFrequency.ContainsKey(num)) {
                numFrequency[num]++;
            } else {
                numFrequency[num] = 1;
            }
        }

        return count;
    }
}
