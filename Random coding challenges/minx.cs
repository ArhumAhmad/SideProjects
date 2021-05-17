using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minx{
    class Program{

        public static int minx(int[] arr, int x){
            if ((arr.Last() > 1 && arr.Last() < x) || arr.Last() < 0){
                //Postive last value, but less than x
                //OR Negative last number

                //Send to recursive statement if arr has more than one element, otherwise return the difference
                //between x and arr.Last()
                return (arr.Length > 1 ? minx(arr.Take(arr.Length - 1).ToArray(), x - arr.Last()) : x - arr.Last());
            }
            else if (arr.Last() > 1){
                //Postive last value, greater than x
                //MinX in this situation would be 1
                return (arr.Length > 1 ? minx(arr.Take(arr.Length - 1).ToArray(), 1) : 1);
            }
            else{
                //If the last value of array is 0, then x is equal to the running sum
                return (arr.Length > 1 ? minx(arr.Take(arr.Length - 1).ToArray(), x) : x);
            }
        }

        static void Main(string[] args){
            int[] test1 = new int[] {-3, 4, 5, 2};
            int num = minx(test1, 1);
            Console.WriteLine(num);

            int[] test2 = new int[] {2, 4, -3, 1, 7, -6};
            num = minx(test2, 1);
            Console.WriteLine(num);

            int[] test3 = new int[] {2, -6, 4, -3};
            num = minx(test3, 1);
            Console.WriteLine(num);
        }
    }
}