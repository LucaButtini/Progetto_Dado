using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDadoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dado dado = new Dado(4);
            Console.WriteLine(dado.ScriviDado());
            Console.ReadLine();
        }
    }
}
