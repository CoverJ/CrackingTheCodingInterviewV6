using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Chapter01
{
    /// <summary>
    /// Is Unique
    /// 
    /// Implement an algorithm to determine if a string has all unique characters.
    /// What if you cannot use additional data structures?
    /// 
    /// While able to use additional data structures I use a Dictionary to record Keys and basically if the key exists there is a duplicate.
    /// If I was unable to use additional data structures I would sort the string into a char array and then compare Array[i] to Array[i+1] up until Array.Length - 1
    /// If they match it means there is a duplicate in the string.
    /// </summary>
    public class Q01_1 : IQuestion
    {
        public bool IsUnique(string s)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (dictionary.ContainsKey(c))
                    return false;
                else
                    dictionary.Add(c, 1);
            }
            return true;
        }

        public bool IsUniqueNoExtraDataStructures(string s)
        {
            char[] tokens = s.ToCharArray();
            Array.Sort(tokens);
            for (int i = 0; i < tokens.Length - 1; i++)
            {
                if (tokens[i] == tokens[i + 1])
                    return false;
            }
            return true;
        }

        void IQuestion.Run()
        {
            Console.WriteLine("Enter string to test for duplicates");
            string s = Console.ReadLine();
            bool result = IsUnique(s);
            Console.WriteLine("Result is: " + result.ToString());
            Console.ReadKey();
        }
    }
}
