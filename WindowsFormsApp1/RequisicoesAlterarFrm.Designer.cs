namespace WindowsFormsApp1
{
    partial class RequisicoesAlterarFrm
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdDaRequisicao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTipoDaRequisicao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtQuantidadeDeMoedas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpData = new System.Windows.Forms.DateTimePicker();
            this.TxtIdDoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(362, 265);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id da requisição";
            // 
            // TxtIdDaRequisicao
            // 
            this.TxtIdDaRequisicao.Enabled = false;
            this.TxtIdDaRequisicao.Location = new System.Drawing.Point(150, 26);
            this.TxtIdDaRequisicao.Name = "TxtIdDaRequisicao";
            this.TxtIdDaRequisicao.Size = new System.Drawing.Size(100, 20);
            this.TxtIdDaRequisicao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo da requisição";
            // 
            // TxtTipoDaRequisicao
            // 
            this.TxtTipoDaRequisicao.Location = new System.Drawing.Point(150, 52);
            this.TxtTipoDaRequisicao.Name = "TxtTipoDaRequisicao";
            this.TxtTipoDaRequisicao.Size = new System.Drawing.Size(100, 20);
            this.TxtTipoDaRequisicao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(150, 114);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(100, 20);
            this.TxtValor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantidade de Moedas";
            // 
            // TxtQuantidadeDeMoedas
            // 
            this.TxtQuantidadeDeMoedas.Location = new System.Drawing.Point(150, 142);
            this.TxtQuantidadeDeMoedas.Name = "TxtQuantidadeDeMoedas";
            this.TxtQuantidadeDeMoedas.Size = new System.Drawing.Size(100, 20);
            this.TxtQuantidadeDeMoedas.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Id do cliente";
            // 
            // DtpData
            // 
            this.DtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpData.Location = new System.Drawing.Point(150, 78);
            this.DtpData.Name = "DtpData";
            this.DtpData.Size = new System.Drawing.Size(100, 20);
            this.DtpData.TabIndex = 3;
            // 
            // TxtIdDoCliente
            // 
            this.TxtIdDoCliente.Enabled = false;
            this.TxtIdDoCliente.Location = new System.Drawing.Point(150, 168);
            this.TxtIdDoCliente.Name = "TxtIdDoCliente";
            this.TxtIdDoCliente.Size = new System.Drawing.Size(100, 20);
            this.TxtIdDoCliente.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Data";
            // 
            // RequisicoesAlterarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 300);
            this.Controls.Add(this.DtpData);
            this.Controls.Add(this.TxtIdDoCliente);
            this.Controls.Add(this.TxtQuantidadeDeMoedas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTipoDaRequisicao);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIdDaRequisicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalvar);
            this.Name = "RequisicoesAlterarFrm";
            this.Text = "RequisicoesAlterarFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdDaRequisicao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTipoDaRequisicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtQuantidadeDeMoedas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpData;
        private System.Windows.Forms.TextBox TxtIdDoCliente;
        private System.Windows.Forms.Label label6;
    }
}