using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        String a = Console.ReadLine();
        int z = Convert.ToInt32(a);
        String s = Console.ReadLine();
        int sum = 0;
        String[] nums = (s.Split(' '));
        for(int i = 0; i < z; i++)
        {
            sum += Convert.ToInt32(nums[i]);
        }
        Console.WriteLine(sum);
    }
}
