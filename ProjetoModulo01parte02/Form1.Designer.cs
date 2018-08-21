namespace ProjetoModulo01parte02
{
    partial class FrmCadPessoas
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
            this.btnChamaOutroForm = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.TxtboxPlaca = new System.Windows.Forms.TextBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChamaOutroForm
            // 
            this.btnChamaOutroForm.Location = new System.Drawing.Point(249, 147);
            this.btnChamaOutroForm.Name = "btnChamaOutroForm";
            this.btnChamaOutroForm.Size = new System.Drawing.Size(136, 25);
            this.btnChamaOutroForm.TabIndex = 0;
            this.btnChamaOutroForm.Text = "Chamar Formulário";
            this.btnChamaOutroForm.UseVisualStyleBackColor = true;
            this.btnChamaOutroForm.Click += new System.EventHandler(this.btnChamaOutroForm_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(278, 80);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa";
            // 
            // TxtboxPlaca
            // 
            this.TxtboxPlaca.AcceptsTab = true;
            this.TxtboxPlaca.Location = new System.Drawing.Point(270, 107);
            this.TxtboxPlaca.Name = "TxtboxPlaca";
            this.TxtboxPlaca.Size = new System.Drawing.Size(100, 20);
            this.TxtboxPlaca.TabIndex = 2;
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(270, 216);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(100, 20);
            this.txtResposta.TabIndex = 3;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(278, 189);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 4;
            this.lblResposta.Text = "Resposta";
            // 
            // FrmCadPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(526, 321);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.TxtboxPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.btnChamaOutroForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmCadPessoas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário cadastro de pessoas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadPessoas_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadPessoas_FormClosed);
            this.Load += new System.EventHandler(this.frmCadPessoas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChamaOutroForm;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox TxtboxPlaca;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblResposta;
    }
}

