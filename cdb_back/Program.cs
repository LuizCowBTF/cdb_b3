using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdb_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vf = 0;
                        
            Console.WriteLine("Informe o valor monetário aqui: ");
            int vi  = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de meses para aplicação: ");
            int tempo = int.Parse(Console.ReadLine());

            vf = vi * tempo;


            Console.WriteLine(vf);
            Console.ReadLine();


        }
    }
}
