using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            GetVowelCount("Cocotipulapia");
        }

        public static int GetVowelCount(string str) {

            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            var readVowels = str.ToLower();

            int vowelcount = readVowels.Count(c => vowels.Contains(c));
            
            Console.WriteLine(vowelcount);
            return vowelcount;
        }
    }
}
