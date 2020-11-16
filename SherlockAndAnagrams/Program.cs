using System;
using System.Collections.Generic;
using System.Linq;

namespace SherlockAndAnagrams
{
    class Program
    {
        static int sherlockAndAnagrams(string s)
        {
            int anagrams = 0;
            for (int length = 1; length < s.Length; length++)
            {
                for (int i = 0; i < s.Length - length; i++)
                {
                    List<char> left = s.Substring(i, length).ToCharArray().ToList();
                    left.Sort();

                    for (int j = i+1; j + length <= s.Length; j++)
                    {
                        List<char> right = s.Substring(j, length).ToCharArray().ToList();
                        right.Sort();

                        if (left.SequenceEqual(right))
                        {
                            anagrams++;
                        }
                    }
                }                
            }
            return anagrams;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(sherlockAndAnagrams("kkkk"));
            Console.WriteLine(sherlockAndAnagrams("abcd"));

        }
    }
}
