using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDadoConsole
{
    internal class Dado
    {
        Random rnd;
        public Dado()
        {
            rnd = new Random();
        }
        public int LancioDado()
        {
            return rnd.Next(1, 7);
        }
        public string ScriviDado() //metodo di prova
        {
            return ($"numero: {LancioDado()}");
        }
    }
}
