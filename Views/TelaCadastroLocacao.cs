using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BlockBuster.Controllers;
using BlockBuster.Models;

namespace BlockBuster.Views {
    public partial class TelaCadastroLocacao : Form {
        public TelaCadastroLocacao() {
            InitializeComponent();
        }

        private void TelaCadastroLocacao_Load(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {
            TelaListaFilme TelaListaFilme = new TelaListaFilme(true);
            TelaListaFilme.ShowDialog();
            if (TelaListaFilme.Sucesso) {
                idFilmeNum.Value = TelaListaFilme.FilmeId;
            }
        }

        private void button2_Click_1(object sender, EventArgs e) {
            ClienteModels cliente = ClienteModels.GetCliente((int)idClienteNum.Value);
            if (cliente == null) {
                MessageBox.Show("Cliente não encontrado!", "Cliente ID Exception", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            FilmeModels filme = FilmeModels.GetFilme((int)idFilmeNum.Value);
            if (filme == null) {
                MessageBox.Show("Filme não encontrado!", "Filme ID Exception", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            LocacaoModels locacao = LocacaoController.AdicionarLocacao(cliente);
            locacao.AdicionarFilmes(filme);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            TelaListaCliente TelaListaCliente = new TelaListaCliente(true);
            TelaListaCliente.ShowDialog();
            if (TelaListaCliente.Sucesso) {
                idClienteNum.Value = TelaListaCliente.ClienteId;
            }
        }
    }
}
