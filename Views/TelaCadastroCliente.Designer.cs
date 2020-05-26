namespace BlockBuster.Views
{
    partial class TelaCadastroCliente
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
            this.nomeRtb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataNascimentoMtb = new System.Windows.Forms.MaskedTextBox();
            this.cpfMtb = new System.Windows.Forms.MaskedTextBox();
            this.diasDeDevNum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diasDeDevNum)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeRtb
            // 
            this.nomeRtb.Location = new System.Drawing.Point(61, 23);
            this.nomeRtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomeRtb.Name = "nomeRtb";
            this.nomeRtb.Size = new System.Drawing.Size(294, 26);
            this.nomeRtb.TabIndex = 0;
            this.nomeRtb.Text = "";
            this.nomeRtb.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dias de Devolução:";
            // 
            // dataNascimentoMtb
            // 
            this.dataNascimentoMtb.Location = new System.Drawing.Point(136, 53);
            this.dataNascimentoMtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataNascimentoMtb.Mask = "00/00/0000";
            this.dataNascimentoMtb.Name = "dataNascimentoMtb";
            this.dataNascimentoMtb.Size = new System.Drawing.Size(116, 23);
            this.dataNascimentoMtb.TabIndex = 5;
            this.dataNascimentoMtb.ValidatingType = typeof(System.DateTime);
            this.dataNascimentoMtb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // cpfMtb
            // 
            this.cpfMtb.Location = new System.Drawing.Point(48, 82);
            this.cpfMtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cpfMtb.Mask = "000.000.000-00";
            this.cpfMtb.Name = "cpfMtb";
            this.cpfMtb.Size = new System.Drawing.Size(116, 23);
            this.cpfMtb.TabIndex = 6;
            this.cpfMtb.ValidatingType = typeof(System.DateTime);
            // 
            // diasDeDevNum
            // 
            this.diasDeDevNum.Location = new System.Drawing.Point(136, 113);
            this.diasDeDevNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.diasDeDevNum.Name = "diasDeDevNum";
            this.diasDeDevNum.Size = new System.Drawing.Size(59, 23);
            this.diasDeDevNum.TabIndex = 7;
            this.diasDeDevNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 168);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TelaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(373, 209);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diasDeDevNum);
            this.Controls.Add(this.cpfMtb);
            this.Controls.Add(this.dataNascimentoMtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeRtb);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroCliente";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diasDeDevNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox nomeRtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox dataNascimentoMtb;
        private System.Windows.Forms.MaskedTextBox cpfMtb;
        private System.Windows.Forms.NumericUpDown diasDeDevNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}