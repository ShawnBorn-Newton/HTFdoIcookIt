# HTFdoIcookIt
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace proofofconseptFOOD
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\VariablesAndOperators\chickenSoup.txt"))
            {
                List<string> recipe = new List<string>();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    recipe.Add(line);

                }
                    if(recipe.IndexOf("simmer") != 0)
                {
                    Console.WriteLine("Cover with cold water.\nPlace over medium-high heat untile water serfice starts to move.\nLower to medium-low heat until small slow boubles form.");
                }
            }
        }
    }
}
