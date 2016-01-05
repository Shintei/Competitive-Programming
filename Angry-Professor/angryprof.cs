using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int tests = Convert.ToInt32(Console.ReadLine());
        int n = 0, k = 0;
        for(int i = 0; i< tests; i++)
        {
            String s = Console.ReadLine();
            String[] elements = s.Split(' ');
            n = Convert.ToInt32(elements[0]);
            k = Convert.ToInt32(elements[1]);
            String s2 = Console.ReadLine();
            String[] elements2 = s2.Split(' ');
            int total = 0;
            for(int j = 0; j < n; j++)
            {
                if(Convert.ToInt32(elements2[j])<=0)
                {
                    total++;
                }
            }
            if(total<k){Console.WriteLine("YES");}
            else{Console.WriteLine("NO");}
        }
    }
}
