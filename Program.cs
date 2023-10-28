using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Diagnostics;
using System.Numerics;

class Program
{
    /*
    Project Euler Problem 9: Special Pythagorean Triplet

    Summary:
    1. Find all the values of a, b and c that total to 1000 where a < b < c and a^2 + b^2 = c^2
    2. Multiply a * b  * c

    Then multiply the digits together to get the largest product in the series
    */
    
    static void Main(string[] args)
    {        
        int ans = 1;
        int c = 0; 

        for (int a = 0; a <= 1000; a++) {    
            /*Find values for a, b and c where a + b + c = 1000 by taking 
            the remainigng sum of 1000 - a then 1000 - a - b*/
            for (int b = 0; b <= 1000-a; b++) {
                
                c = 1000 - a - b;
                
                if ((a + b + c == 1000) && (a < b) && (b < c) && (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))) {
                    Console.WriteLine($"{a}, {b}, {c}");
                    ans = a * b * c;
                }

            }

        } 
        Console.WriteLine(ans);
    }
}
