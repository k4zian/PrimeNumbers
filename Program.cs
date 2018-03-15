using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyPierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string yes = "TAK";
            string no = "NIE";

            Console.WriteLine("Wprowadzaj liczby całkowite celem sprawdzenia, czy są liczbami pierwszymi. Wprowadź 0, by zakończyć.");

            while (true)
            {
                n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    break;
                }

                if (n <= 3)
                {
                    Console.WriteLine(yes);
                }

                for(int i = 3; i < n; i++)
                {
                    if(n % i == 0)
                    {
                        Console.WriteLine(no);
                        break;
                    }

                    if (i == n - 1)
                    {
                        Console.WriteLine(yes);
                        break;
                    }
                }
            }
        }
    }
}
