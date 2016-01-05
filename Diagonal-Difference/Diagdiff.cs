using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum1 = 0, sum2 = 0;
        String[,] m = new String[n,n];
        for(int i = 0; i < n; i++)
        {
            String s = Console.ReadLine();
            String[] split = s.Split(' ');
            int z = split.Length;
            for(int j = 0; j < z; j++)
            {
               m[i,j]=split[j];   
            }
        }
        
        for(int i = 0; i < n; i++)
        {
            sum1 += Convert.ToInt32(m[i,i]);
            sum2 += Convert.ToInt32(m[i,(n-1)-i]);
        }
        Console.WriteLine(Math.Abs(sum1-sum2));
    }
}
