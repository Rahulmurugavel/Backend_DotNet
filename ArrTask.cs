using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rahul
{
    internal class ArrTask
    {
        string[] arr = { "Apple", "Banana", "Melon", "Orange", "Grapes" };
        public void Display()
        {
            Console.Write("Enter the value to check:");
            string value="";
            value=Console.ReadLine();
            //TextInfo text=CultureInfo.CurrentCulture.TextInfo;
            //value = text.ToTitleCase(value.ToLower());
            //char c = value[0];
            //int n = (int)c;
            //if(c>=97 && c <= 122)
            //{
            //    n -= 32;
            //}
            //char c1 = (char)n;

            ////string str = value.Substring(1);
            //str = str.ToLower();
            //string value1=c1+str;
            char s = value[0];
            s = Char.ToUpper(s);
            value = value.Substring(1).ToLower();
            string value1 = s + value;
            //int num=Array.IndexOf(arr, value1);
            //if(num == -1)
            //{
            //    Console.WriteLine("Entered value is not present:");
            //}
            //else
            //{
            //    Console.WriteLine("Entered value is present and its index is:" + num);
            //}
        }
    }
}
