namespace BlockBuster.Views
{
    partial class TelaCadastroFilme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tituloRtb = new System.Windows.Forms.RichTextBox();
            this.sinopseTb = new System.Windows.Forms.TextBox();
            this.dataLancamentoMtb = new System.Windows.Forms.MaskedTextBox();
            this.precoTb = new System.Windows.Forms.TextBox();
            this.estoqueNum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sinopse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Lançamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estoque:";
            // 
            // tituloRtb
            // 
            this.tituloRtb.Location = new System.Drawing.Point(59, 9);
            this.tituloRtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tituloRtb.Name = "tituloRtb";
            this.tituloRtb.Size = new System.Drawing.Size(292, 26);
            this.tituloRtb.TabIndex = 5;
            this.tituloRtb.Text = "";
            // 
            // sinopseTb
            // 
            this.sinopseTb.Location = new System.Drawing.Point(72, 42);
            this.sinopseTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sinopseTb.Multiline = true;
            this.sinopseTb.Name = "sinopseTb";
            this.sinopseTb.Size = new System.Drawing.Size(279, 46);
            this.sinopseTb.TabIndex = 6;
            // 
            // dataLancamentoMtb
            // 
            this.dataLancamentoMtb.Location = new System.Drawing.Point(144, 96);
            this.dataLancamentoMtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataLancamentoMtb.Mask = "00/00/0000";
            this.dataLancamentoMtb.Name = "dataLancamentoMtb";
            this.dataLancamentoMtb.Size = new System.Drawing.Size(116, 23);
            this.dataLancamentoMtb.TabIndex = 7;
            this.dataLancamentoMtb.ValidatingType = typeof(System.DateTime);
            // 
            // precoTb
            // 
            this.precoTb.Location = new System.Drawing.Point(66, 126);
            this.precoTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.precoTb.Name = "precoTb";
            this.precoTb.Size = new System.Drawing.Size(54, 23);
            this.precoTb.TabIndex = 8;
            // 
            // estoqueNum
            // 
            this.estoqueNum.Location = new System.Drawing.Point(80, 160);
            this.estoqueNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.estoqueNum.Name = "estoqueNum";
            this.estoqueNum.Size = new System.Drawing.Size(63, 23);
            this.estoqueNum.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TelaCadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 250);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.estoqueNum);
            this.Controls.Add(this.precoTb);
            this.Controls.Add(this.dataLancamentoMtb);
            this.Controls.Add(this.sinopseTb);
            this.Controls.Add(this.tituloRtb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TelaCadastroFilme";
            this.Text = "TelaCadastroFilme";
            ((System.ComponentModel.ISupportInitialize)(this.estoqueNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tituloRtb;
        private System.Windows.Forms.TextBox sinopseTb;
        private System.Windows.Forms.MaskedTextBox dataLancamentoMtb;
        private System.Windows.Forms.TextBox precoTb;
        private System.Windows.Forms.NumericUpDown estoqueNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}