using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150519_04
{
    class Program
    {
        //public string word { get; set; }
        static void Main(string[] args)
        { 
            Game(); 
        }

        public static void Game()
        {
            int nihushimim = 0;
            int hazlaha = 0;
            string country = RandomCountry(Countries.Countries1);
            while (hazlaha < country.Length)
            {
                string Letter = Console.ReadLine();
                Console.WriteLine();
                nihushimim++;
                for (int i = 0; i < country.Length; i++)
                {
                    if (country[i] == Letter[0])
                    {
                        Console.Write(" ");
                        Console.Write(country[i]);
                        Console.Write(" ");
                        hazlaha++;
                    }
                    else
                    {
                        Console.Write(" _ ");
                    } 
                }
                Console.WriteLine();
            }
            if (hazlaha == country.Length)
            {
                Console.WriteLine();
                Console.WriteLine("Good work");
                Console.WriteLine(country);                
                Console.WriteLine($"number of Guessings: {nihushimim}");
            }
            Console.WriteLine("new game? Y/N");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                Game();
            }
            else
            {
                Console.WriteLine("by by");
            }
        }

        public static string RandomCountry(List<string> Countries)
        {
            Random rnd = new Random();
            int r = rnd.Next(5);
            //Console.WriteLine(Countries[r]);            
            for (int i = 0; i < Countries[r].Length; i++)
            {
                Console.Write(" _ ");
            }
            Console.WriteLine();
            return Countries[r];            
        }
    }
}
