namespace PVolume
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
            this.btn1Limp = new System.Windows.Forms.Button();
            this.btn2Sair = new System.Windows.Forms.Button();
            this.btn3Calc = new System.Windows.Forms.Button();
            this.txt1Raio = new System.Windows.Forms.TextBox();
            this.txt2Alt = new System.Windows.Forms.TextBox();
            this.lbl1Raio = new System.Windows.Forms.Label();
            this.lbl2Alt = new System.Windows.Forms.Label();
            this.lbl3Vol = new System.Windows.Forms.Label();
            this.txt3Vol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1Limp
            // 
            this.btn1Limp.Location = new System.Drawing.Point(269, 81);
            this.btn1Limp.Name = "btn1Limp";
            this.btn1Limp.Size = new System.Drawing.Size(102, 34);
            this.btn1Limp.TabIndex = 0;
            this.btn1Limp.Text = "Limpar";
            this.btn1Limp.UseVisualStyleBackColor = true;
            this.btn1Limp.Click += new System.EventHandler(this.btn1Limp_Click);
            // 
            // btn2Sair
            // 
            this.btn2Sair.Location = new System.Drawing.Point(269, 36);
            this.btn2Sair.Name = "btn2Sair";
            this.btn2Sair.Size = new System.Drawing.Size(102, 34);
            this.btn2Sair.TabIndex = 1;
            this.btn2Sair.Text = "Sair";
            this.btn2Sair.UseVisualStyleBackColor = true;
            this.btn2Sair.Click += new System.EventHandler(this.btn2Sair_Click);
            // 
            // btn3Calc
            // 
            this.btn3Calc.Location = new System.Drawing.Point(269, 129);
            this.btn3Calc.Name = "btn3Calc";
            this.btn3Calc.Size = new System.Drawing.Size(102, 34);
            this.btn3Calc.TabIndex = 2;
            this.btn3Calc.Text = "Calcular";
            this.btn3Calc.UseVisualStyleBackColor = true;
            this.btn3Calc.Click += new System.EventHandler(this.btn3Calc_Click);
            // 
            // txt1Raio
            // 
            this.txt1Raio.Location = new System.Drawing.Point(92, 36);
            this.txt1Raio.Name = "txt1Raio";
            this.txt1Raio.Size = new System.Drawing.Size(161, 20);
            this.txt1Raio.TabIndex = 3;
            // 
            // txt2Alt
            // 
            this.txt2Alt.Location = new System.Drawing.Point(92, 89);
            this.txt2Alt.Name = "txt2Alt";
            this.txt2Alt.Size = new System.Drawing.Size(161, 20);
            this.txt2Alt.TabIndex = 4;
            // 
            // lbl1Raio
            // 
            this.lbl1Raio.AutoSize = true;
            this.lbl1Raio.Location = new System.Drawing.Point(31, 39);
            this.lbl1Raio.Name = "lbl1Raio";
            this.lbl1Raio.Size = new System.Drawing.Size(29, 13);
            this.lbl1Raio.TabIndex = 5;
            this.lbl1Raio.Text = "Raio";
            // 
            // lbl2Alt
            // 
            this.lbl2Alt.AutoSize = true;
            this.lbl2Alt.Location = new System.Drawing.Point(31, 92);
            this.lbl2Alt.Name = "lbl2Alt";
            this.lbl2Alt.Size = new System.Drawing.Size(34, 13);
            this.lbl2Alt.TabIndex = 6;
            this.lbl2Alt.Text = "Altura";
            // 
            // lbl3Vol
            // 
            this.lbl3Vol.AutoSize = true;
            this.lbl3Vol.Location = new System.Drawing.Point(31, 146);
            this.lbl3Vol.Name = "lbl3Vol";
            this.lbl3Vol.Size = new System.Drawing.Size(42, 13);
            this.lbl3Vol.TabIndex = 8;
            this.lbl3Vol.Text = "Volume";
            // 
            // txt3Vol
            // 
            this.txt3Vol.Location = new System.Drawing.Point(92, 143);
            this.txt3Vol.Name = "txt3Vol";
            this.txt3Vol.ReadOnly = true;
            this.txt3Vol.Size = new System.Drawing.Size(161, 20);
            this.txt3Vol.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 192);
            this.Controls.Add(this.lbl3Vol);
            this.Controls.Add(this.txt3Vol);
            this.Controls.Add(this.lbl2Alt);
            this.Controls.Add(this.lbl1Raio);
            this.Controls.Add(this.txt2Alt);
            this.Controls.Add(this.txt1Raio);
            this.Controls.Add(this.btn3Calc);
            this.Controls.Add(this.btn2Sair);
            this.Controls.Add(this.btn1Limp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Limp;
        private System.Windows.Forms.Button btn2Sair;
        private System.Windows.Forms.Button btn3Calc;
        private System.Windows.Forms.TextBox txt1Raio;
        private System.Windows.Forms.TextBox txt2Alt;
        private System.Windows.Forms.Label lbl1Raio;
        private System.Windows.Forms.Label lbl2Alt;
        private System.Windows.Forms.Label lbl3Vol;
        private System.Windows.Forms.TextBox txt3Vol;
    }
}

