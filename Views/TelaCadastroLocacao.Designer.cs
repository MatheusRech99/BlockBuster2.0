namespace BlockBuster.Views {
    partial class TelaCadastroLocacao {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idClienteNum = new System.Windows.Forms.NumericUpDown();
            this.idFilmeNum = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idClienteNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idFilmeNum)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Filme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID Cliente:";
            // 
            // idClienteNum
            // 
            this.idClienteNum.Location = new System.Drawing.Point(81, 16);
            this.idClienteNum.Name = "idClienteNum";
            this.idClienteNum.Size = new System.Drawing.Size(79, 23);
            this.idClienteNum.TabIndex = 10;
            // 
            // idFilmeNum
            // 
            this.idFilmeNum.Location = new System.Drawing.Point(81, 45);
            this.idFilmeNum.Name = "idFilmeNum";
            this.idFilmeNum.Size = new System.Drawing.Size(79, 23);
            this.idFilmeNum.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(167, 45);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TelaCadastroLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(273, 123);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.idFilmeNum);
            this.Controls.Add(this.idClienteNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroLocacao";
            this.Load += new System.EventHandler(this.TelaCadastroLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idClienteNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idFilmeNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown idClienteNum;
        private System.Windows.Forms.NumericUpDown idFilmeNum;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}