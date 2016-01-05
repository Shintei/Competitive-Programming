using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        String s = Console.ReadLine().ToLower();
        bool answer = true;
        for(int i = 0; i< 26; i++)
        {
            if(s.Contains(""+((char)(i+97)))){}
            else{answer=false;}
        }
        if(answer){Console.WriteLine("pangram");}
        else{Console.WriteLine("not pangram");}
    }
}
