using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            double Total=0;
            string[] texto = Console.ReadLine().Split(' ');
            int Cod = int.Parse(texto[0]), Qtd = int.Parse(texto[1]);

            if( Cod == 1)
            {
                Total = 4.00 * Qtd;

            }
            else if( Cod == 2)
            {
                Total = 4.50 * Qtd;
            }
            else if (Cod == 3)
            {
                Total = 5.00 * Qtd;
            }
            else if (Cod == 4)
            {
                Total = 2.00 * Qtd;
            }
            else if (Cod == 5)
            {
                Total = 1.50 * Qtd;
            }

            Console.WriteLine("Total: R$ " + Total.ToString("#0.00"));


            Console.ReadKey();


        }
    }
}
