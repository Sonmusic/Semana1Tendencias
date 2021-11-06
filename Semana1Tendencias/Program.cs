using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 2 SnakeCase
            List<string> stringArray1 = new List<string>();
            Console.WriteLine("Introduce una palabra:");
            stringArray1.Add(Console.ReadLine());
            Console.WriteLine("Introduce otra palabra:");
            stringArray1.Add(Console.ReadLine());
            string concatenated ="";
            string converted;
            string separator = "";
            foreach (string x in stringArray1)
            {
                converted = string.Empty;
                foreach (char c in x)
                {
                    converted += (Char.ToLower(c));
                }
                concatenated += separator + (converted);
                separator = "_";
            }
            Console.WriteLine("SnakeCase: " + concatenated);
        }
    }
}
