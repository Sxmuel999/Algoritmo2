namespace Calc
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
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lbTemp = new System.Windows.Forms.Label();
            this.lbOperador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNumero1
            // 
            this.txbNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumero1.Location = new System.Drawing.Point(4, 47);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.ReadOnly = true;
            this.txbNumero1.Size = new System.Drawing.Size(263, 38);
            this.txbNumero1.TabIndex = 0;
            this.txbNumero1.TextChanged += new System.EventHandler(this.txbNumero1_TextChanged);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(12, 5);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(42, 39);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "R";
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(224, 288);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(43, 39);
            this.btnMais.TabIndex = 3;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(224, 231);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(43, 39);
            this.btnMenos.TabIndex = 4;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVezes.Location = new System.Drawing.Point(224, 165);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(43, 39);
            this.btnVezes.TabIndex = 5;
            this.btnVezes.Text = "X";
            this.btnVezes.UseVisualStyleBackColor = true;
            this.btnVezes.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(224, 108);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(43, 39);
            this.btnDividir.TabIndex = 6;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnSete
            // 
            this.btnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.Location = new System.Drawing.Point(4, 108);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(42, 39);
            this.btnSete.TabIndex = 7;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnOito
            // 
            this.btnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.Location = new System.Drawing.Point(79, 108);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(42, 39);
            this.btnOito.TabIndex = 8;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnNove
            // 
            this.btnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.Location = new System.Drawing.Point(152, 108);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(42, 39);
            this.btnNove.TabIndex = 9;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.Location = new System.Drawing.Point(4, 165);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(42, 39);
            this.btnQuatro.TabIndex = 10;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(79, 165);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(42, 39);
            this.btnCinco.TabIndex = 11;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(152, 165);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(42, 39);
            this.btnSeis.TabIndex = 12;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnUm
            // 
            this.btnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.Location = new System.Drawing.Point(4, 231);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(42, 39);
            this.btnUm.TabIndex = 13;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnDois
            // 
            this.btnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.Location = new System.Drawing.Point(79, 231);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(42, 39);
            this.btnDois.TabIndex = 14;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(152, 231);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(42, 39);
            this.btnTres.TabIndex = 15;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(79, 288);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(42, 39);
            this.btnZero.TabIndex = 16;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(152, 288);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(42, 39);
            this.button11.TabIndex = 17;
            this.button11.Text = "=";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(4, 288);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(42, 39);
            this.btnApagar.TabIndex = 18;
            this.btnApagar.Text = "C";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbTemp.Location = new System.Drawing.Point(72, 5);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(104, 39);
            this.lbTemp.TabIndex = 19;
            this.lbTemp.Text = "Temp";
            // 
            // lbOperador
            // 
            this.lbOperador.AutoSize = true;
            this.lbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbOperador.Location = new System.Drawing.Point(191, 5);
            this.lbOperador.Name = "lbOperador";
            this.lbOperador.Size = new System.Drawing.Size(62, 39);
            this.lbOperador.TabIndex = 20;
            this.lbOperador.Text = "Op";
            this.lbOperador.Click += new System.EventHandler(this.lbOperador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(583, 395);
            this.Controls.Add(this.lbOperador);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txbNumero1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNumero1;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label lbOperador;
    }
}

