using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vezba3Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            string preZarezaBinarno = "";
            

            do {
                Console.WriteLine("Unesite decimalni broj");
                string unetiString = Console.ReadLine();
                if (unetiString =="kraj") break;
                int broj = Int32.Parse(unetiString);

                //pretvaranje u binarno 

                do
                {
                    if (broj % 2 == 0) preZarezaBinarno =  "0"+preZarezaBinarno;
                    else preZarezaBinarno = "1"+preZarezaBinarno;
                    broj /= 2;
                } while (broj > 0);


                //ispis
                Console.WriteLine("Binarno je: ");
                Console.Write(preZarezaBinarno);
                Console.WriteLine();
                preZarezaBinarno = "";


            } while (true);
            Console.WriteLine("-Kraj-");
        }
    }
}
