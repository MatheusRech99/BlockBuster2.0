using System;
using System.Windows.Forms;
using BlockBuster.Views;

namespace BlockBuster {
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            TelaCadastroCliente TeladeCadastroCliente = new TelaCadastroCliente();
            TeladeCadastroCliente.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void button10_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            TelaConsultaCliente TeladeConsultaCliente = new TelaConsultaCliente();
            TeladeConsultaCliente.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e) {
            TelaListaFilme TeladeListaFilme = new TelaListaFilme();
            TeladeListaFilme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            TelaListaCliente TeladeListarCliente = new TelaListaCliente();
            TeladeListarCliente.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) {
            TelaCadastroFilme TeladeCadastroFilme = new TelaCadastroFilme();
            TeladeCadastroFilme.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e) {
            TelaConsultaFilme TeladeConsultaFilme = new TelaConsultaFilme();
            TeladeConsultaFilme.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e) {
            TelaCadastroLocacao TelaCadastroLocacao = new TelaCadastroLocacao();
            TelaCadastroLocacao.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e) {
            TelaListaLocacao TelaListaLocacao = new TelaListaLocacao();
            TelaListaLocacao.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e) {
            TelaConsultaLocacao TelaConsultaLocacao = new TelaConsultaLocacao();
            TelaConsultaLocacao.ShowDialog();
        }
    }
}