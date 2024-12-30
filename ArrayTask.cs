using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rahul
{
    internal class ArrayTask
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        public void Display()
        {
            Console.WriteLine("Enter the number to find:");
            int number=Convert.ToInt32(Console.ReadLine());
            int value=0;
            value=Array.IndexOf(arr,number);
            if (value ==-1)
            {

                Console.WriteLine("Entered value is not in the array:");
               
            }
            else
            {
                Console.WriteLine("Entered value is in the array:");
                Console.WriteLine("Entered value index is:" + value);
            }
        }
    }
}
