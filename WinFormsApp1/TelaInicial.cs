namespace WinFormsApp1
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void buttonUrnaCorreta_Click(object sender, EventArgs e)
        {
            UrnaCorreta urnaCorreta = new UrnaCorreta();
            urnaCorreta.Show();
        }

        private void buttonUrnaFalsa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Urna falsa ainda n�o dispon�vel");
        }
    }
}