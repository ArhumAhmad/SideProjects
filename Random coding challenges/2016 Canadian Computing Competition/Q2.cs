using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2{
    class Program{



        public static int maximize(List<int> D, List<int> P){
            int speed = 0;
            while (D.Count > 0){
                if(D[0] >= P[0]){
                    speed += D[0];
                    D.RemoveAt(0);
                    P.RemoveAt(P.Count-1);
                } else{
                    speed += P[0];
                    P.RemoveAt(0);
                    D.RemoveAt(D.Count-1);
                }
            }
            return speed;
        }

        public static int minimize(List<int> D, List<int> P){
            int speed = 0;
            while (D.Count > 0){
                speed += Math.Max(D[0], P[0]);
                P.RemoveAt(0);
                D.RemoveAt(0);
            }
            return speed;
        }

        static void Main(string[] args){
            int q = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());

            string[] input;
            input = Console.ReadLine().Split(' ');
            List<int> D = new List<int>();
            foreach(string num in input){D.Add(Convert.ToInt32(num));}

            input = Console.ReadLine().Split(' ');
            List<int> P = new List<int>();
            foreach(string num in input){P.Add(Convert.ToInt32(num));}

            D.Sort();
            D.Reverse();
            P.Sort();
            P.Reverse();
            if(q == 1){Console.WriteLine(minimize(D, P));}
            else{Console.WriteLine(maximize(D,P));}
        }

    }
}