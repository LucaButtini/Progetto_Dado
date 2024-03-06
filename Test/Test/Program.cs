using System;

class Gara
{
    private Giocatore giocatore1;
    private Giocatore giocatore2;
    private Dado dado;
    private int numeroRound;
    private int roundCorrente;

    public Gara(string nomeGiocatore1, string nomeGiocatore2, int numeroRound)
    {
        giocatore1 = new Giocatore(nomeGiocatore1);
        giocatore2 = new Giocatore(nomeGiocatore2);
        dado = new Dado();
        this.numeroRound = numeroRound;
        roundCorrente = 0;
    }

    public bool FineGara
    {
        get
        {
            return roundCorrente >= numeroRound;
        }
    }

    public string Winner
    {
        get
        {
            if (!FineGara)
            {
                return "Partita in corso";
            }

            if (giocatore1.GareVinte > giocatore2.GareVinte)
            {
                return giocatore1.Nome;
            }
            else if (giocatore1.GareVinte < giocatore2.GareVinte)
            {
                return giocatore2.Nome;
            }
            else
            {
                return "Parità";
            }
        }
    }

    public void Round()
    {
        if (!FineGara)
        {
            // Utilizzo degli operatori di confronto nella classe Dado
            if (dado > dado)
            {
                giocatore1.IncrementaGareVinte();
            }
            else if (dado < dado)
            {
                giocatore2.IncrementaGareVinte();
            }
            else
            {
                giocatore1.IncrementaGareVinte();
                giocatore2.IncrementaGareVinte();
            }

            roundCorrente++;
            GameWin();
        }
        else
        {
            Console.WriteLine("La partita è già finita.");
        }
    }



    private void GameWin()
    {
        if (FineGara)
        {
            Console.WriteLine("Fine della partita. Vincitore: " + Winner);
        }
    }

    public void ResetGame()
    {
        roundCorrente = 0;
        giocatore1.ResetGareVinte();
        giocatore2.ResetGareVinte();
        Console.WriteLine("Partita resettata.");
    }
}


class Dado
{
    private Random random;

    public Dado()
    {
        random = new Random();
    }

    public int LanciaDado()
    {
        return random.Next(1, 7); // Valori da 1 a 6 come un dado normale
    }

    // Operatori di confronto tra due oggetti Dado
    public static bool operator >(Dado dado1, Dado dado2)
    {
        return dado1.LanciaDado() > dado2.LanciaDado();
    }

    public static bool operator <(Dado dado1, Dado dado2)
    {
        return dado1.LanciaDado() < dado2.LanciaDado();
    }
}


class Giocatore
{
    private string nome;
    private int gareVinte;

    public Giocatore(string nome)
    {
        this.nome = nome;
        gareVinte = 0;
    }

    public string Nome
    {
        get { return nome; }
    }

    public int GareVinte
    {
        get { return gareVinte; }
    }

    public void IncrementaGareVinte()
    {
        gareVinte++;
    }

    public void ResetGareVinte()
    {
        gareVinte = 0;
    }
}

// Esempio di utilizzo
class Program
{
    static void Main()
    {
        Gara gara = new Gara("Giocatore1", "Giocatore2", 5);

        while (!gara.FineGara)
        {
            gara.Round();
        }

        gara.ResetGame();
        Console.ReadLine();
    }
}
