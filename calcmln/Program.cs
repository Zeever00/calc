﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcmln
{
    class Program
    {
        static void Main(string[] args)
        {
            bool abc = true;
            while (abc)
            {
                Console.WriteLine("87. Wyjscie");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnozenie");
                Console.WriteLine("4. Divide");
                int menuOption = Convert.ToInt32(Console.ReadLine());
                int numberOne = Convert.ToInt32(Console.ReadLine());


                switch (menuOption)
                {
                    case 0:
                        abc = false;
                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Nie znam tego");
                        break;
                }
            }
        }
    }
}
