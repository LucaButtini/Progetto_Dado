using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDado
{
    internal class Gara
    {
        Random rnd = new Random(DateTime.Now.Millisecond);
        Giocatore _g1, _g2;
        int numeroRound, _roundMax, _faccieEstrazioneDado;
        bool _fineGara, _pari;
        string _winner;
        public Gara(Giocatore g1, Giocatore g2, int roundMax, int faccieEstrazioneDado)
        {
            _g1 = g1;
            _g2 = g2;
            numeroRound = 0;
            RoundMax = roundMax;
            FineGara = false;
            Pari = false;
            FaccieEstrazioneDado = faccieEstrazioneDado;
        }
        public bool FineGara { get => _fineGara; private set => _fineGara = value; }
        public int NumeroRound { get => numeroRound; private set => numeroRound = value; }
        public int RoundMax { get => _roundMax; set => _roundMax = value; }
        public bool Pari { get => _pari; private set => _pari = value; }
        public string Winner { get => _winner; private set => _winner = value; }
        public int FaccieEstrazioneDado { get => _faccieEstrazioneDado; set => _faccieEstrazioneDado = value; }
        public int Roll()
        {
            return rnd.Next(1, FaccieEstrazioneDado + 1);
        }
        public void Round()
        {

            _g1.Dado.FacciaDado = Roll();
            _g2.Dado.FacciaDado = Roll();

            if (_g1.Dado > _g2.Dado)
            {
                _g1.NVittorie++;
            }
            else if (_g1.Dado < _g2.Dado)
            {
                _g2.NVittorie++;
            }
            else
            {
                _g1.NVittorie++;
                _g2.NVittorie++;
            }
            NumeroRound++;
            
            if (NumeroRound == RoundMax)
            {
                FineGara = true;
                
            }
            GameWin();
        }
        private void GameWin()
        {
            if (FineGara)
            {
                if (_g1.NVittorie > _g2.NVittorie)
                {
                    Winner = $"Vincitore: {_g1.Nome}, Stato Partita: Terminata";
                }
                else if (_g1.NVittorie < _g2.NVittorie)
                {
                    Winner = $"Vincitore: {_g2.Nome}, Stato Partita: Terminata";
                }
                else
                {
                    Winner = "Non ci sono vincitori, Stato Partita: Terminata";
                }
            }
            else
            {
                Winner = "Partita ancora in corso";
            }
        }
        public void ResetGame()
        {
            _g1.NVittorie = 0;
            _g2.NVittorie = 0;
            numeroRound = 0;
        }
    }
}
