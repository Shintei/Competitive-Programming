using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            StringBuilder sb = new StringBuilder("");
            for(int j = 0; j < n; j++)
            {
                if(j<((n-1)-i))sb.Append(" ");
                else sb.Append("#");
            }
            Console.WriteLine(sb);
        }
    }
}
