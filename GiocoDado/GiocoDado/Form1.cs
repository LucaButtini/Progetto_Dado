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
        int faccieDado = 6, nRound = 0;
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
            label7.Text = nome1;
            g1 = new Giocatore(nome1, new Dado());
            nomi.Items.Add(g1.ToString());
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
            label8.Text = nome2;
            g2 = new Giocatore(nome2, new Dado());
            nomi.Items.Add(g2.ToString());
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
                nomi.Items.Add((int)nRound);
            }
            else
            {
                MessageBox.Show("Inserire un valore numerico intero valido", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Clear();
            }
            textBox1.Clear();
        }

        private void rollbtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {

                switch (random.Next(1, 7))
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
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void dice1img_Click(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Gara creata con successo!", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dice1img.Visible = true;
            dice2img.Visible = true;
            rollbtn.Visible = true;
        }
    }
}
