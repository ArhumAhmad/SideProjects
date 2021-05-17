using System;

namespace minx{
    class Program{

        public int minx(int[] arr, int x){
            if ((arr.Last() > 1 && arr.Last() < x) || arr.Last() < 0){
                //Postive last value, but less than x
                //OR Negative last number

                //Send to recursive statement if arr has more than one element, otherwise return the difference
                //between x and arr.Last()
                return (arr.Length > 1 ? minx(arr.Take(arr.Length - 1), x - arr.Last()) : x - arr.Last());
            }
            else if (arr.Last() > 1){
                //Postive last value, greater than x
                //MinX in this situation would be 1
                return (arr.Length > 1 ? minx(arr.Take(arr.Length - 1), 1) : 1);
            }
            else{
                //If the last value of array is 0, then x is equal to the running sum
                return (arr.Length > 1 ? minx(arr.Take(arr.Length - 1), x) : x);
            }
        }
    }
}