﻿using System;
using System.Globalization;
using System.Windows.Forms;
using BlockBuster.Models;

namespace BlockBuster.Views {
    public partial class TelaListaFilme : Form {

        public bool Selecionavel;
        public int FilmeId;
        public bool Sucesso;
        public TelaListaFilme(bool selecionavel = false) {
            Selecionavel = selecionavel;
            InitializeComponent();
            if (selecionavel) {
                selecionarBtn.Visible = true;
            }
            AtualizarLista();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void TelaListaCliente_Load(object sender, EventArgs e) {

        }

        private void listView1_DoubleClick(object sender, EventArgs e) {
            if (!Selecionavel) return;
            if (listView1.SelectedItems.Count <= 0) return;
            FilmeId = int.Parse(listView1.SelectedItems[0].Text);
            Sucesso = true;
            this.Close();
        }

        private void selecionarBtn_Click(object sender, EventArgs e) {
            if (!Selecionavel) return;
            if (listView1.SelectedItems.Count <= 0) return;
            FilmeId = int.Parse(listView1.SelectedItems[0].Text);
            Sucesso = true;
            this.Close();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (listView1.SelectedItems.Count <= 0) return;
            FilmeId = int.Parse(listView1.SelectedItems[0].Text);
            if (e.ClickedItem.Text.Equals("Alterar")) {
                FilmeModels filme =FilmeModels.GetFilme(FilmeId);
                TelaCadastroFilme tcf = new TelaCadastroFilme(filme);
                tcf.ShowDialog();
            } else if (e.ClickedItem.Text.Equals("Deletar")) {
                FilmeModels.DeletarFilme(FilmeId);
                MessageBox.Show("Cliente deletado com sucesso!");
            }
            AtualizarLista();
        }
        public void AtualizarLista() {
            listView1.Items.Clear();
            var filmes = FilmeModels.GetFilmes();
            foreach (var filme in filmes) {
                string[] row = { filme.FilmeId.ToString(), filme.Titulo, filme.Sinopse, filme.DataLancamento, filme.Preco.ToString(CultureInfo.InvariantCulture), filme.Estoque.ToString() };
                listView1.Items.Add(new ListViewItem(row));
            }
        }
    }
}