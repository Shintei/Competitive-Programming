using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        long sum = 0;
        String s = Console.ReadLine();
        String[] nums = s.Split(' ');
        for(int i = 0; i < n; i++)
            sum += Convert.ToInt32(nums[i]);
        
        Console.WriteLine(sum);
    }
}
