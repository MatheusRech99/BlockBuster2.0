using System;
using System.Windows.Forms;
using BlockBuster.Controllers;
using BlockBuster.Models;

namespace BlockBuster.Views {
    public partial class TelaCadastroFilme : Form {
        private FilmeModels filme;

        public TelaCadastroFilme() {
            InitializeComponent();
        }

        public TelaCadastroFilme(FilmeModels filme) {
            InitializeComponent();
            this.filme = filme;
            tituloRtb.Text = filme.Titulo;
            sinopseTb.Text = filme.Sinopse;
            dataLancamentoMtb.Text = filme.DataLancamento;
            precoTb.Text = filme.Preco.ToString();
            estoqueNum.Value = filme.Estoque;
        }

        private void label1_Click(object sender, EventArgs e) {
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (double.TryParse(precoTb.Text, out double preco)) {
                if (filme == null) {
                    _ = new FilmeModels(tituloRtb.Text, sinopseTb.Text, dataLancamentoMtb.Text, preco, (int)estoqueNum.Value);
                    MessageBox.Show("Filme cadastrado!");
                } else {
                    FilmeController.AtualizarFilme(filme.FilmeId, tituloRtb.Text, sinopseTb.Text, dataLancamentoMtb.Text, preco, (int)estoqueNum.Value);
                    MessageBox.Show("Filme atualizado!");
                }
                this.Close();
            } else {
                MessageBox.Show("O campo preço precisa ser um numero válido!", "Preco Exception", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}