using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilias_tiene_un_pozo_petrolero_por_ano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 8.95371;
            int n = -1;
            Console.WriteLine(MyPow(x,n));
            Console.ReadLine();
        }

        public static double MyPow(double x, int n)
        {
            double potencia = 0;
            double p = x;
            if(n == 0)
            {
                return 1;
            }

            if (n > 0)
            {
                for (int i = 1; i < n; i++)
                {
                    potencia = p * x;
                    p = potencia;
                }
            }
            else
            {
                for (int i = -1; i > n; i--)
                {
                    potencia = p * x;
                    p = potencia;
                }
                potencia = 1/potencia;
            }

            return potencia;
        }
    }
}
