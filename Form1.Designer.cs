namespace EX3WF
{
    partial class Diagonal
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
            this.txtDiagonal = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCalcular.Location = new System.Drawing.Point(364, 289);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDiagonal
            // 
            this.txtDiagonal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDiagonal.Location = new System.Drawing.Point(350, 171);
            this.txtDiagonal.Name = "txtDiagonal";
            this.txtDiagonal.Size = new System.Drawing.Size(112, 20);
            this.txtDiagonal.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.LightCyan;
            this.lbl1.Location = new System.Drawing.Point(361, 145);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(89, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Digite a diagonal:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(350, 339);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(112, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // Diagonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtDiagonal);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Diagonal";
            this.Text = "Diagonal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDiagonal;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

