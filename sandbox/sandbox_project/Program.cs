using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;


public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("\n======================\nSimple Recursive Algorithm\n======================");

        // a recursive function to count down from number n
            void countDown(int num){
                Console.WriteLine(num);
                                if(num == 1){
                    return;
                }

                num -= 1;
                countDown(num);
            }
            countDown(8);

        // a recursive function to sum all of the numbers from 1 to n}
            int getNumCountSum(int n){
                if(n == 1){
                    return 1;
                }
                return n + getNumCountSum(n-1);
            }

            Console.WriteLine(getNumCountSum(5));
    }
}