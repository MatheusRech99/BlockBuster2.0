using System;
using System.Windows.Forms;
using BlockBuster.Models;

namespace BlockBuster.Views {
    public partial class TelaConsultaCliente : Form {
        public TelaConsultaCliente() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            ClienteModels cliente = ClienteModels.GetCliente((int)clienteIdNum.Value);
            if (cliente == null) {
                MessageBox.Show("Cliente não encontrado!", "Cliente ID Exception", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(cliente.ToString());
        }
    }
}