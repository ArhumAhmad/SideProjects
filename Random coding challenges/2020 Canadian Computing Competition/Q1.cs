using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1{
    class Plank{
        public float left {get; set;}
        public float right {get; set;}
        public float width {get; set;}

        //Each wood plank has a rectangle with a triangle on top
        //Calculate the area of the rectangle and triangle 
        //and add them together
        public float area(){
            //Rectangle
            float a1 = Math.Min(left, right) * width;

            //Triangle
            float a2 = (Math.Abs(left - right) * width) / 2;

            return a1 + a2;
        }
    }

    class Program{
        static void Main(string[] args){
            int N               = Convert.ToInt32(Console.ReadLine());
            Plank[] planks      = new Plank[N];
            string[] heights    = Console.ReadLine().Split(' ');
            string[] widths     = Console.ReadLine().Split(' ');
            float sum           = 0f;

            for(int i = 0; i < N; i++){
                planks[i]       = new Plank();
                planks[i].left  = Convert.ToInt32(heights[i]);
                planks[i].right = Convert.ToInt32(heights[i+1]);
                planks[i].width = Convert.ToInt32(widths[i]);
                sum            += planks[i].area();
            }

            Console.WriteLine(sum);
        }
    }
}