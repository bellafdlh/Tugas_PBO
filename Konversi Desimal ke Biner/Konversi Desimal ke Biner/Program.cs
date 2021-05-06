using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konversi_Desimal_ke_Biner
{
    class Program
    {
        static void Main(string[] args)
        {
            int desimal, sisa;
            Console.Write("Bilangan Desimal :");
            desimal = Convert.ToInt32(Console.ReadLine());
            string hasil= "";
            while (desimal > 0)
            {
                sisa = desimal % 2;
                desimal /= 2;
                hasil = sisa.ToString() + hasil;
            }
            Console.WriteLine("Bilangan Biner : {0}", hasil);
            Console.ReadLine();
        }
    }
}
