using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDadoConsole
{
    internal class Giocatore
    {
        string _nome;
        int _nVittorie;
        public Giocatore(string nome)
        {
            _nome = nome;
            _nVittorie = 0;
            
        }
        public string Nome { get => _nome; set => _nome = value; }

        public int NVittorie { get => _nVittorie; set => _nVittorie = value; }
        public string Scrivi()
        {
            return $"nome: {Nome}, vittorie: {NVittorie}";
        }
    }
}
