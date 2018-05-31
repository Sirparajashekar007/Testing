using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int[] a = { 10, 5, 1, 15 };
            ////Console.WriteLine("Please enter input");
            ////int b = Convert.ToInt32(Console.ReadLine());
            ////for (int i = 0; i < a[i] - 1; i++)
            ////{
            ////    if (a[i] == b)
            ////    {
            ////        Console.WriteLine("the given number {0} found out at the location {1}", a[i], i);
            ////        Console.ReadLine();
            ////    }
            ////}
            ////int a = 1, b = 0;
            ////try
            ////{
            ////    int c = a / b;
            ////}
            ////catch (Exception ex)
            ////{
            ////    throw new ExceptionClass(ex.Message);
            ////}
            EmpDetails obj = new EmpDetails(1, "Rajashekar Sirpa", "+ve", 9676952689, "Kondapur");
            obj.EmpDetails1(true);
        }
    }
}
