using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        String[] ele1 = Console.ReadLine().Split(' ');
        String[] ele2 = Console.ReadLine().Split(' ');
        int fine = 0;
        for(int i = 2; i > -1; i--)
        {
            if(int.Parse(ele1[2])>int.Parse(ele2[2]))
            {
                fine=10000;
            }
            else if(ele1[2]==ele2[2] && (int.Parse(ele1[1])>int.Parse(ele2[1]))){fine = 500*(int.Parse(ele1[1])-int.Parse(ele2[1]));}
            else if((ele1[2]==ele2[2] && ele1[1]==ele2[1]) && int.Parse(ele1[0])>int.Parse(ele2[0])){fine = 15*(int.Parse(ele1[0])-int.Parse(ele2[0]));}}
           
            Console.WriteLine(Math.Abs(fine));
        
    }
}
