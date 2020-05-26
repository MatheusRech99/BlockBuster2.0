using System;
using System.Windows.Forms;
using BlockBuster.Models;

namespace BlockBuster.Views {
    public partial class TelaCadastroFilme : Form {
        public TelaCadastroFilme() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (double.TryParse(precoTb.Text, out double preco)) {
                _ = new FilmeModels(tituloRtb.Text, sinopseTb.Text, dataLancamentoMtb.Text, preco, (int) estoqueNum.Value);
                this.Close();
            }
            else {
                MessageBox.Show("O campo preço precisa ser um numero válido!", "Preco Exception", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}