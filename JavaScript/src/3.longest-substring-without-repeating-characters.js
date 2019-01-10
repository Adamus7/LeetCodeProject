/*
 * @lc app=leetcode id=3 lang=javascript
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
/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function (s) {
    let result = 0,
        left = -1,
        charMap = {};

    for (let i = 0, l = s.length; i < l; i++) {
        if (charMap[s[i]] > left) {
            left = charMap[s[i]];
        }
        if (i - left > result) {
            result = i - left;
        }
        charMap[s[i]] = i;
    }
    return result;
};

console.log(lengthOfLongestSubstring('a'));
console.log(lengthOfLongestSubstring('abcde'));
console.log(lengthOfLongestSubstring('abbba'));
console.log(lengthOfLongestSubstring('quesctu'));
console.log(lengthOfLongestSubstring('bbbbb'));
console.log(lengthOfLongestSubstring('dvcdfff'));
console.log(lengthOfLongestSubstring('pwwkew'));
console.log(lengthOfLongestSubstring('abbba'));
console.log(lengthOfLongestSubstring('abbbaca'));
console.log(lengthOfLongestSubstring('abbaca'));

