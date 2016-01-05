using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
    StringBuilder sb = new StringBuilder("");
    String s = Console.ReadLine();
    char[] temp = s.ToCharArray();
    if(temp[8]=='A')
    {
        String[] elements = s.Split(':','A','M');
        if(elements[0]=="12"){elements[0]="00";}
        sb.Append(elements[0]);
        sb.Append(":");
        sb.Append(elements[1]);
        sb.Append(":");
        sb.Append(elements[2]);
        
         Console.WriteLine(sb.ToString());
    }
    else
    {
       String[] elements = s.Split(':','P','M');
        if(elements[0]=="12"){}
        else{int newnum = Convert.ToInt32(elements[0])+12; elements[0]=newnum.ToString();}
        sb.Append(elements[0]);
        sb.Append(":");
        sb.Append(elements[1]);
        sb.Append(":");
        sb.Append(elements[2]);
        Console.WriteLine(sb.ToString());
    }}}
