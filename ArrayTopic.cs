using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rahul
{
    public class ArrayTopic
    {
        int[] numbers = { 10, 200, 6, 4, 51 };
        
        public void Display()
        {
            int[] number1 = new int[numbers.Length];
            //Array.Copy(numbers,number1,5);
            //foreach (int i in number1)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine(Array.IndexOf(numbers,6));
            Console.WriteLine(Array.BinarySearch(numbers,6));
            numbers.CopyTo(number1, 0);
            foreach(int i in number1)
            {
                Console.WriteLine(i);   
            }
            Array.Resize(ref number1,7);
            number1[5] = 10;
            number1[6] = 20;
            Console.WriteLine("Resized array is:");
            foreach (int i in number1)
            {
                Console.WriteLine(i);
            }
            Array.Clear(number1, 5, 2);
            Console.WriteLine("Cleared array is:");
            foreach(int i in number1)
            {
                Console.WriteLine(i);
            }

        }
    }
}
