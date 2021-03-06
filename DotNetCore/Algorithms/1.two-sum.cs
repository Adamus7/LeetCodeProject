// Source : https://leetcode.com/problems/two-sum/ 
// Author : Adamus 
// Date : Thursday, April 13, 2017 11:10:57 PM 

/**********************************************************************************
*
* Given an array of integers, return indices of the two numbers such that they add up to a specific target.
* 
* You may assume that each input would have exactly one solution, and you may not use the same element twice.
* 
* 
* Example:
* 
* Given nums = [2, 7, 11, 15], target = 9,
* 
* Because nums[0] + nums[1] = 2 + 7 = 9,
* return [0, 1].
* 
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;

namespace Algorithms
{
    public class Solution001
    {
        public static int[] TwoSum(int[] nums, int target) 
        {
            for(var i=0;i<nums.Length;i++){
                for(var j=nums.Length-1;j>i;j--){
                    if(i!=j){
                        if(nums[i]+nums[j]==target){
                            return new int[]{i,j};
                        }
                    }
                }
            }
            return new int[]{};
        }
    }
}

