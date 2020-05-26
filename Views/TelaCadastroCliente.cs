using System;
using System.Windows.Forms;
using BlockBuster.Controllers;

namespace BlockBuster.Views {
    public partial class TelaCadastroCliente : Form {
        public TelaCadastroCliente() {
            InitializeComponent();
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
            ClienteController.InserirCliente(nomeRtb.Text, dataNascimentoMtb.Text, cpfMtb.Text, (int) diasDeDevNum.Value);
            this.Close();
        }
    }
}