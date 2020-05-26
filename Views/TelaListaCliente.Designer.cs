namespace BlockBuster.Views
{
    partial class TelaListaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IdHeader = new System.Windows.Forms.ColumnHeader();
            this.nomeHeader = new System.Windows.Forms.ColumnHeader();
            this.dataNascimentoHeader = new System.Windows.Forms.ColumnHeader();
            this.cpfHeader = new System.Windows.Forms.ColumnHeader();
            this.diasDevolucaoHeader = new System.Windows.Forms.ColumnHeader();
            this.selecionarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(499, 301);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHeader,
            this.nomeHeader,
            this.dataNascimentoHeader,
            this.cpfHeader,
            this.diasDevolucaoHeader});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(588, 283);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // IdHeader
            // 
            this.IdHeader.Name = "IdHeader";
            this.IdHeader.Text = "ID";
            this.IdHeader.Width = 40;
            // 
            // nomeHeader
            // 
            this.nomeHeader.Name = "nomeHeader";
            this.nomeHeader.Text = "Nome";
            this.nomeHeader.Width = 180;
            // 
            // dataNascimentoHeader
            // 
            this.dataNascimentoHeader.Name = "dataNascimentoHeader";
            this.dataNascimentoHeader.Text = "Data Nascimento";
            this.dataNascimentoHeader.Width = 120;
            // 
            // cpfHeader
            // 
            this.cpfHeader.Name = "cpfHeader";
            this.cpfHeader.Text = "CPF";
            this.cpfHeader.Width = 139;
            // 
            // diasDevolucaoHeader
            // 
            this.diasDevolucaoHeader.Name = "diasDevolucaoHeader";
            this.diasDevolucaoHeader.Text = "Dias Devolução";
            this.diasDevolucaoHeader.Width = 95;
            // 
            // selecionarBtn
            // 
            this.selecionarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selecionarBtn.Location = new System.Drawing.Point(13, 301);
            this.selecionarBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selecionarBtn.Name = "selecionarBtn";
            this.selecionarBtn.Size = new System.Drawing.Size(101, 27);
            this.selecionarBtn.TabIndex = 1;
            this.selecionarBtn.Text = "Selecionar";
            this.selecionarBtn.UseVisualStyleBackColor = true;
            this.selecionarBtn.Visible = false;
            this.selecionarBtn.Click += new System.EventHandler(this.selecionarBtn_Click);
            // 
            // TelaListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(612, 340);
            this.Controls.Add(this.selecionarBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaListaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaListaCliente";
            this.Load += new System.EventHandler(this.TelaListaCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IdHeader;
        private System.Windows.Forms.ColumnHeader nomeHeader;
        private System.Windows.Forms.ColumnHeader dataNascimentoHeader;
        private System.Windows.Forms.ColumnHeader cpfHeader;
        private System.Windows.Forms.ColumnHeader diasDevolucaoHeader;
        private System.Windows.Forms.Button selecionarBtn;
    }
}