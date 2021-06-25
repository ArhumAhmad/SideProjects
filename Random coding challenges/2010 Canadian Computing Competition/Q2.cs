using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2{
    class node{
        public char Letter {get; set;}
        public node Left;
        public node Right;

        public void addRight(){
            Right = new node();
        }

        public void addLeft(){
            Left = new node();
        }

        public node getRight(){
            return Right;
        }

        public node getLeft(){
            return left;
        }
    }

    class Program{
        public static void findLetter(nnode, sequence){
            
        }

        static void Main(string[] args){
            int k     = Convert.ToInt32(Console.ReadLine());
            node head = new node();
            char c;
            char[] sequence;
            string[] input;

            for (int i = 0; i < k; i++){
                input = Console.ReadLine().Split(' ');
                c = input[0].ToCharArray()[0];
                Console.WriteLine(c);
                sequence = input[1].ToCharArray();
                head.findNode(sequence).setLetter(c);
            }
        }
    }
}