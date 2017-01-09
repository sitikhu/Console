using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest.math
{
    class arithmatics
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = +[i];


            }
            return sum;
        }
    }

    public class Rectangle
    {
        public int length
        { get; set; }
        public int breadth
        { get; set; }


        public int perimeter
        { get { return length + breadth; } }
        public int area
        { get { return length * breadth; } }


    }


}


