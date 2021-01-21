using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj");
            while (true)
            {

                try
                {

                    Console.WriteLine("Wprowadź proszę dowolną liczbę. Program poda komunikat, czy jest to liczba parzysta bądź nieparzysta.");

                    int userNumber = int.Parse(Console.ReadLine());

                    if (userNumber % 2 == 0)
                    {
                        Console.WriteLine("Liczba " + userNumber + " jest parzysta.");
                    }

                    else
                    {
                        Console.WriteLine("Liczba " + userNumber + " jest nieparzysta.");
                    }
                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Podana wartość jest niewłaściwa!");
                }

            }
        }
    }
}

