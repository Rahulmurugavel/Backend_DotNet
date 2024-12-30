using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rahul
{
    internal class ListTask
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> numbers1 = new List<int>() { 6, 7 };
        public void Display()
        {
            numbers.Add(8);
            numbers.Insert(1, 20);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.InsertRange(3, numbers1);
            numbers.AddRange(numbers1);//Add at last
            numbers.Sort();
            numbers.Reverse();
            numbers.Remove(1);
            //numbers.RemoveAll();
            numbers.RemoveAt(2);
            bool a=numbers.Contains(8);
            Console.WriteLine(a);
        }
    }
}
