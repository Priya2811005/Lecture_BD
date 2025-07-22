using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// array with builtin function :


namespace Lecture_BD
{
    internal class P1
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 5, 7, 3, 4, 10, 20, 11, 12 };
            Console.WriteLine("Max Num :" + a.Max());
            Console.WriteLine("Min Num :" + a.Min());
            var reverse = a.Reverse();
            Console.WriteLine("Reverse is :");
            foreach (int i in reverse)
                Console.Write(i + " ");

            Array.Sort(a);
            Console.WriteLine("\nSorted is :");
            foreach (int i in a)
                Console.Write(i + " ");

        }
    }
}
