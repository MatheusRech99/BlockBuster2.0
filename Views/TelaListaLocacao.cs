using System;
using System.Globalization;
using System.Windows.Forms;
using BlockBuster.Models;

namespace BlockBuster.Views {
    public partial class TelaListaLocacao : Form {

        public bool Selecionavel;
        public int LocacaoId;
        public bool Sucesso;
        public TelaListaLocacao(bool selecionavel = false) {
            Selecionavel = selecionavel;
            InitializeComponent();
            if (selecionavel) {
                selecionarBtn.Visible = true;
            }
            var locacoes = LocacaoModels.GetLocacao();
            foreach (var locacao in locacoes) {
                foreach (var filme in locacao.Filmes) {
                    string[] row = { locacao.LocacaoId.ToString(), locacao.Cliente.Nome, filme.Titulo, locacao.DataLocacao.ToString(), filme.Preco.ToString(CultureInfo.InvariantCulture) };
                    listView1.Items.Add(new ListViewItem(row));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void TelaListaCliente_Load(object sender, EventArgs e) {

        }

        private void listView1_DoubleClick(object sender, EventArgs e) {
            if (!Selecionavel) return;
            if (listView1.SelectedItems.Count <= 0) return;
            LocacaoId = int.Parse(listView1.SelectedItems[0].Text);
            Sucesso = true;
            this.Close();
        }

        private void selecionarBtn_Click(object sender, EventArgs e) {
            if (!Selecionavel) return;
            if (listView1.SelectedItems.Count <= 0) return;
            LocacaoId = int.Parse(listView1.SelectedItems[0].Text);
            Sucesso = true;
            this.Close();
        }
    }
}