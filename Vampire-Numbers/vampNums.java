/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Aubel
 */
import java.util.Arrays;
import java.util.Scanner;

public class vampNums {
	
	int n;
	
	public vampNums()
	{
		Scanner input = new Scanner(System.in);
		System.out.println("Input numbers: ");
		n = input.nextInt();
	}
	
	public static int isVampire(int x)
	{
		
		for(int i = 2; i < (x/2); i++)
		{
			if(x%i == 0)
			{
				int f1 = i;
				int f2 = x/i;
				String side1 = "" + f1 + "" + f2;
				String side2 = "" + x;
				char[] ans = side1.toCharArray();
				char[] ans2 = side2.toCharArray();
				Arrays.sort(ans);
				Arrays.sort(ans2);
				String final1 = new String(ans);
				String final2 = new String(ans2);
				if(final1.equals(final2))
				{System.out.println("N/2 approach: Your vampire number is: " + x);
					return 1;}
			}
		}
		
		return 0;
	}
	
	public static void main(String args[]) {

            long start_time = System.nanoTime();
            int test = 700_000;
            int j = 0;
            while(j==0)
                {
                    test++; j = isVampire(test);
                }
            long end_time = System.nanoTime();
            System.out.println("Process took: " + ((end_time - start_time)/1_000_000) + "ms.");
	}
}
