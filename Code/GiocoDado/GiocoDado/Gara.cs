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
        bool _fineGara;
        string _winner;
        public Gara(Giocatore g1, Giocatore g2, int roundMax, int faccieEstrazioneDado)
        {
            _g1 = g1;
            _g2 = g2;
            numeroRound = 0;
            RoundMax = roundMax;
            FineGara = false;
            FaccieEstrazioneDado = faccieEstrazioneDado;
        }
        public bool FineGara { get => _fineGara; private set => _fineGara = value; }
        public int NumeroRound { get => numeroRound; private set => numeroRound = value; }
        public int RoundMax { get => _roundMax; set => _roundMax = value; }
        public string Winner { get => _winner; private set => _winner = value; }
        public int FaccieEstrazioneDado { get => _faccieEstrazioneDado; set => _faccieEstrazioneDado = value; }
        public int Roll()
        {
            //metodo che estrae una faccia casuale del dado
            return rnd.Next(1, FaccieEstrazioneDado + 1);
        }
        public void Round(int val1, int val2)
        {
            //esegue un round della partita
            //i valori della facce del dado sono confrontati con gli operatori
            NumeroRound++;
            if (NumeroRound == RoundMax)
            {
                FineGara = true;

            }
            _g1.Dado.FacciaDado = val1;
            _g2.Dado.FacciaDado = val2;
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
            GameWin();
        }
        private void GameWin()
        {
            //metodo che assegna alla proprietà Winner il valore corretto in base alle vittorie dei giocatori o se la partità è ancora in corso
            if (FineGara)
            {
                if (_g1.NVittorie > _g2.NVittorie)
                {
                    Winner = $"Winner: {_g1.Nome}, The game has finished";
                }
                else if (_g1.NVittorie < _g2.NVittorie)
                {
                    Winner = $"Winner: {_g2.Nome}, The game has finished";
                }
                else
                {
                    Winner = "There are no winners, The game has finished";
                }
            }
            else
            {
                Winner = "The game is still running";
            }
        }
        public void ResetGame()
        {
            //resetto la partita in corso
            _g1.NVittorie = 0;
            _g2.NVittorie = 0;
            numeroRound = 0;
            FineGara = false;
            Winner = null;
        }

    }
}
