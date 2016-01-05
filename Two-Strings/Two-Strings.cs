using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        int tests = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < tests; i++)
        {
            StringBuilder sb = new StringBuilder("");
            StringBuilder sb2 = new StringBuilder("");
            sb.Append(Console.ReadLine());
            sb2.Append(Console.ReadLine());
            bool answer = false;
            char[] subs = new char[26];
            for(int j = 0; j < sb.Length; j++)
            {
                if(sb.ToString()[j] > (char)96 && sb.ToString()[j] < (char)123)
                {
                    int index = (int)sb.ToString()[j];
                    subs[index-97]='1';
                }
            }
            for(int k = 97; k < 123; k++)
            {
                if(sb2.ToString().Contains(""+(char)k) && subs[k-97]=='1')
                {
                    answer = true;
                }
                else{}
            }
            if(answer){Console.WriteLine("YES");}
            else{Console.WriteLine("NO");}
            answer = false;
        }
    }
}
