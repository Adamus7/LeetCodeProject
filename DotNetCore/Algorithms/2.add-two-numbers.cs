/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 *
 * https://leetcode.com/problems/add-two-numbers/description/
 *
 * algorithms
 * Medium (29.98%)
 * Total Accepted:    696.4K
 * Total Submissions: 2.3M
 * Testcase Example:  '[2,4,3]\n[5,6,4]'
 *
 * You are given two non-empty linked lists representing two non-negative
 * integers. The digits are stored in reverse order and each of their nodes
 * contain a single digit. Add the two numbers and return it as a linked list.
 * 
 * You may assume the two numbers do not contain any leading zero, except the
 * number 0 itself.
 * 
 * Example:
 * 
 * 
 * Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
 * Output: 7 -> 0 -> 8
 * Explanation: 342 + 465 = 807.
 * 
 * 
 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
using System;
using System.Collections.Generic;
using Algorithms.Utils;

namespace Algorithms
{
    public class Solution002
    {
        public static ListNode<int> AddTwoNumbers(ListNode<int> l1, ListNode<int> l2)
        {
            ListNode<int> head = new ListNode<int>(0);
            ListNode<int> current = head;
            var carry = 0;
            while (l1 != null || l2 != null)
            {
                var x = l1 != null ? l1.Val : 0;
                var y = l2 != null ? l2.Val : 0;
                var digit = carry + x + y;
                carry = digit / 10;
                current.Next = new ListNode<int>(digit % 10);
                current = current.Next;
                if (l1 != null) { l1 = l1.Next; }
                if (l2 != null) { l2 = l2.Next; }
            }
            if (carry > 0) { current.Next = new ListNode<int>(carry); }
            return head.Next;
        }
    }

}

