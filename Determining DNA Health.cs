using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


class Result
{
    /*
     * Complete the 'dnaHealth' function below.
     */
    public static void dnaHealth(List<string> genes, List<int> health, List<string> queries)
    {
        long minHealth = long.MaxValue;
        long maxHealth = long.MinValue;
        
        
        Dictionary<string, List<int>> geneHealth = new Dictionary<string, List<int>>();
        for (int i = 0; i < genes.Count; i++)
        {
            if (!geneHealth.ContainsKey(genes[i]))
            {
                geneHealth[genes[i]] = new List<int>();
            }
            geneHealth[genes[i]].Add(health[i]);
        }
        
        foreach (string query in queries)
        {
            string[] parts = query.Split(' ');
            int first = int.Parse(parts[0]);
            int last = int.Parse(parts[1]);
            string d = parts[2];
            
            long totalHealth = CalculateHealth(d, geneHealth, first, last);
            
            minHealth = Math.Min(minHealth, totalHealth);
            maxHealth = Math.Max(maxHealth, totalHealth);
        }
        
        Console.WriteLine($"{minHealth} {maxHealth}");
    }
    
    private static long CalculateHealth(string d, Dictionary<string, List<int>> geneHealth, int first, int last)
    {
        long total = 0;
        
        
        for (int i = 0; i < d.Length; i++)
        {
            for (int j = i; j < d.Length; j++)
            {
                string substring = d.Substring(i, j - i + 1);
                
                if (geneHealth.ContainsKey(substring))
                {
                    foreach (int healthValue in geneHealth[substring])
                    {
                        total += healthValue;
                    }
                }
            }
        }
        
        return total;
    }
}



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> genes = Console.ReadLine().TrimEnd().Split(' ').ToList();

        List<int> health = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(healthTemp => Convert.ToInt32(healthTemp)).ToList();

        int s = Convert.ToInt32(Console.ReadLine().Trim());

        for (int sItr = 0; sItr < s; sItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int first = Convert.ToInt32(firstMultipleInput[0]);

            int last = Convert.ToInt32(firstMultipleInput[1]);

            string d = firstMultipleInput[2];
        }
    }
}
