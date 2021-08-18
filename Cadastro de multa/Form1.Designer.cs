
namespace Cadastro_de_multa
{
    partial class Multas
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
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblplaca = new System.Windows.Forms.Label();
            this.lblinfra = new System.Windows.Forms.Label();
            this.lblpontos = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.txtinfra = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtpontos = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(141, 285);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(141, 52);
            this.btnconfirmar.TabIndex = 0;
            this.btnconfirmar.Text = "Confimar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(443, 285);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(141, 52);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(51, 39);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(27, 13);
            this.lblcpf.TabIndex = 2;
            this.lblcpf.Text = "CPF";
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Location = new System.Drawing.Point(332, 39);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(76, 13);
            this.lblplaca.TabIndex = 3;
            this.lblplaca.Text = "Placa do carro";
            // 
            // lblinfra
            // 
            this.lblinfra.AutoSize = true;
            this.lblinfra.Location = new System.Drawing.Point(51, 112);
            this.lblinfra.Name = "lblinfra";
            this.lblinfra.Size = new System.Drawing.Size(71, 26);
            this.lblinfra.TabIndex = 4;
            this.lblinfra.Text = "Gravidade da\r\ninfração";
            // 
            // lblpontos
            // 
            this.lblpontos.AutoSize = true;
            this.lblpontos.Location = new System.Drawing.Point(332, 182);
            this.lblpontos.Name = "lblpontos";
            this.lblpontos.Size = new System.Drawing.Size(93, 13);
            this.lblpontos.TabIndex = 5;
            this.lblpontos.Text = "Pontos na carteira";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(51, 182);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(74, 13);
            this.lblvalor.TabIndex = 6;
            this.lblvalor.Text = "Valor da multa";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(332, 112);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(78, 26);
            this.lbldata.TabIndex = 7;
            this.lbldata.Text = "Data e hora da\r\ninfração";
            // 
            // txtinfra
            // 
            this.txtinfra.Location = new System.Drawing.Point(131, 109);
            this.txtinfra.Name = "txtinfra";
            this.txtinfra.Size = new System.Drawing.Size(173, 20);
            this.txtinfra.TabIndex = 10;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(431, 36);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(173, 20);
            this.txtplaca.TabIndex = 13;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(131, 179);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.ReadOnly = true;
            this.txtvalor.Size = new System.Drawing.Size(173, 20);
            this.txtvalor.TabIndex = 21;
            // 
            // txtpontos
            // 
            this.txtpontos.Location = new System.Drawing.Point(431, 179);
            this.txtpontos.Name = "txtpontos";
            this.txtpontos.ReadOnly = true;
            this.txtpontos.Size = new System.Drawing.Size(173, 20);
            this.txtpontos.TabIndex = 22;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(131, 39);
            this.txtcpf.Mask = "999,999,999-99";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(173, 20);
            this.txtcpf.TabIndex = 24;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(431, 109);
            this.txtdata.Mask = "00/00/0000";
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(173, 20);
            this.txtdata.TabIndex = 25;
            // 
            // Multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 405);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtpontos);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtinfra);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lblpontos);
            this.Controls.Add(this.lblinfra);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnconfirmar);
            this.Name = "Multas";
            this.Text = "Multas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.Label lblinfra;
        private System.Windows.Forms.Label lblpontos;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.TextBox txtinfra;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtpontos;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txtdata;
    }
}

