namespace Calculadora
{
    partial class Form1
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
            this.mtbResultado = new System.Windows.Forms.MaskedTextBox();
            this.Sete = new System.Windows.Forms.Button();
            this.Oito = new System.Windows.Forms.Button();
            this.Nove = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.Seis = new System.Windows.Forms.Button();
            this.Cinco = new System.Windows.Forms.Button();
            this.Quatro = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.Tres = new System.Windows.Forms.Button();
            this.Dois = new System.Windows.Forms.Button();
            this.um = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnIgualar = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtbResultado
            // 
            this.mtbResultado.Location = new System.Drawing.Point(24, 12);
            this.mtbResultado.Name = "mtbResultado";
            this.mtbResultado.Size = new System.Drawing.Size(246, 20);
            this.mtbResultado.TabIndex = 0;
            // 
            // Sete
            // 
            this.Sete.BackColor = System.Drawing.Color.Snow;
            this.Sete.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sete.Location = new System.Drawing.Point(24, 38);
            this.Sete.Name = "Sete";
            this.Sete.Size = new System.Drawing.Size(51, 27);
            this.Sete.TabIndex = 1;
            this.Sete.Text = "7";
            this.Sete.UseVisualStyleBackColor = false;
            this.Sete.Click += new System.EventHandler(this.btnNumero);
            // 
            // Oito
            // 
            this.Oito.BackColor = System.Drawing.Color.Snow;
            this.Oito.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oito.Location = new System.Drawing.Point(105, 38);
            this.Oito.Name = "Oito";
            this.Oito.Size = new System.Drawing.Size(51, 27);
            this.Oito.TabIndex = 2;
            this.Oito.Text = "8";
            this.Oito.UseVisualStyleBackColor = false;
            this.Oito.Click += new System.EventHandler(this.btnNumero);
            // 
            // Nove
            // 
            this.Nove.BackColor = System.Drawing.Color.Snow;
            this.Nove.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nove.Location = new System.Drawing.Point(186, 38);
            this.Nove.Name = "Nove";
            this.Nove.Size = new System.Drawing.Size(51, 27);
            this.Nove.TabIndex = 3;
            this.Nove.Text = "9";
            this.Nove.UseVisualStyleBackColor = false;
            this.Nove.Click += new System.EventHandler(this.btnNumero);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.Snow;
            this.btnSomar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(243, 38);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(27, 27);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnOperador);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.Snow;
            this.btnSubtrair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(243, 77);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(27, 27);
            this.btnSubtrair.TabIndex = 8;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnOperador);
            // 
            // Seis
            // 
            this.Seis.BackColor = System.Drawing.Color.Snow;
            this.Seis.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seis.Location = new System.Drawing.Point(186, 77);
            this.Seis.Name = "Seis";
            this.Seis.Size = new System.Drawing.Size(51, 27);
            this.Seis.TabIndex = 7;
            this.Seis.Text = "6";
            this.Seis.UseVisualStyleBackColor = false;
            this.Seis.Click += new System.EventHandler(this.btnNumero);
            // 
            // Cinco
            // 
            this.Cinco.BackColor = System.Drawing.Color.Snow;
            this.Cinco.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cinco.Location = new System.Drawing.Point(105, 77);
            this.Cinco.Name = "Cinco";
            this.Cinco.Size = new System.Drawing.Size(51, 27);
            this.Cinco.TabIndex = 6;
            this.Cinco.Text = "5";
            this.Cinco.UseVisualStyleBackColor = false;
            this.Cinco.Click += new System.EventHandler(this.btnNumero);
            // 
            // Quatro
            // 
            this.Quatro.BackColor = System.Drawing.Color.Snow;
            this.Quatro.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quatro.Location = new System.Drawing.Point(24, 77);
            this.Quatro.Name = "Quatro";
            this.Quatro.Size = new System.Drawing.Size(51, 27);
            this.Quatro.TabIndex = 5;
            this.Quatro.Text = "4";
            this.Quatro.UseVisualStyleBackColor = false;
            this.Quatro.Click += new System.EventHandler(this.btnNumero);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.Snow;
            this.btnMultiplicar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(243, 115);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(27, 27);
            this.btnMultiplicar.TabIndex = 12;
            this.btnMultiplicar.Text = "X";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnOperador);
            // 
            // Tres
            // 
            this.Tres.BackColor = System.Drawing.Color.Snow;
            this.Tres.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tres.Location = new System.Drawing.Point(186, 115);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(51, 27);
            this.Tres.TabIndex = 11;
            this.Tres.Text = "3";
            this.Tres.UseVisualStyleBackColor = false;
            this.Tres.Click += new System.EventHandler(this.btnNumero);
            // 
            // Dois
            // 
            this.Dois.BackColor = System.Drawing.Color.Snow;
            this.Dois.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dois.Location = new System.Drawing.Point(105, 115);
            this.Dois.Name = "Dois";
            this.Dois.Size = new System.Drawing.Size(51, 27);
            this.Dois.TabIndex = 10;
            this.Dois.Text = "2";
            this.Dois.UseVisualStyleBackColor = false;
            this.Dois.Click += new System.EventHandler(this.btnNumero);
            // 
            // um
            // 
            this.um.BackColor = System.Drawing.Color.Snow;
            this.um.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.um.Location = new System.Drawing.Point(24, 115);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(51, 27);
            this.um.TabIndex = 9;
            this.um.Text = "1";
            this.um.UseVisualStyleBackColor = false;
            this.um.Click += new System.EventHandler(this.btnNumero);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.Snow;
            this.btnDividir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(243, 154);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(27, 27);
            this.btnDividir.TabIndex = 16;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnOperador);
            // 
            // btnIgualar
            // 
            this.btnIgualar.BackColor = System.Drawing.Color.Snow;
            this.btnIgualar.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgualar.Location = new System.Drawing.Point(186, 154);
            this.btnIgualar.Name = "btnIgualar";
            this.btnIgualar.Size = new System.Drawing.Size(51, 27);
            this.btnIgualar.TabIndex = 15;
            this.btnIgualar.Text = "=";
            this.btnIgualar.UseVisualStyleBackColor = false;
            this.btnIgualar.Click += new System.EventHandler(this.btnIgual);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Snow;
            this.btnZero.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(105, 154);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(51, 27);
            this.btnZero.TabIndex = 14;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnNumero);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.Snow;
            this.btLimpar.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(24, 154);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(51, 27);
            this.btLimpar.TabIndex = 13;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btnLimpar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(295, 210);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnIgualar);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.Tres);
            this.Controls.Add(this.Dois);
            this.Controls.Add(this.um);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.Seis);
            this.Controls.Add(this.Cinco);
            this.Controls.Add(this.Quatro);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.Nove);
            this.Controls.Add(this.Oito);
            this.Controls.Add(this.Sete);
            this.Controls.Add(this.mtbResultado);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbResultado;
        private System.Windows.Forms.Button Sete;
        private System.Windows.Forms.Button Oito;
        private System.Windows.Forms.Button Nove;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button Seis;
        private System.Windows.Forms.Button Cinco;
        private System.Windows.Forms.Button Quatro;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button Tres;
        private System.Windows.Forms.Button Dois;
        private System.Windows.Forms.Button um;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnIgualar;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btLimpar;
    }
}

