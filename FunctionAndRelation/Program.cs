using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionAndRelation
{
    class Program
    {
        static void Main(string[] args)
        {
            //A
            string answ1 = "s";
            List<int> A = new List<int>();
            while (answ1 == "s")
            {
                Console.WriteLine("Introduzca el número del conjunto A");
                A.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Desea continuar? {s/n}");
                answ1 = Console.ReadLine();
            }
            Console.Clear();

            //B
            string answ3 = "s";
            List<int> B = new List<int>();
            while (answ3 == "s")
            {
                Console.WriteLine("Introduzca el número del conjunto B");
                B.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Desea continuar? {s/n}");
                answ3 = Console.ReadLine();
            }
            Console.Clear();

            //printear
            Console.WriteLine("A:");
            foreach (var x in A)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("B:");
            foreach (var x in B)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();

            //dominio
            string answ = "s";
            List<int> dominio = new List<int>();
            while (answ == "s")
            {
                Console.WriteLine("Introduzca el número del dominio");
                dominio.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Desea continuar? {s/n}");
                answ = Console.ReadLine();
            }
            Console.Clear();

            //rango
            string answ2 = "s";
            List<int> rango = new List<int>();
            while (answ2 == "s")
            {
                Console.WriteLine("Introduzca el número del rango");
                rango.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Desea continuar? {s/n}");
                answ2 = Console.ReadLine();
            }
            Console.Clear();

            //printear
            Console.WriteLine();
            Console.WriteLine("dominio:");
            foreach (var x in dominio)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("rango:");
            foreach (var x in rango)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine();

            //Algoritmo para determinar si es una relación o una función
            var a = A.All(dominio.Contains) && A.Count == dominio.Count;
            if (a)
            {
                Console.WriteLine("Es una relación");
                if(dominio.Count >= rango.Count)
                {
                    Console.WriteLine("Es una función");
                }
                else
                {
                    Console.WriteLine("No es una función");
                }

            }
            else { Console.WriteLine("No es una relación"); }
        }
    }
}
