using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {

           
            string nome = "";
            Console.WriteLine("Hello, who are you?");
            Console.Write("my names is ");
            nome = Console.ReadLine();
            Console.Write("Welcome,");
            Console.WriteLine(nome);
            Console.WriteLine("Choose a number for your day");
            int numero = int.Parse(Console.ReadLine());
            
            //swith case | laço de reptição (do while)// 

            if (numero == 1)
            {
                Console.WriteLine("your day is sunday");
            }
            else if (numero == 2)
            {
                Console.WriteLine("your day is Monday");
            }
            else if (numero == 3)
            {
                Console.WriteLine("your day is tuesday");
            }
            else if (numero == 4)
            {
                Console.WriteLine("your day is wednesday");
            }
            else if (numero == 5)
            {
                Console.WriteLine("your day is thursday");
            }
            else if (numero == 6)
            {
                Console.WriteLine("your day is friday");
            }
            else if (numero == 7)
            {
                Console.WriteLine("your day is saturday");
            }
            
            Console.WriteLine("goodbey");
            Console.ReadLine();
                      
        }

    }
}
