using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q3{
    class Friend{
        public int P {get; set;}
        public int W {get; set;}
        public int D {get; set;}

        public int Time(int c){
            int distance = Math.Abs(c - P);
            if (distance <= D){  return 0; }
            return W * (distance - D);
        }
    }

    class Program{
        public static int sumTimes (int c, Friend[] friends){
            int sum = 0;
            foreach (Friend friend in friends){
                sum += friend.Time(c);
            }
            return sum;
        }

        public static int findC (int c, int min, int max, Friend[] friends){
            int sum      = sumTimes(c, friends);
            int sumLeft  = sumTimes(c - 1, friends);
            int sumRight = sumTimes(c + 1, friends);
            if (sum <= sumLeft && sum <= sumRight){return c;}
            else if (sumLeft <= sumRight){return findC(c-1, min, max, friends);}
            else {return findC(c + 1, min, max, friends);}
        }

        static void Main(string[] args){
            int N            = Convert.ToInt32(Console.ReadLine());
            Friend[] friends = new Friend[N];
            int[] pos        = new int[N];
            string[] input;
            for (int i = 0; i < N; i++){
                input        = Console.ReadLine().Split(' ');
                friends[i]   = new Friend();
                friends[i].P = Convert.ToInt32(input[0]);
                friends[i].W = Convert.ToInt32(input[1]);
                friends[i].D = Convert.ToInt32(input[2]);
                pos[i]       = friends[i].P;
            }

            int c = findC((pos.Min() + pos.Max())/2, pos.Min(), pos.Max(), friends);
            int min_time = sumTimes(c, friends);
            Console.WriteLine(min_time);
        }
    }
}