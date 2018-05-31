using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class LinearSearch
    {
        static void Main(string[] args)
        {
            int[] a = { 45, 30, 35, 50, 10 };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (a[i] > a[j])
                    {
                        var temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                        Console.WriteLine(+a[j]);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(+a[i]);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
