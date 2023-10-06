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
        Console.WriteLine("{0}", BalancedBracket("{[()]}")); // Expected: YES
        Console.WriteLine("{0}", BalancedBracket("{[(])}")); // Expected: NO
        Console.WriteLine("{0}", BalancedBracket("{(([])[])[]}")); // Expected: YES
        Console.WriteLine("{0}", BalancedBracket("[[][][][{]]}")); // Expected: NO
        Console.WriteLine("{0}", BalancedBracket("[ ]  [ ] [] ")); // Expected: YES
        Console.WriteLine("{0}", BalancedBracket("{]")); // Expected: NO
    }
    
    static string BalancedBracket(string s)
    {
        string status = "YES";
        int i = 0;
        
        Stack<char> brackets = new Stack<char>();
        
        while (status == "YES" && i < s.Length) 
        {
            if (s[i] == '{' || s[i] == '(' || s[i] == '[')
            {
                brackets.Push(s[i]);
            }
            else 
            {
                switch(s[i]) 
                {
                  case '}':
                    status = brackets.Peek() == '{' ? "YES" : "NO";
                    brackets.Pop();
                    break;
                  case ')':
                    status = brackets.Peek() == '(' ? "YES" : "NO";
                    brackets.Pop();
                    break;
                  case ']':
                    status = brackets.Peek() == '[' ? "YES" : "NO";
                    brackets.Pop();
                    break;
                }
            }
            i++;
        }
        
        // Memeriksa jika terjadapat input diluar scope seperti "[[", "{]", dan "((([]"
        return brackets.Count != 0 ? "NO" : status;
    }
}