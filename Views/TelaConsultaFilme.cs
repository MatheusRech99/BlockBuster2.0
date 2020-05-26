using System;
using System.Windows.Forms;
using BlockBuster.Models;

namespace BlockBuster.Views {
    public partial class TelaConsultaFilme : Form {
        public TelaConsultaFilme() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            FilmeModels filme = FilmeModels.GetFilme((int)clienteIdNum.Value);
            if (filme == null) {
                MessageBox.Show("Filme não encontrado!", "Filme ID Exception", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(filme.ToString());
        }
    }
}