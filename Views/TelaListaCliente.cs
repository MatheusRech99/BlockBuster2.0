using System;
using System.Windows.Forms;
using BlockBuster.Models;

namespace BlockBuster.Views {
    public partial class TelaListaCliente : Form {

        public bool Selecionavel;
        public int ClienteId;
        public bool Sucesso;
        public TelaListaCliente(bool selecionavel = false) {
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
            ClienteId = int.Parse(listView1.SelectedItems[0].Text);
            Sucesso = true;
            this.Close();
        }

        private void selecionarBtn_Click(object sender, EventArgs e) {
            if (!Selecionavel) return;
            if (listView1.SelectedItems.Count <= 0) return;
            ClienteId = int.Parse(listView1.SelectedItems[0].Text);
            Sucesso = true;
            this.Close();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (listView1.SelectedItems.Count <= 0) return;
            ClienteId = int.Parse(listView1.SelectedItems[0].Text);
            if (e.ClickedItem.Text.Equals("Alterar")) {
                ClienteModels cliente = ClienteModels.GetCliente(ClienteId);
                TelaCadastroCliente tcc = new TelaCadastroCliente(cliente);
                tcc.ShowDialog();
            } else if (e.ClickedItem.Text.Equals("Deletar")) {
                ClienteModels.DeletarCliente(ClienteId);
                MessageBox.Show("Cliente deletado com sucesso!");
            }
            AtualizarLista();
        }

        public void AtualizarLista() {
            listView1.Items.Clear();
            var clientes = ClienteModels.GetCliente();
            foreach (var cliente in clientes) {
                string[] row = { cliente.ClienteId.ToString(), cliente.Nome, cliente.DataNascimento, cliente.CPF, cliente.DiasDeDevolucao.ToString() };
                listView1.Items.Add(new ListViewItem(row));
            }
        }
    }
}