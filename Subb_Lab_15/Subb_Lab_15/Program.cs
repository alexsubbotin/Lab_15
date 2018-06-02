using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subb_Lab_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Earth list.
            List<List<State>> earth = new List<List<State>>();

            int africaCount = CountInput("Enter the number of African countries: ");
            int asiaCount = CountInput("Enter the number of Asian countries: ");
            int americaCount = CountInput("Enter the number of American countries: ");
            int oceaniaCount = CountInput("Enter the number of Oceanian countries: ");
            int europeCount = CountInput("Enter the number of European countries: ");

        }

        public static int CountInput(string s)
        {
            bool ok;
            int n;
            do
            {
                Console.WriteLine(s);
                ok = Int32.TryParse(Console.ReadLine(), out n);
                if (!ok || n < 0)
                    Console.WriteLine("Input error! Perhaps you didn't enter a natural number");
            } while (!ok || n < 0);

            return n;
        }
    }
}
