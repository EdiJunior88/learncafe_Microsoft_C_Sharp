namespace Funcoes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btsoma = new System.Windows.Forms.Button();
            this.btsub = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btmult = new System.Windows.Forms.Button();
            this.btigual = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(47, 106);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(75, 34);
            this.bt7.TabIndex = 0;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(128, 106);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(75, 34);
            this.bt8.TabIndex = 1;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(209, 106);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(75, 34);
            this.bt9.TabIndex = 2;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btsoma
            // 
            this.btsoma.Location = new System.Drawing.Point(290, 106);
            this.btsoma.Name = "btsoma";
            this.btsoma.Size = new System.Drawing.Size(37, 34);
            this.btsoma.TabIndex = 3;
            this.btsoma.Text = "+";
            this.btsoma.UseVisualStyleBackColor = true;
            this.btsoma.Click += new System.EventHandler(this.operadores);
            // 
            // btsub
            // 
            this.btsub.Location = new System.Drawing.Point(290, 149);
            this.btsub.Name = "btsub";
            this.btsub.Size = new System.Drawing.Size(37, 34);
            this.btsub.TabIndex = 7;
            this.btsub.Text = "-";
            this.btsub.UseVisualStyleBackColor = true;
            this.btsub.Click += new System.EventHandler(this.operadores);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(209, 149);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(75, 34);
            this.bt6.TabIndex = 6;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(128, 149);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(75, 34);
            this.bt5.TabIndex = 5;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(47, 149);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 34);
            this.bt4.TabIndex = 4;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btdiv
            // 
            this.btdiv.Location = new System.Drawing.Point(290, 193);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(37, 34);
            this.btdiv.TabIndex = 11;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.operadores);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(209, 193);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 34);
            this.bt3.TabIndex = 10;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(128, 193);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 34);
            this.bt2.TabIndex = 9;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(47, 193);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 34);
            this.bt1.TabIndex = 8;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btmult
            // 
            this.btmult.Location = new System.Drawing.Point(290, 237);
            this.btmult.Name = "btmult";
            this.btmult.Size = new System.Drawing.Size(37, 34);
            this.btmult.TabIndex = 15;
            this.btmult.Text = "x";
            this.btmult.UseVisualStyleBackColor = true;
            this.btmult.Click += new System.EventHandler(this.operadores);
            // 
            // btigual
            // 
            this.btigual.Location = new System.Drawing.Point(209, 237);
            this.btigual.Name = "btigual";
            this.btigual.Size = new System.Drawing.Size(75, 34);
            this.btigual.TabIndex = 14;
            this.btigual.Text = "=";
            this.btigual.UseVisualStyleBackColor = true;
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(128, 237);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(75, 34);
            this.bt0.TabIndex = 13;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(47, 237);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(75, 34);
            this.btlimpar.TabIndex = 12;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(47, 68);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(280, 20);
            this.txtresult.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 313);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btmult);
            this.Controls.Add(this.btigual);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btsub);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btsoma);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btsoma;
        private System.Windows.Forms.Button btsub;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btmult;
        private System.Windows.Forms.Button btigual;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.MaskedTextBox txtresult;
    }
}

