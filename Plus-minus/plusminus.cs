using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        String s = Console.ReadLine();
        String[] split_elements = s.Split(' ');
        float a = 0.0f, b = 0.0f, c = 0.0f;
        float af=0.0f, bf=0.0f, cf =0.0f;
        for(int i = 0; i < n; i++)
        {
            if(Convert.ToInt32(split_elements[i])<0)
            {
                a++;
            }
            else if(Convert.ToInt32(split_elements[i])>0)
            {
                c++;
            }
            else b++;
        }
        af = a/n;
        bf = b/n;
        cf = c/n;
        Console.WriteLine(cf);
        Console.WriteLine(af);
        Console.WriteLine(bf);
    }
}
