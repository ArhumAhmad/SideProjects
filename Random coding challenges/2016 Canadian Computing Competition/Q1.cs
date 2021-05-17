using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Program returns A if program is an anagram
//Returns N if it isn't
//Uses * as wildcard characters in second string

namespace Q1{
    class Program{

        public static bool isRegAnagram(string a, string b){
            char[] A = a.ToArray();
            char[] B = b.ToArray();
            Array.Sort(A);
            Array.Sort(B);
            return (A == B);
        }

        public static int occurances(char[] s, char c){
            int count = 0;
            foreach (char element in s){
                if (element == c){count++;}
            }
            return count;
        }

        public static bool isWildAnagram(string a, string b){
            char[] A        = a.ToArray();
            char[] B        = b.ToArray();
            int wild        = occurances(B, '*');
            int missing     = 0;
            List<char> read = new List<char>();

            for (int i = 0; i < A.Length; i++){
                if (!read.Contains(A[i])){
                    if (occurances(A, A[i]) < occurances(B, A[i])){return false;}
                    missing += occurances(A, A[i]) - occurances(B, A[i]);
                    read.Add(A[i]);
                }
            }
            return (wild == missing);
        }

        public static bool isAnagram(string a, string b){
            if (a.Length != b.Length){return false;}
            if (a == b) {return true;}
            if (isRegAnagram(a, b)){return true;}
            if (isWildAnagram(a, b)){return true;}
            return false;
        }

        public static void test(string a, string b){
            if (isAnagram(a, b)){
                Console.WriteLine("A");
            }else {Console.WriteLine("N");}
        }

        static void Main(string[] args){
            string test1a = "abba";
            string test1b = "baaa";
            test(test1a, test1b);

            string test2a = "cccrocks";
            string test2b = "socc*rk*";
            test(test2a, test2b);
        }

    }


}