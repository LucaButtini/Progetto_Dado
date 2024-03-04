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
            Dado dado = new Dado();
            Gara gara = new Gara(new Giocatore("lucio"), new Giocatore("lucy"), new Dado());
           
            Console.ReadLine();
        }
    }
}
