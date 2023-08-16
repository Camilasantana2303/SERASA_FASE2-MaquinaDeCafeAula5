
namespace Fase2_MaquinaDeCafe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBolacha = new System.Windows.Forms.Button();
            this.btnSalgadinho = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtNovoSaldo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSalgadinho);
            this.panel1.Controls.Add(this.btnBolacha);
            this.panel1.Location = new System.Drawing.Point(108, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 314);
            this.panel1.TabIndex = 0;
            // 
            // btnBolacha
            // 
            this.btnBolacha.Location = new System.Drawing.Point(239, 58);
            this.btnBolacha.Name = "btnBolacha";
            this.btnBolacha.Size = new System.Drawing.Size(82, 33);
            this.btnBolacha.TabIndex = 0;
            this.btnBolacha.Text = "Bolacha";
            this.btnBolacha.UseVisualStyleBackColor = true;
            this.btnBolacha.Click += new System.EventHandler(this.btnBolacha_Click);
            // 
            // btnSalgadinho
            // 
            this.btnSalgadinho.Location = new System.Drawing.Point(241, 21);
            this.btnSalgadinho.Name = "btnSalgadinho";
            this.btnSalgadinho.Size = new System.Drawing.Size(80, 31);
            this.btnSalgadinho.TabIndex = 1;
            this.btnSalgadinho.Text = "Salgadinho";
            this.btnSalgadinho.UseVisualStyleBackColor = true;
            this.btnSalgadinho.Click += new System.EventHandler(this.btnSalgadinho_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.txtNovoSaldo);
            this.panel2.Controls.Add(this.lblSaldo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(26, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 227);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo Disponivel";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(6, 43);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(30, 13);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "R$ 0";
            // 
            // txtNovoSaldo
            // 
            this.txtNovoSaldo.Location = new System.Drawing.Point(9, 76);
            this.txtNovoSaldo.Name = "txtNovoSaldo";
            this.txtNovoSaldo.Size = new System.Drawing.Size(120, 20);
            this.txtNovoSaldo.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 115);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "7,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "4,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalgadinho;
        private System.Windows.Forms.Button btnBolacha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNovoSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

