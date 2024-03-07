using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDadoConsole
{
    internal class Program
    {
        static void Main()
        {
            Giocatore g1 = new Giocatore("g1", new Dado());
            Giocatore g2 = new Giocatore("g2", new Dado());
            Gara gara = new Gara(g1, g2, 3, 6);
            while (!gara.FineGara)
            {
                gara.Round();
            }
            gara.ResetGame();
            Console.WriteLine(gara.Winner);
            Console.ReadLine();
        }
    }
}
