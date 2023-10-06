using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Input
        string input = "zzabcdddddaa";
        int[] queries = {32, 1, 2, 3, 2, 1};
        
        // Weighted Strings Function
        WeightedStrings(input, queries); // Expected: ['No', 'Yes', 'Yes', 'Yes', 'No', 'No']
        
        // Test case
        WeightedStrings("abcd", new int[] {1,2,3,4}); // Expected: ['Yes', 'Yes', 'Yes', 'Yes']
        WeightedStrings("abcdd", new int[] {1,2,3,5}); // Expected: ['Yes', 'Yes', 'Yes', 'No']
        WeightedStrings("abbcccd", new int[] {1,3,9,8}); // Expected: ['Yes', 'No', 'Yes', 'No']
    }
    
    static void WeightedStrings(string input, int[] queries)
    {
        // Algoritma
        var result = new List<string>();
        int queryIndex = 0;
        int currentWeight = 0; // 
        
        var inputLower = input.ToLower().ToList();
        
        for(var i = 0; i < inputLower.Count() ; i++)
        {
            if (i == 0) 
            {
                currentWeight += inputLower[i] - 96; // ASCII 'a' = 97 sehingga 'a' menjadi 1
            }
            else 
            {
                if(inputLower[i] == inputLower[i-1]) 
                {
                    currentWeight += inputLower[i] - 96;
                }
                else 
                {
                    result.Add(currentWeight == queries[queryIndex] ? "Yes" : "No");
                    queryIndex++;
                    currentWeight = inputLower[i] - 96;
                }
            }
        }
        result.Add(currentWeight == queries[queryIndex] ? "Yes" : "No"); // Memproses weight terakhir
        
        // Print Output
        if (queryIndex+1 != queries.Count())
        {
            // Handle queries lebih dari jumlah substring
            // Apabila queries kurang dari jumlah substring maka akan terjadi list out of index (belum dihandle)
            Console.WriteLine("Queries tidak sesuai");
        }
        else
        {
            Console.WriteLine("string: {0}", input);
            Console.WriteLine("['{0}']", string.Join("', '", result.ToArray()));
        }
    }
}