using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiocoDado
{
    public partial class Form1 : Form
    {
        Gara gara;
        Giocatore g1, g2;
        int faccieDado = 6, nRound = 0, val1, val2;
        string nome1, nome2;
        string path = Environment.CurrentDirectory + "\\images_bin";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Vuoi uscire dal gioco?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nome1 = textBox2.Text;
            if (!CheckInserimento(nome1))
            {
                MessageBox.Show("Inserimento dati non valido o nullo", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            g1 = new Giocatore(nome1, new Dado());
            lblpl1.Text = g1.Nome;
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nome2 = textBox3.Text;
            if (!CheckInserimento(nome2))
            {
                MessageBox.Show("Inserimento dati non valido o nullo", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            g2 = new Giocatore(nome2, new Dado());
            lblpl2.Text = g2.Nome;
            textBox3.Clear();
        }
        private bool CheckInserimento(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }
            return true;
        }
        private bool CheckInserimentoInt(string input)
        {
            if (int.TryParse(input, out int result))
            {
                // Il parsing è riuscito, quindi è un numero intero valido
                return true;
            }
            else
            {
                // Il parsing non è riuscito, quindi non è un numero intero valido
                return false;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (CheckInserimentoInt(input))
            {
                nRound = int.Parse(input);
                lblround.Text = $"N° ROUND: {nRound}";
            }
            else
            {
                MessageBox.Show("Inserire un valore numerico intero valido", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Clear();
            }
            textBox1.Clear();
        }

        private async void rollbtn_Click(object sender, EventArgs e)
        {
            dice1img.Visible = true;
            dice2img.Visible = true;

            Random random = new Random();

            for (int i = 0; i < nRound; i++)
            {
                int randomNumber = random.Next(1, 7);

                switch (randomNumber)
                {
                    case 1:
                        dice1img.Image = Image.FromFile(path + "\\1.jpg");
                        dice2img.Image = Image.FromFile(path + "\\1.jpg");
                        break;
                    case 2:
                        dice1img.Image = Image.FromFile(path + "\\2.jpg");
                        dice2img.Image = Image.FromFile(path + "\\2.jpg");
                        break;
                    case 3:
                        dice1img.Image = Image.FromFile(path + "\\3.jpg");
                        dice2img.Image = Image.FromFile(path + "\\3.jpg");
                        break;
                    case 4:
                        dice1img.Image = Image.FromFile(path + "\\4.jpg");
                        dice2img.Image = Image.FromFile(path + "\\4.jpg");
                        break;
                    case 5:
                        dice1img.Image = Image.FromFile(path + "\\5.jpg");
                        dice2img.Image = Image.FromFile(path + "\\5.jpg");
                        break;
                    case 6:
                        dice1img.Image = Image.FromFile(path + "\\6.jpg");
                        dice2img.Image = Image.FromFile(path + "\\6.jpg");
                        break;
                }
                await Task.Delay(500);
            }
            PlayGame();
        }
        private void DiceFace1(int val)
        {
            switch (val)
            {
                case 1:
                    dice1img.Image = Image.FromFile(path + "\\1.jpg");
                    break;
                case 2:
                    dice1img.Image = Image.FromFile(path + "\\2.jpg");
                    break;
                case 3:
                    dice1img.Image = Image.FromFile(path + "\\3.jpg");
                    break;
                case 4:
                    dice1img.Image = Image.FromFile(path + "\\4.jpg");
                    break;
                case 5:
                    dice1img.Image = Image.FromFile(path + "\\5.jpg");
                    break;
                case 6:
                    dice1img.Image = Image.FromFile(path + "\\6.jpg");
                    break;
            }
        }
        private void DiceFace2(int val)
        {
            switch (val)
            {
                case 1:
                    dice2img.Image = Image.FromFile(path + "\\1.jpg");
                    break;
                case 2:
                    dice2img.Image = Image.FromFile(path + "\\2.jpg");
                    break;
                case 3:
                    dice2img.Image = Image.FromFile(path + "\\3.jpg");
                    break;
                case 4:
                    dice2img.Image = Image.FromFile(path + "\\4.jpg");
                    break;
                case 5:
                    dice2img.Image = Image.FromFile(path + "\\5.jpg");
                    break;
                case 6:
                    dice2img.Image = Image.FromFile(path + "\\6.jpg");
                    break;
            }
        }
        private void dice1img_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Partita resettata", "Game", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            gara.ResetGame();
            rispl1.Text = $"{g1.Nome}: {0} vittorie";
            rispl2.Text = $"{g2.Nome}: {0} vittorie";
            risround.Text = $"Round: {0}/{gara.RoundMax}";
            risstato.Text = "Partita ancora da iniziare";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (g1 == null || g2 == null || nRound == 0)
            {
                MessageBox.Show("Inserimento dati non valido o nullo", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (gara == null)
            {
                try
                {
                    gara = new Gara(g1, g2, nRound, faccieDado);
                }
                catch (Exception)
                {
                    gara = null;
                    MessageBox.Show("Errore creazione gara", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La gara è già stata creata.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            AttivaCampoGioco();
        }

        private void AttivaCampoGioco()
        {
            pictureBox1.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            rispl1.Visible = true;
            rispl2.Visible = true;
            risround.Visible = true;
            risstato.Visible = true;
            rollbtn.Visible = true;
            resultsbox.Visible = true;
            resetbtn.Visible = true;
        }
        private void PlayGame()
        {

            if (gara.FineGara)
            {
                MessageBox.Show("La gara è finita, esci o resetta la partita", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                val1 = gara.Roll();
                val2 = gara.Roll();
                gara.Round(val1, val2);
                DiceFace1(val1);
                DiceFace2(val2);
                UpdateInterfaccia();
            }
        }

        private void UpdateInterfaccia()
        {
            rispl1.Text = $"{g1.Nome}: {g1.NVittorie} vittorie";
            rispl2.Text = $"{g2.Nome}: {g2.NVittorie} vittorie";
            risround.Text = $"Round: {gara.NumeroRound}/{gara.RoundMax}";
            risstato.Text = gara.Winner;
        }
    }
}
