using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int tests = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < tests; i++)
        {
            String s = Console.ReadLine();
            char[] sarr = s.ToCharArray();
            int sum = 0;
            for(int j = 1; j < sarr.Length; j++)
            {
                if(sarr[j]==sarr[j-1])sum++;
            }
            Console.WriteLine(sum);
        }
    }
}
