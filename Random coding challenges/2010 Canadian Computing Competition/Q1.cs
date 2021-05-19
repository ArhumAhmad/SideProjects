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
        public int Score {get;}

        public void setScore(){
            Score = 2 * R + 3 * S + D;
        }
    }
}