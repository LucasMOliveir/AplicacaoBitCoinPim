namespace WindowsFormsApp1
{
    partial class SmartContratoAlterarFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdDoContrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdDoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpData = new System.Windows.Forms.DateTimePicker();
            this.CbxTipoDoContrato = new System.Windows.Forms.ComboBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id do contrato";
            // 
            // TxtIdDoContrato
            // 
            this.TxtIdDoContrato.Enabled = false;
            this.TxtIdDoContrato.Location = new System.Drawing.Point(138, 22);
            this.TxtIdDoContrato.Name = "TxtIdDoContrato";
            this.TxtIdDoContrato.Size = new System.Drawing.Size(100, 20);
            this.TxtIdDoContrato.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo do contrato";
            // 
            // TxtIdDoCliente
            // 
            this.TxtIdDoCliente.Enabled = false;
            this.TxtIdDoCliente.Location = new System.Drawing.Point(138, 211);
            this.TxtIdDoCliente.Name = "TxtIdDoCliente";
            this.TxtIdDoCliente.Size = new System.Drawing.Size(100, 20);
            this.TxtIdDoCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(138, 169);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(100, 20);
            this.TxtValor.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id do cliente";
            // 
            // DtpData
            // 
            this.DtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpData.Location = new System.Drawing.Point(138, 120);
            this.DtpData.Name = "DtpData";
            this.DtpData.Size = new System.Drawing.Size(100, 20);
            this.DtpData.TabIndex = 2;
            // 
            // CbxTipoDoContrato
            // 
            this.CbxTipoDoContrato.FormattingEnabled = true;
            this.CbxTipoDoContrato.Items.AddRange(new object[] {
            "Compra",
            "Venda"});
            this.CbxTipoDoContrato.Location = new System.Drawing.Point(138, 71);
            this.CbxTipoDoContrato.Name = "CbxTipoDoContrato";
            this.CbxTipoDoContrato.Size = new System.Drawing.Size(100, 21);
            this.CbxTipoDoContrato.TabIndex = 1;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(266, 291);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 6;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // SmartContratoAlterarFrm
            // 
            this.AcceptButton = this.BtnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 329);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.CbxTipoDoContrato);
            this.Controls.Add(this.DtpData);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtIdDoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIdDoContrato);
            this.Controls.Add(this.label1);
            this.Name = "SmartContratoAlterarFrm";
            this.Text = "Alterar contrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdDoContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdDoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpData;
        private System.Windows.Forms.ComboBox CbxTipoDoContrato;
        private System.Windows.Forms.Button BtnSalvar;
    }
}