using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            Console.WriteLine("Entre com dois valores: ");
            Console.Write("Digite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());
            do
            {
                
                Console.Write("Digite o segundo valor: ");
                n2 = int.Parse(Console.ReadLine()); 

            }
            while (n1 >= n2);
        }
    }
}
