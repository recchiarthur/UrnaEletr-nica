using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UrnaCorreta : Form
    {
        public UrnaCorreta()
        {
            InitializeComponent();
        }

        public List<string> votos = new List<string>(); 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text + textBox2.Text == "01")
            {
                labelNome.Text = "Irmão do Jorel";
                labelPartido.Text = "PIJ";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonConfirma_Click(object sender, EventArgs e)
        {
            votos.Add(textBox1.Text + textBox2.Text);
        }
    }
}
