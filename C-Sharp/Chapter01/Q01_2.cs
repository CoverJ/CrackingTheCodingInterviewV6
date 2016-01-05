using Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    /// <summary>
    /// Check Permutation
    /// 
    /// Given two strings, write a method to decide if one is a permutation of the other
    /// </summary>
    public class Q01_2 : IQuestion
    {
        public bool IsPermutation(string a, string b)
        {
            // First test: If a and b are different lengths, automatically can't be a permutation
            if (a.Length != b.Length)
                return false;
            // Declare dictionaries we will use for comparison
            var dictionaryA = new Dictionary<char, int>();
            var dictionaryB = new Dictionary<char, int>();

            // tokenize strings into dictionaries
            foreach (char c in a)
            {
                if (dictionaryA.ContainsKey(c))
                    dictionaryA[c]++;
                else
                    dictionaryA.Add(c, 1);
            }
            foreach (char c in b)
            {
                if (dictionaryB.ContainsKey(c))
                    dictionaryB[c]++;
                else
                    dictionaryB.Add(c, 1);
            }
            // first we can test if A and B's Keys collection match
            var keysA = dictionaryA.Keys;
            var keysB = dictionaryB.Keys;

            
        }

        void IQuestion.Run()
        {
            throw new NotImplementedException();
        }
    }
}
