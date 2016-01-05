/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Aubel
 */
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class vampNums2 {
	
	int n;
	
	public vampNums2()
	{
		Scanner input = new Scanner(System.in);
		System.out.println("Input numbers: ");
		n = input.nextInt();
	}
	
        public static int factorial(int x)
        {
            //come back and optimize if possible
            if(x <= 1)return 1;
            else return x * factorial(x-1);
        }
        
	public static int isVampire(int x)
	{
            String str = String.valueOf(x);
            List<String> list = perms(str);
            for(String s: list)
            {
               // System.out.println(s);
                int temp = Integer.parseInt(s);
                if(temp != 0 && temp != 1){
                if(x%temp == 0)
                {
                    String f1 = "" + temp;
                    
                    int fac2 = x/temp;
                    String f2 = "" + fac2; 
                    String total = f1 + f2;
                                       
                    if(list.contains(f2))
                    {
                        char[] t1=total.toCharArray();
                        char[] t2=str.toCharArray();
                        Arrays.sort(t1);
                        Arrays.sort(t2);
                        String a1 = new String(t1);
                        //System.out.println("" +a1);
                        String a2 = new String(t2);
                        if(a1.equals(a2)){
                        System.out.println("Permutation approach: Your vampire number is " + x + " consisting of " + f1 + " and " + f2);
                        return 1;}
                    }
                }}
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
        
        public static List<String> perms(String string) {

    List<String> result = new ArrayList<>();
    char[] values = string.toCharArray();
    for (int width = 1; width < values.length; width++) { // for every length
        int stack[] = new int[width];
        for (int i = 0; i < stack.length; i++) { // start from a specific point without duplicates
            stack[i] = stack.length - i - 1;
        }
        int position = 0;
        while (position < width) {

            position = 0;
            StringBuilder sb = new StringBuilder();
            while (position < width) { // build the string
                sb.append(values[stack[position]]);
                position++;
            }
            result.add(sb.toString());
            position = 0;
            while (position < width) {
                if (stack[position] < values.length - 1) {
                    stack[position]++;
                    if (containsDuplicate(stack) == false)
                        break;
                    else
                        position = 0;
                } else {
                    stack[position] = 0;
                    position++;
                }
            }
        }
    }
    return result;
}

private static boolean containsDuplicate(int[] stack) {
    for (int i = 0; i < stack.length; i++) {
        for (int j = 0; j < stack.length; j++) {
            if (stack[i] == stack[j] && i != j) {
                return true;
            }
        }
    }
    return false;
}
}


