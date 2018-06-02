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
            List<List<State>> earth = CreateCollection();
            Console.WriteLine("The list is successfully created!");

            int choice;
            do
            {
                Console.Clear();

                Console.WriteLine(@"Choose the query:
1. All the monarchs of the certain continent
2. All the states of the certain continent
3. The population of the certain continent
4. The average age of the certain continent states
5. The oldest state of the certain continent
6. Exit");

                choice = ChoiceInput(6);


            } while (choice != 6);

        }

        // Creating the collection.
        public static List<List<State>> CreateCollection()
        {
            // Getting all the continents counts.
            int africaCount = CountInput("Enter the number of African countries: ");
            int asiaCount = CountInput("Enter the number of Asian countries: ");
            int americaCount = CountInput("Enter the number of American countries: ");
            int oceaniaCount = CountInput("Enter the number of Oceanian countries: ");
            int europeCount = CountInput("Enter the number of European countries: ");

            // List of the african countries.
            List<State> africaList = new List<State>();
            for(int i = 0; i < africaCount; i++)
            {
                // Creating a random element.
                Monarchy monarchy = Monarchy.Generate(i);
                // Setting its continent.
                monarchy.Continent = "Africa";
                // Adding to the list the State cope of the object.
                africaList.Add(monarchy.BaseState);
            }

            // List of the asian countries.
            List<State> asiaList = new List<State>();
            for (int i = 0; i < asiaCount; i++)
            {
                // Creating a random element.
                Monarchy monarchy = Monarchy.Generate(i);
                // Setting its continent.
                monarchy.Continent = "Asia";
                // Adding to the list the State cope of the object.
                asiaList.Add(monarchy.BaseState);
            }

            // List of the american countries.
            List<State> americaList = new List<State>();
            for (int i = 0; i < americaCount; i++)
            {
                // Creating a random element.
                Monarchy monarchy = Monarchy.Generate(i);
                // Setting its continent.
                monarchy.Continent = "America";
                // Adding to the list the State cope of the object.
                americaList.Add(monarchy.BaseState);
            }

            // List of the oceanian countries.
            List<State> oceaniaList = new List<State>();
            for (int i = 0; i < oceaniaCount; i++)
            {
                // Creating a random element.
                Monarchy monarchy = Monarchy.Generate(i);
                // Setting its continent.
                monarchy.Continent = "Oceania";
                // Adding to the list the State cope of the object.
                oceaniaList.Add(monarchy.BaseState);
            }

            // List of the european countries.
            List<State> europeList = new List<State>();
            for (int i = 0; i < europeCount; i++)
            {
                // Creating a random element.
                Monarchy monarchy = Monarchy.Generate(i);
                // Setting its continent.
                monarchy.Continent = "Europe";
                // Adding to the list the State cope of the object.
                europeList.Add(monarchy.BaseState);
            }

            // Creating the Earth collection.
            List<List<State>> earth = new List<List<State>>
            {
                africaList, asiaList, americaList, oceaniaList, europeList
            };

            return earth;
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

        // Choice input.
        public static int ChoiceInput(int size)
        {
            bool ok;
            int choice;
            do
            {
                Console.Write("Enter the number of the chosen option: ");
                ok = Int32.TryParse(Console.ReadLine(), out choice);
                if (!ok || choice < 1 || choice > size)
                    Console.WriteLine("Input error! Perhaps you didn't enter a number from 1 to {0}", size);
            } while (!ok || choice < 1 || choice > size);

            return choice;
        }
    }
}
