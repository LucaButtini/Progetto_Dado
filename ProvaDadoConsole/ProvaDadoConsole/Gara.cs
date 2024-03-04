using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDadoConsole
{
    internal class Gara
    {
        Giocatore _g1, _g2;
        Dado _d;
        int numeroG1, numeroG2, numeroRound, _roundMax;
        bool _fineGara;
        string _winner;
        public Gara(Giocatore g1, Giocatore g2, Dado d, int roundMax)
        {
            _g1 = g1;
            _g2 = g2;
            _d = d;
            NumeroG1 = 0;
            NumeroG2 = 0;
            numeroRound = 0;
            RoundMax = roundMax;
            FineGara = false;
        }
        //queste sono proprietà (come facciamo rondo?)
        //--------------------------------------------------------
        public bool FineGara { get => _fineGara; set => _fineGara = value; }
        public string Winner { get => _winner; set => _winner = value; }
        //-------------------------------------------------------

        public int NumeroG1 { get => numeroG1; private set => numeroG1 = value; }
        public int NumeroG2 { get => numeroG2; private set => numeroG2 = value; }
        public int NumeroRound { get => numeroRound; private set => numeroRound = value; }
        public int RoundMax { get => _roundMax; private set => _roundMax = value; }
        public void Round()//esegue un round della partita
        {
            NumeroG1 = _d.LancioDado();
            NumeroG2 = _d.LancioDado();
            Console.WriteLine(NumeroG1);
            Console.WriteLine(NumeroG2);
            if (NumeroG1 > NumeroG2)
            {
                _g1.NVittorie++;
            }
            else if (NumeroG2 > NumeroG1)
            {
                _g2.NVittorie++;
            }
            else //facciamo che se è pareggio aumentiamo tutte e due le vittorie?
            {
                _g1.NVittorie++;
                _g2.NVittorie++;
            }
            NumeroRound++;
            if (NumeroRound == RoundMax)
            {
                ResetGame();
                FineGara = true;
            }

        }
        private void GameWin()// se la partita è finita determina il vincitore o la condizione di parità
        {
            if (FineGara)
            {
                //utilizzare la proprietà winner in qualche modo
            }

        }
        public void ResetGame()// resetta la partita
        {
            _g1.NVittorie = 0;
            _g2.NVittorie = 0;
            numeroRound = 0;
        }
    }
}
