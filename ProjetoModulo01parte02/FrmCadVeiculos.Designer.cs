﻿namespace ProjetoModulo01parte02
{
    partial class FrmCadVeiculos
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtReposta = new System.Windows.Forms.TextBox();
            this.btnResposta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(322, 57);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(35, 13);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "label1";
            // 
            // txtReposta
            // 
            this.txtReposta.Location = new System.Drawing.Point(316, 114);
            this.txtReposta.Name = "txtReposta";
            this.txtReposta.Size = new System.Drawing.Size(100, 20);
            this.txtReposta.TabIndex = 1;
            // 
            // btnResposta
            // 
            this.btnResposta.Location = new System.Drawing.Point(355, 171);
            this.btnResposta.Name = "btnResposta";
            this.btnResposta.Size = new System.Drawing.Size(75, 23);
            this.btnResposta.TabIndex = 2;
            this.btnResposta.Text = "Resposta";
            this.btnResposta.UseVisualStyleBackColor = true;
            this.btnResposta.Click += new System.EventHandler(this.btnResposta_Click);
            // 
            // FrmCadVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.btnResposta);
            this.Controls.Add(this.txtReposta);
            this.Controls.Add(this.lblPlaca);
            this.Name = "FrmCadVeiculos";
            this.Text = "FrmCadVeiculos";
            this.Load += new System.EventHandler(this.FrmCadVeiculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnResposta;
        public System.Windows.Forms.TextBox txtReposta;
    }
}