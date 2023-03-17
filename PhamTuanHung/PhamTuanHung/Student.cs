using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Student : IStudent
    {
        private int[] MarkList = new int[3];

        public int StudID { get ; set ; }
        public int StudAge { get ; set ; }
        public string StudName { get ; set ; }
        public string StudGender { get ; set; }
        public string StudClass { get ; set ; }

        public float StudAvgMark { get; private set; }

        public int this[int i]
        {
            get { return MarkList[i]; }
            set { MarkList[i] = value; }
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Student ID: " + StudID);
            Console.WriteLine("Student Name: " + StudName);
            Console.WriteLine("Student Gender: " + StudGender);
            Console.WriteLine("Student Age: " + StudAge);
            Console.WriteLine("Student Class: " + StudClass);
            Console.WriteLine("Student Average Mark: " + StudAvgMark);
        }

        public void CalAvg()
        {
            float sum = 0;

            foreach (int i in MarkList)
            {
                sum += i;
            }

            StudAvgMark = sum / MarkList.Length;
        }
    }
}
