using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deretan_Bilangan_Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            int bilangan;
            Console.Write("masukan bilangan : ");
            bilangan = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            Console.WriteLine();
            Console.Write("bilangan prima dari 1 s/d {0} adalah", bilangan);
            for (int i = 1; i <= bilangan; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        temp += 1;
                    }
                }
                if (temp == 2)
                {
                    Console.Write(i + " ");
                }
                temp = 0;
            }
            Console.ReadLine();
        }
    }
}
