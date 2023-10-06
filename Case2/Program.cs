// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Test case
        Console.WriteLine("'{0}'", HighestPalindrome("3943", 1, 1).ToString()); // Sample Expected: '3993'
        Console.WriteLine("'{0}'", HighestPalindrome("394333", 2, 1).ToString()); // Expected: '394493'
        Console.WriteLine("'{0}'", HighestPalindrome("952223", 2, 1).ToString()); // Expected: '952259'
        Console.WriteLine("'{0}'", HighestPalindrome("9522332", 3, 1).ToString()); // Expected: '9532359'
    } 
    
    // Terdapat penambahan cIndex sebagai iterator untuk membantu mengakses array
    static int HighestPalindrome(string s, int k, int cIndex)
    {
        bool isPalindrome = s == string.Join("",s.Reverse());
        if (k <= 0 || isPalindrome) // Menghandle string yang sudah palindrome
        {
            return isPalindrome? int.Parse(s) : -1;
        }
        else
        {
            if (s[cIndex-1] == s[^cIndex])
            {
                return HighestPalindrome(s,k,cIndex+1);
            }
            else
            {
                var stringArray1 = s.ToArray();
                var stringArray2 = s.ToArray();
                
                stringArray1[cIndex-1] = s[^cIndex];
                stringArray2[^cIndex] = s[cIndex-1];
                
                return Math.Max(
                    HighestPalindrome(string.Join("",stringArray1), k-1, cIndex+1),
                    HighestPalindrome(string.Join("",stringArray2), k-1, cIndex+1));
            }
        }
    }
}