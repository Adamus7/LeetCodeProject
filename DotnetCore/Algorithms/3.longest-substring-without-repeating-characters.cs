/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 *
 * https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
 *
 * algorithms
 * Medium (25.76%)
 * Total Accepted:    694.6K
 * Total Submissions: 2.7M
 * Testcase Example:  '"abcabcbb"'
 *
 * Given a string, find the length of the longest substring without repeating
 * characters.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: "abcabcbb"
 * Output: 3 
 * Explanation: The answer is "abc", with the length of 3. 
 * 
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: "bbbbb"
 * Output: 1
 * Explanation: The answer is "b", with the length of 1.
 * 
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: "pwwkew"
 * Output: 3
 * Explanation: The answer is "wke", with the length of 3. 
 * ⁠            Note that the answer must be a substring, "pwke" is a
 * subsequence and not a substring.
 * 
 * 
 * 
 * 
 * 
 */

namespace Algorithms
{
    public class Solution003
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s == null || s.Length == 0)
                return 0;

            if (s.Length == 1)
                return 1;

            int maxLengthSoFar = 0;
            int currentSubstringLength = 0;
            int currentSubstringStart = 0;

            // Dictionary to detect duplicates and locate last occurance of chars
            Dictionary<char, int> charMap = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; ++i)
            {
                if (charMap.ContainsKey(s[i]))
                {
                    // get the location of the last instance of the current character
                    // if that location is after the start of the current substring, update the starting point
                    // (consider: "abba". The second 'a' should not update the starting point)
                    currentSubstringStart = Math.Max(currentSubstringStart, charMap[s[i]]);

                    // update the current char in the dictionary with its current location 
                    // (we don't care about previous locations)
                    charMap[s[i]] = i;
                }
                else
                {
                    // add the current char to the dictionary with its current location
                    charMap.Add(s[i], i);
                }

                // record the current substring length
                currentSubstringLength = i - currentSubstringStart;

                maxLengthSoFar = Math.Max(maxLengthSoFar, currentSubstringLength);
            }

            return maxLengthSoFar;
        }
    }
}