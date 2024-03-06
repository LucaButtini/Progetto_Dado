using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDadoConsole
{
    internal class Gara
    {
        Giocatore _g1, _g2;
        Dado _d1, _d2;
        int numeroRound, _roundMax;
        bool _fineGara, _pari;
        string _winner;
        public Gara(Giocatore g1, Giocatore g2, Dado d1, Dado d2, int roundMax)
        {
            _g1 = g1;
            _g2 = g2;
            _d1 = d1;
            _d2 = d2;
            numeroRound = 0;
            RoundMax = roundMax;
            FineGara = false;
            Pari = false;
        }
        public bool FineGara { get => _fineGara; private set => _fineGara = value; }
        public int NumeroRound { get => numeroRound; private set => numeroRound = value; }
        public int RoundMax { get => _roundMax; private set => _roundMax = value; }
        public bool Pari { get => _pari; private set => _pari = value; }
        public string Winner { get => _winner; private set => _winner = value; }
        public void Round()
        {
            for (int i = 0; i < RoundMax; i++)
            {
                if (_d1 > _d2)
                {
                    _g1.NVittorie++;
                }
                else if (_d1 < _d2)
                {
                    _g2.NVittorie++;
                }
                else // In caso di pareggio
                {
                    _g1.NVittorie++;
                    _g2.NVittorie++;
                }
                Console.WriteLine(_d1.FacciaDado);
                Console.WriteLine(_d2.FacciaDado);

                // Chiamiamo GameWin solo se abbiamo finito tutti i round
                if (i == RoundMax - 1)
                {
                    FineGara = true;
                    GameWin();
                }
            }
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
                    Winner = "Non ci sono vincitori";
                }
            }
            else
            {
                Winner = "Partita ancora in corso";
            }
        }

        public void ResetGame()// resetta la partita
        {//da vedere in visuale 
            _g1.NVittorie = 0;
            _g2.NVittorie = 0;
            numeroRound = 0;
        }
    }
}
