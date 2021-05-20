using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2{
    class node{
        public bool isLeaf {get; set;}
        public char Letter {get; set;}
        public node Left {get; set;}
        public bool hasLeft {get; set;}
        public node Right {get; set;}
        public bool hasRight {get; set;}

        public node(){
            isLeaf   = false;
            hasLeft  = false;
            hasRight = false;
        }

        public node addRight(){
            Right = new node();
            hasRight = true;
            return Right;
        }

        public node addLeft(){
            Left = new node();
            hasLeft = true;
            return Left;
        }

        public void setLetter(char c){
            Letter = c;
            isLeaf = true;
        }

        public node findNode(char[] c){

            if (c.Length == 1){
                if (c[0] == '0'){
                    //if (hasLeft == false) {Left = new node();}
                    //return Left;
                    Console.WriteLine(1);
                }
                else{
                    //if (hasRight == false) {Right = new node();}
                    //return Right;
                    Console.WriteLine(2);
                }
            }
            if (c[0] == '0'){
                //if (hasLeft == false) {Left = new node();}
                //return Left.findNode(c.Skip(0).ToArray());
                Console.WriteLine(3);
            }
            else{
                //if (hasRight == false) {Right = new node();}
                //return Right.findNode(c.Skip(0).ToArray());
                Console.WriteLine(4)
            }
            System.Environment.Exit(69);
        }
    }

    class Program{
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