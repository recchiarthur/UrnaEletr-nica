using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletrônica
{
    public partial class InserirSenha : Form
    {
        public InserirSenha()
        {
            InitializeComponent();
        }

        public string senha;

        private void txtBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            senha = txtBoxSenha.Text;
            if(senha == "123")
            {
                ResultadosFinais resultadosFinais = new ResultadosFinais();
                resultadosFinais.Show();
            }
            else
            {
                MessageBox.Show("Senha incorreta!");
            }
        }
    }
}
