namespace Conexões
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNumero3 = new System.Windows.Forms.TextBox();
            this.btnMaiorMenor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(12, 131);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 40);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Somar";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbNumero1
            // 
            this.txbNumero1.Location = new System.Drawing.Point(12, 26);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(96, 20);
            this.txbNumero1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbNumero2
            // 
            this.txbNumero2.Location = new System.Drawing.Point(13, 65);
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(95, 20);
            this.txbNumero2.TabIndex = 5;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbResultado.Location = new System.Drawing.Point(10, 104);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(55, 13);
            this.lbResultado.TabIndex = 6;
            this.lbResultado.Text = "Resultado";
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número 1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubtrair.Location = new System.Drawing.Point(132, 131);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(104, 40);
            this.btnSubtrair.TabIndex = 8;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.SystemColors.Control;
            this.btnMultiplicacao.Location = new System.Drawing.Point(12, 186);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(104, 40);
            this.btnMultiplicacao.TabIndex = 9;
            this.btnMultiplicacao.Text = "Multiplicação";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.Control;
            this.btnDividir.Location = new System.Drawing.Point(132, 186);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(104, 40);
            this.btnDividir.TabIndex = 10;
            this.btnDividir.Text = "Divisão";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Digite um número:";
            // 
            // txbNumero3
            // 
            this.txbNumero3.Location = new System.Drawing.Point(194, 26);
            this.txbNumero3.Name = "txbNumero3";
            this.txbNumero3.Size = new System.Drawing.Size(243, 20);
            this.txbNumero3.TabIndex = 12;
            // 
            // btnMaiorMenor
            // 
            this.btnMaiorMenor.Location = new System.Drawing.Point(257, 160);
            this.btnMaiorMenor.Name = "btnMaiorMenor";
            this.btnMaiorMenor.Size = new System.Drawing.Size(106, 37);
            this.btnMaiorMenor.TabIndex = 13;
            this.btnMaiorMenor.Text = "Menor Maior";
            this.btnMaiorMenor.UseVisualStyleBackColor = true;
            this.btnMaiorMenor.Click += new System.EventHandler(this.btnMaiorMenor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Impar Par";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMaiorMenor);
            this.Controls.Add(this.txbNumero3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txbNumero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNumero1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbNumero1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNumero2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNumero3;
        private System.Windows.Forms.Button btnMaiorMenor;
        private System.Windows.Forms.Button button1;
    }
}

