﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDado
{
    internal class Dado
    {
        int _facciaDado;

        public int FacciaDado { get => _facciaDado; set => _facciaDado = value; }

        public Dado()
        {
            _facciaDado = 0;
        }
        //operatori per il confronto delle facce dei dadi
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
