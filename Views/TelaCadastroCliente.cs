using System;
using System.Windows.Forms;
using BlockBuster.Controllers;
using BlockBuster.Models;

namespace BlockBuster.Views {
    public partial class TelaCadastroCliente : Form {
        private ClienteModels cliente;
        public TelaCadastroCliente() {
            InitializeComponent();
        }

        public TelaCadastroCliente(ClienteModels cliente) {
            InitializeComponent();
            this.cliente = cliente;
            nomeRtb.Text = cliente.Nome;
            dataNascimentoMtb.Text = cliente.DataNascimento;
            cpfMtb.Text = cliente.CPF;
            diasDeDevNum.Value = cliente.DiasDeDevolucao;
        }

        private void Form2_Load(object sender, EventArgs e) {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {
        }

        private void button1_Click(object sender, EventArgs e) {
            if (cliente == null) {
                ClienteController.InserirCliente(nomeRtb.Text, dataNascimentoMtb.Text, cpfMtb.Text, (int)diasDeDevNum.Value);
                MessageBox.Show("Cliente cadastrado!");
            } else {
                ClienteController.AtualizarCliente(cliente.ClienteId, nomeRtb.Text, dataNascimentoMtb.Text, cpfMtb.Text, (int)diasDeDevNum.Value);
                MessageBox.Show("Cliente atualizado!");
            }
            this.Close();
        }
    }
}