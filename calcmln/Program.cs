using System;
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
                Console.WriteLine("1. ADD");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("4. Mnozenie");
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
                    default:
                        Console.WriteLine("Nie znam tego");
                        break;
                }
            }
        }
    }
}
