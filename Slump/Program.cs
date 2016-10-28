using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slump
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmet slumpar fram 10 tal mellan 1-20 och beräknar medelvärdet.");
            Random randomerare = new Random();

            for (int i = 0; i < 10; i++)
            {
                int tal = randomerare.Next(20) + 1;
                Console.Write(tal + "  "); 
            }

        }
    }
}
