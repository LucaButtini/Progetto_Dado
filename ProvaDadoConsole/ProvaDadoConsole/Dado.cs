using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDadoConsole
{
    internal class Dado
    {
        int _facciaDado;

        public int FacciaDado { get => _facciaDado; set => _facciaDado = value; }

        public Dado()
        {
            _facciaDado = 0;
        }
        static public bool operator >(Dado dado1, Dado dado2)
        {
            return (dado1.FacciaDado > dado2.FacciaDado);
        }
        static public bool operator <(Dado dado1, Dado dado2)
        {
            return (dado1.FacciaDado < dado2.FacciaDado);
        }
        static public bool operator ==(Dado dado1, Dado dado2)
        {
            return dado1.FacciaDado == dado2.FacciaDado;
        }
        static public bool operator !=(Dado dado1, Dado dado2)
        {
            return !(dado1.FacciaDado == dado2.FacciaDado);
        }
    }
}