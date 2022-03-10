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
using WinFormsApp1;

namespace UrnaEletrônica
{
    public partial class ResultadosFinais : Form
    {
        public ResultadosFinais()
        {
            InitializeComponent();
        }

        private void ResultadosFinais_Load(object sender, EventArgs e)
        {
            UrnaCorreta urnaCorreta = new UrnaCorreta();
            labelIrmJorel.Text = UrnaCorreta.votosIrmJorel.ToString();
            labelVovoJuju.Text = UrnaCorreta.votosVovoJuju.ToString();
            labelJorel.Text = UrnaCorreta.votosJorel.ToString();
            labelGesonel.Text = UrnaCorreta.votosGesonel.ToString();
            labelAnaCat.Text = UrnaCorreta.votosAnaCat.ToString();
            
        }
    }
}
