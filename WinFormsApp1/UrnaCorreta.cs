using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaEletrônica;

namespace WinFormsApp1
{
    public partial class UrnaCorreta : Form
    {
        public UrnaCorreta()
        {
            InitializeComponent();
        }

        public List<string> votos = new List<string>();
        public static int votosIrmJorel, votosJorel, votosVovoJuju, votosAnaCat, votosGesonel, votosNulo;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string numVoto = textBox1.Text + textBox2.Text;
            if (numVoto == "01")
            {
                labelNome.Text = "Irmão do Jorel";
                labelPartido.Text = "PIJ";
                pictureIrmJorel.Show();
            }
            else if (numVoto == "02")
            {
                labelNome.Text = "Vovó Juju";
                labelPartido.Text = "PABC";
                pictureVovoJuju.Show();
            }
            else if (numVoto == "03")
            {
                labelNome.Text = "Jorel";
                labelPartido.Text = "PdJL";
                pictureJorel.Show();
            }
            else if (numVoto == "04")
            {
                labelNome.Text = "Gesonel";
                labelPartido.Text = "PGMD";
                pictureGesonel.Show();
            }
            else if (numVoto == "05")
            {
                labelNome.Text = "Ana Catarina";
                labelPartido.Text = "PdAC";
                pictureAnaCat.Show();
            }
            else
            {
                labelNome.Text = "VOTO NULO!";
                votosNulo++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox2.Text = "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox2.Text = "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox2.Text = "3";
            }
        }

        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox2.Text = "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox2.Text = "5";
            }
        }

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox2.Text = "6";
            }
        }

        private void buttonSete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox2.Text = "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox2.Text = "8";
            }
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox2.Text = "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox2.Text = "0";
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            labelNome.Text = "";
            labelPartido.Text = "";
            pictureIrmJorel.Hide();
            pictureVovoJuju.Hide();
            pictureJorel.Hide();
            pictureGesonel.Hide();
            pictureAnaCat.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelNome.Text = "VOTO EM BRANCO!";
            for(int i = 0; i < votos.Count; i++)
            {
                int votosNum = int.Parse(votos[i]);
                if (int.Parse(votos[i]) > int.Parse(votos[0]) &&
                   int.Parse(votos[i]) > int.Parse(votos[1]) &&
                   int.Parse(votos[i]) > int.Parse(votos[2]) &&
                   int.Parse(votos[i]) > int.Parse(votos[3]) &&
                   int.Parse(votos[i]) > int.Parse(votos[4]))
                    votosNum++;
            }
        }

        private void buttonConfirma_Click(object sender, EventArgs e)
        {
            votos.Add(textBox1.Text + textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            labelNome.Text = "";
            labelPartido.Text = "";
            pictureIrmJorel.Hide();
            pictureVovoJuju.Hide();
            pictureJorel.Hide();
            pictureGesonel.Hide();
            pictureAnaCat.Hide();
        }

        private void UrnaCorreta_Load(object sender, EventArgs e)
        {
            pictureIrmJorel.Hide();
            pictureVovoJuju.Hide();
            pictureJorel.Hide();
            pictureGesonel.Hide();
            pictureAnaCat.Hide();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            InserirSenha inserirSenha = new InserirSenha();
            inserirSenha.Show();
            for (int i = 0; i < 5; i++)
            {
                if(votos[i] == "01")
                {
                    votosIrmJorel++;
                }
                else if(votos[i] == "02")
                {
                    votosVovoJuju++;
                }
                else if(votos[i] == "03")
                {
                    votosJorel++;
                }
                else if(votos[i] == "04")
                {
                    votosGesonel++;
                }
                else if(votos[i] == "05")
                {
                    votosAnaCat++;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
