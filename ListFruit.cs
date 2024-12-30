using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rahul
{
    internal class ListFruit
    {
        List<string> values = new List<string>() { "Apple", "Banana", "Melon", "Watermelon", "Grapes" };
        public void Display()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Menu");
            Console.WriteLine("1.DisplayFruit");
            Console.WriteLine("2.AddFruit");
            Console.WriteLine("3.UpdateFruit");
            Console.WriteLine("4.DeleteFruit");
            Console.WriteLine("5.Exit");
            int operation = int.Parse(Console.ReadLine());
            Display1(operation);
        }
        public void Display1(int operation)
        {
            switch (operation)
            {
                case 1:
                    Console.WriteLine("------------------------------------");
                    DisplayFruit();
                    Display();
                    break;
                case 2:
                    Console.WriteLine("------------------------------------");
                    AddFruit();
                    Display();
                    break;
                case 3:
                    Console.WriteLine("------------------------------------");
                    UpdateFruit();
                    Display();
                    break;
                case 4:
                    Console.WriteLine("------------------------------------");
                    DeleteFruit();
                    Display();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Entered value is invalid");
                    break;
            }
        }
        public void DisplayFruit()
        {
            foreach (string value in values)
            {
                Console.WriteLine(value);
            }
        }
        public void AddFruit()
        {
            Console.WriteLine("Enter the Fruit to Add:");
            string str1 = Totile();
            //int count = 0;
            //for(int i = 0; i < values.Count; i++)
            //{
                if (values.Contains(str1))
                {
                    Console.WriteLine("Entered fruit is already present");
                    //count++;
                    AddFruit();
                }
            //}
            //if (count == 0)
            else// inthis we use commented lines also by if(count==0){
            {
                values.Add(str1);
                Print();
            }
            
        }
        public void UpdateFruit()
        {
            Console.WriteLine("Enter the fruit to be Replaced:");
            string str1 = Totile();
            if (values.Contains(str1))
            {
                Console.WriteLine("Enter the fruit to Replace:");
                string str = Totile();
                int index = values.IndexOf(str1);
                values.Remove(str1);
                values.Insert(index, str);
                Print();
            }
            else
            {
                Console.WriteLine("Fruit you are trying to Update is not there:");
                UpdateFruit();
            }
        }
        public void DeleteFruit()
        {
            Console.WriteLine("Enter the Fruit to get Deleted:");
            string str = Totile();
            if (values.Contains(str))
            {
                values.Remove(str);
                Print();
            }
            else
            {
                Console.WriteLine("Fruit trying to Delete is not there:");
                DeleteFruit();
            }
        }
        public string Totile()
        {
            string str = Console.ReadLine();
            char s = str[0];
            s = Char.ToUpper(s);
            str = str.Substring(1).ToLower();
            return s + str;
        }
        public void Print()
        {
            Console.WriteLine("New Array is:");
            foreach (string value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
