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
            int tal, sum = 0;

            for (int i = 0; i < 10; i++)
            {
                tal = randomerare.Next(20) + 1;
                Console.Write(tal + "  ");
                sum = tal + sum;
            }

            int medel = sum / 10;
            Console.WriteLine("Medelvärdet blev " + medel);
        }
    }
}
