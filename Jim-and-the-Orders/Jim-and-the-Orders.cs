using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int tests = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        int[] customers = new int[tests];
        customers[0] = int.MaxValue;
        for(int i = 0; i < tests; i++)
        {
            String[] nums = Console.ReadLine().Split(' ');
            int total = Convert.ToInt32(nums[0]) + Convert.ToInt32(nums[1]);
            customers[i] = total;
        }
        for(int j = 0; j < tests; j++)
        {
            int minIndex = Array.IndexOf(customers, customers.Min());
            Console.Write(minIndex+1 + " ");
            customers[minIndex] = int.MaxValue;
        }
    }
}
