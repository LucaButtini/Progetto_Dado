using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDadoConsole
{
    internal class Dado
    {
        int faccie, numero;
        Random rnd;
        public Dado(int _faccie)
        {
            rnd = new Random();
            faccie = _faccie;
            numero = rnd.Next(1, 7);
        }
        public int Faccie { get => faccie; set => faccie = value; }
        public int Numero { get => numero; set => numero = value; }
        public string ScriviDado()
        {
            return ($"Numero faccie: {Faccie}, numero: {Numero}");
        }
    }
}
