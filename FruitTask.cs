using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rahul
{
    internal class FruitTask
    {
        //public int number = 1;
        //string[] arr = { "Apple", "Banana", "Grapes", "Melon", "WaterMelon" };
        //public void Display()
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = arr[i].ToLower();
        //    }
        //    while (number > 0)
        //    {
        //        Console.WriteLine("------------------------------------------------------");
        //        Console.WriteLine("Operations");
        //        Console.WriteLine("1.Display Fruit");
        //        Console.WriteLine("2.Find Fruit");
        //        Console.WriteLine("3.Exit");
        //        int num = int.Parse(Console.ReadLine());
        //        switch (num)
        //        {
        //            case 1:
        //                DisplayFruit();
        //                number = num;
        //                break;
        //            case 2:
        //                FindFruit();
        //                number = num;
        //                break;
        //            case 3:
        //                number = 0;
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}
        //public void DisplayFruit()
        //{
        //    foreach (string str in arr)
        //    {
        //        Console.WriteLine(str);
        //    }
        //}
        //public void FindFruit()
        //{
        //    Console.WriteLine("Enter the fruit to display:");
        //    string value= Console.ReadLine();
        //    value = value.ToLower();
        //    int num1=Array.IndexOf(arr, value);
        //    if (num1 == -1)
        //    {
        //        Console.WriteLine("Enter fruit is Not Existed:");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Entered fruit is Existed and if Index:" + num1);
        //    }
        //}
        public int number = 1;
        string[] arr = { "Apple", "Banana", "Grapes", "Melon", "WaterMelon" };
        public void Display()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].ToLower();
            }
           
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Operations");
                Console.WriteLine("1.Display Fruit");
                Console.WriteLine("2.Find Fruit");
                Console.WriteLine("3.Exit");
                int num = int.Parse(Console.ReadLine());
                Display1(num);
            
        }
        public void Display1(int num)
        {
            switch (num)
            {
                case 1:
                    DisplayFruit();
                    Display();
                    break;
                case 2:
                    FindFruit();
                    Display();
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
        public void DisplayFruit()
        {
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }
        }
        public void FindFruit()
        {
            Console.WriteLine("Enter the fruit to display:");
            string value = Console.ReadLine();
            value = value.ToLower();
            int num1 = Array.IndexOf(arr, value);
            if (num1 == -1)
            {
                Console.WriteLine("Enter fruit is Not Existed:");
            }
            else
            {
                Console.WriteLine("Entered fruit is Existed and if Index:" + num1);
            }
        }
    }
}
