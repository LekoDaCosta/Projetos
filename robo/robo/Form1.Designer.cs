namespace robo
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
            this.btnOlhoDireito = new System.Windows.Forms.Button();
            this.btnOlhoEsquerdo = new System.Windows.Forms.Button();
            this.btnNariz = new System.Windows.Forms.Button();
            this.btnBoca = new System.Windows.Forms.Button();
            this.btnFeliz = new System.Windows.Forms.Button();
            this.btnEmocionado = new System.Windows.Forms.Button();
            this.btnTriste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOlhoDireito
            // 
            this.btnOlhoDireito.BackColor = System.Drawing.Color.PeachPuff;
            this.btnOlhoDireito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlhoDireito.ForeColor = System.Drawing.Color.Blue;
            this.btnOlhoDireito.Location = new System.Drawing.Point(12, 34);
            this.btnOlhoDireito.Name = "btnOlhoDireito";
            this.btnOlhoDireito.Size = new System.Drawing.Size(65, 29);
            this.btnOlhoDireito.TabIndex = 0;
            this.btnOlhoDireito.Text = "O";
            this.btnOlhoDireito.UseVisualStyleBackColor = false;
            // 
            // btnOlhoEsquerdo
            // 
            this.btnOlhoEsquerdo.BackColor = System.Drawing.Color.PeachPuff;
            this.btnOlhoEsquerdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlhoEsquerdo.ForeColor = System.Drawing.Color.Blue;
            this.btnOlhoEsquerdo.Location = new System.Drawing.Point(180, 34);
            this.btnOlhoEsquerdo.Name = "btnOlhoEsquerdo";
            this.btnOlhoEsquerdo.Size = new System.Drawing.Size(65, 29);
            this.btnOlhoEsquerdo.TabIndex = 1;
            this.btnOlhoEsquerdo.Text = "O";
            this.btnOlhoEsquerdo.UseVisualStyleBackColor = false;
            // 
            // btnNariz
            // 
            this.btnNariz.Location = new System.Drawing.Point(112, 83);
            this.btnNariz.Name = "btnNariz";
            this.btnNariz.Size = new System.Drawing.Size(36, 49);
            this.btnNariz.TabIndex = 2;
            this.btnNariz.UseVisualStyleBackColor = true;
            // 
            // btnBoca
            // 
            this.btnBoca.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoca.ForeColor = System.Drawing.Color.Red;
            this.btnBoca.Location = new System.Drawing.Point(51, 173);
            this.btnBoca.Name = "btnBoca";
            this.btnBoca.Size = new System.Drawing.Size(151, 45);
            this.btnBoca.TabIndex = 3;
            this.btnBoca.Text = "(________)";
            this.btnBoca.UseVisualStyleBackColor = false;
            // 
            // btnFeliz
            // 
            this.btnFeliz.BackColor = System.Drawing.Color.Black;
            this.btnFeliz.ForeColor = System.Drawing.Color.Red;
            this.btnFeliz.Location = new System.Drawing.Point(12, 261);
            this.btnFeliz.Name = "btnFeliz";
            this.btnFeliz.Size = new System.Drawing.Size(54, 21);
            this.btnFeliz.TabIndex = 4;
            this.btnFeliz.Text = "feliz";
            this.btnFeliz.UseVisualStyleBackColor = false;
            this.btnFeliz.Click += new System.EventHandler(this.btnFeliz_Click);
            // 
            // btnEmocionado
            // 
            this.btnEmocionado.BackColor = System.Drawing.Color.Black;
            this.btnEmocionado.ForeColor = System.Drawing.Color.Red;
            this.btnEmocionado.Location = new System.Drawing.Point(112, 261);
            this.btnEmocionado.Name = "btnEmocionado";
            this.btnEmocionado.Size = new System.Drawing.Size(54, 21);
            this.btnEmocionado.TabIndex = 5;
            this.btnEmocionado.Text = "desconfiado";
            this.btnEmocionado.UseVisualStyleBackColor = false;
            this.btnEmocionado.Click += new System.EventHandler(this.btnEmocionado_Click);
            // 
            // btnTriste
            // 
            this.btnTriste.BackColor = System.Drawing.Color.Black;
            this.btnTriste.ForeColor = System.Drawing.Color.Red;
            this.btnTriste.Location = new System.Drawing.Point(191, 261);
            this.btnTriste.Name = "btnTriste";
            this.btnTriste.Size = new System.Drawing.Size(54, 21);
            this.btnTriste.TabIndex = 6;
            this.btnTriste.Text = "triste";
            this.btnTriste.UseVisualStyleBackColor = false;
            this.btnTriste.Click += new System.EventHandler(this.btnTriste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(262, 294);
            this.Controls.Add(this.btnTriste);
            this.Controls.Add(this.btnEmocionado);
            this.Controls.Add(this.btnFeliz);
            this.Controls.Add(this.btnBoca);
            this.Controls.Add(this.btnNariz);
            this.Controls.Add(this.btnOlhoEsquerdo);
            this.Controls.Add(this.btnOlhoDireito);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rosto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOlhoDireito;
        private System.Windows.Forms.Button btnOlhoEsquerdo;
        private System.Windows.Forms.Button btnNariz;
        private System.Windows.Forms.Button btnBoca;
        private System.Windows.Forms.Button btnFeliz;
        private System.Windows.Forms.Button btnEmocionado;
        private System.Windows.Forms.Button btnTriste;
    }
}

