namespace BlockBuster.Views
{
    partial class TelaListaFilme
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
            this.tituloHeader = new System.Windows.Forms.ColumnHeader();
            this.sinopseHeader = new System.Windows.Forms.ColumnHeader();
            this.dataLancamentoHeader = new System.Windows.Forms.ColumnHeader();
            this.precoHeader = new System.Windows.Forms.ColumnHeader();
            this.selecionarBtn = new System.Windows.Forms.Button();
            this.estoqueHeader = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(499, 301);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 27);
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
            this.tituloHeader,
            this.sinopseHeader,
            this.dataLancamentoHeader,
            this.precoHeader,
            this.estoqueHeader});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 283);
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
            // tituloHeader
            // 
            this.tituloHeader.Name = "tituloHeader";
            this.tituloHeader.Text = "Titulo";
            this.tituloHeader.Width = 180;
            // 
            // sinopseHeader
            // 
            this.sinopseHeader.Name = "sinopseHeader";
            this.sinopseHeader.Text = "Sinopse";
            this.sinopseHeader.Width = 120;
            // 
            // dataLancamentoHeader
            // 
            this.dataLancamentoHeader.Name = "dataLancamentoHeader";
            this.dataLancamentoHeader.Text = "Data Lançamento";
            this.dataLancamentoHeader.Width = 139;
            // 
            // precoHeader
            // 
            this.precoHeader.Name = "precoHeader";
            this.precoHeader.Text = "Preço";
            // 
            // selecionarBtn
            // 
            this.selecionarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selecionarBtn.Location = new System.Drawing.Point(13, 301);
            this.selecionarBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selecionarBtn.Name = "selecionarBtn";
            this.selecionarBtn.Size = new System.Drawing.Size(125, 27);
            this.selecionarBtn.TabIndex = 1;
            this.selecionarBtn.Text = "Selecionar";
            this.selecionarBtn.UseVisualStyleBackColor = true;
            this.selecionarBtn.Visible = false;
            this.selecionarBtn.Click += new System.EventHandler(this.selecionarBtn_Click);
            // 
            // estoqueHeader
            // 
            this.estoqueHeader.Name = "estoqueHeader";
            this.estoqueHeader.Text = "Estoque";
            // 
            // TelaListaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(636, 340);
            this.Controls.Add(this.selecionarBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaListaFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaListaFilme";
            this.Load += new System.EventHandler(this.TelaListaCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IdHeader;
        private System.Windows.Forms.ColumnHeader tituloHeader;
        private System.Windows.Forms.ColumnHeader sinopseHeader;
        private System.Windows.Forms.ColumnHeader dataLancamentoHeader;
        private System.Windows.Forms.ColumnHeader precoHeader;
        private System.Windows.Forms.Button selecionarBtn;
        private System.Windows.Forms.ColumnHeader estoqueHeader;
    }
}