using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//INCOMPLETE

namespace Q3{
    class Restaraunt{
        public List<Restaraunt> path;
        public bool isViet {get; set;}
        public int id {get; set;}

        public Restaraunt(int Id){id = Id;}

        public void addPath(Restaraunt a){path.Add(a);}
    }

    class Path{
        public int length {get; set;}
        public List<Restaraunt> allRests;
        public List<Restaraunt> vietRests;

        public void addViet(Restaraunt a){vietRests.Add(a);}
        public void addRest(Restaraunt a){allRests.Add(a);}
    }

    class Program{

        static void Main(string[] args){
            string[] input = Console.ReadLine().Split(' ');
            int N          = Convert.ToInt32(input[0]);
            int M          = Convert.ToInt32(input[1]);

            List<Restaraunt> allRests = new List<Restaraunt>();
            for (int i = 0; i < N; i++){
                allRests.Add(new Restaraunt(i));
            }

            input = Console.ReadLine().Split(' ');
            foreach(string num in input){
                allRests[Convert.ToInt32(num)].isViet = true;
            }

            for (int i = 0; i < N-1; i++){
                input = Console.ReadLine().Split(' ');
                int ida = Convert.ToInt32(input[0]);
                int idb = Convert.ToInt32(input[1]);
                allRests[ida].addPath(allRests[idb]);
                allRests[idb].addPath(allRests[ida]);
            }
        }
    }
}