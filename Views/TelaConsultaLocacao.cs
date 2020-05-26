using System;
using System.Windows.Forms;
using BlockBuster.Models;

namespace BlockBuster.Views {
    public partial class TelaConsultaLocacao : Form {
        public TelaConsultaLocacao() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            LocacaoModels locacao = LocacaoModels.GetLocacao((int)locacaoIdNum.Value);
            if (locacao == null) {
                MessageBox.Show("Locacao não encontrada!", "Locacao ID Exception", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(locacao.ToString());
        }
    }
}