using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] elems = Console.ReadLine().Split(' ');
        int N = Convert.ToInt32(elems[0]);
        int K = Convert.ToInt32(elems[1]);
        int answer = 0, sum = 0;
        
        string[] cost = Console.ReadLine().Split(' ');
        int[] costs = new int[N];
        for(int j = 0; j < N; j++)
        {
            costs[j] = Convert.ToInt32(cost[j]);
        }
        Array.Sort(costs);
        for(int i = 0; i < costs.Length; i++)
        {
            sum+=Convert.ToInt32(costs[i]);
            if(sum>K){break;}
            else{answer++;}
        }
        Console.WriteLine(answer);
    }
}
