using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int tests = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < tests; i++)
        {
            string answer = "Funny";
            String s = Console.ReadLine();
            int len = s.Length;
            for(int j = 0; j < len-1; j++)
            {
                if(Math.Abs((Convert.ToInt32(s[j])) - (Convert.ToInt32(s[j+1]))) == Math.Abs((Convert.ToInt32(s[len-(j+2)])) - (Convert.ToInt32(s[len-(j+1)]))))
                {
                    continue;
                }
                else{answer = "Not Funny"; break;}
            }
            Console.WriteLine(answer);
        }
    }
}
