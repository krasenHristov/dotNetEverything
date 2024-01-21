/*
A fancy string is a string where no three consecutive characters are equal.

    Given a string s, delete the minimum possible number of characters from s to make it fancy.

    Return the final string after the deletion. It can be shown that the answer will always be unique.



    Example 1:

Input: s = "leeetcode"
Output: "leetcode"
Explanation:
Remove an 'e' from the first group of 'e's to create "leetcode".
    No three consecutive characters are equal, so return "leetcode".
    Example 2:

Input: s = "aaabaaaa"
Output: "aabaa"
Explanation:
Remove an 'a' from the first group of 'a's to create "aabaaaa".
    Remove two 'a's from the second group of 'a's to create "aabaa".
    No three consecutive characters are equal, so return "aabaa".
    Example 3:

Input: s = "aab"
Output: "aab"
Explanation: No three consecutive characters are equal, so return "aab".
*/

using System.Text;

public class MakeFancyStringSolution{
    public string MakeFancyString(string s) {

        char prev = ' ';
        StringBuilder result = new StringBuilder();
        int sameCount = 1;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == prev)
            {
                sameCount++;
                if (sameCount < 3)
                {
                    result.Append(s[i]);
                }
            }
            else
            {
                result.Append(s[i]);
                sameCount = 1;
            }

            prev = s[i];
        }

        return result.ToString();
    }
}
