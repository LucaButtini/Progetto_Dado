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
        int numeroG1, numeroG2, numeroRound;
        bool _fineGara;
        string _winner;

        public bool FineGara { get => _fineGara; set => _fineGara = value; }
        public string Winner { get => _winner; set => _winner = value; }
        public int NumeroG1 { get => numeroG1; set => numeroG1 = value; }
        public int NumeroG2 { get => numeroG2; set => numeroG2 = value; }
        public int NumeroRound { get => numeroRound; set => numeroRound = value; }

        public Gara(Giocatore g1, Giocatore g2, Dado d, int numeroRound)
        {
            _g1 = g1;
            _g2 = g2;
            _d = d;
            NumeroG1 = 0;
            NumeroG2 = 0;
            NumeroRound = numeroRound;
        }

        //queste sono proprietà (come facciamo rondo?)


        public void Round()//esegue un round della partita
        {
        }
        private void GameWin()// se la partita è finita determina il vincitore o la
                              // condizione di parità
        {
        }
        public void ResetGame()// resetta la partita
        {
        }
    }
}
