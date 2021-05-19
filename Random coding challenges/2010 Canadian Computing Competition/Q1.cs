using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1{
    class Computer{
        public string Name {get; set;}
        public int R {get; set;}
        public int S {get; set;}
        public int D {get; set;}
        public int Score {get; set;}

        public void setScore(){
            Score = 2 * R + 3 * S + D;
        }
    }

    class Program{
        public static List<Computer> quicksort(List<Computer> options){
            if (options.Count == 1){
                return options;
            } else if(options.Count == 0){
                return new List<Computer>();
            }

            List<Computer> left  = new List<Computer>();
            List<Computer> right = new List<Computer>();
            int mid              = options.Count / 2;
            Computer pivot       = options[mid];
            options.RemoveAt(mid);

            foreach (Computer computer in options){
                if (computer.Score <= pivot.Score){
                    left.Add(computer);
                }
                else{
                    right.Add(computer);
                }
            }

            left  = quicksort(left);
            right = quicksort(right);
            left.Add(pivot);
            left.AddRange(right);
            return left;
        }

        static void Main(string[] args){
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input;
            List<Computer> options = new List<Computer>();
            for (int i = 0; i < n; i++){
                input = Console.ReadLine().Split(' ');
                options.Add(new Computer());
                options[i].Name = input[0];
                options[i].R    = Convert.ToInt32(input[1]);
                options[i].S    = Convert.ToInt32(input[2]);
                options[i].D    = Convert.ToInt32(input[3]);
                options[i].setScore();
            }
            options = quicksort(options);
            Console.WriteLine(options[options.Count - 1].Name);
            Console.WriteLine(options[options.Count - 2].Name);
        }
    }
}