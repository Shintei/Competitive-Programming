using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
       int tests = int.Parse(Console.ReadLine());
        int t = 0, n = 0,  num = 1;
        for(int i = 0; i < tests; i++)
        {
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
               num*=2;
               n--;
               if(n==0){break;}
               num+=1;
               n--;
               
            }
            Console.WriteLine(num);
        t = 0;
        num = 1;
        }
        
    }
}
