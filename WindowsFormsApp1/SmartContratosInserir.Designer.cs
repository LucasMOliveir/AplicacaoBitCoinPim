namespace WindowsFormsApp1
{
    partial class SmartContratosInserir
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
            this.TxtIdDoContrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIdDoCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpDataDaCriação = new System.Windows.Forms.DateTimePicker();
            this.CbxTipoDoContrato = new System.Windows.Forms.ComboBox();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.BtnSelecionarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(1038, 433);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.TabStop = false;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id do contrato";
            // 
            // TxtIdDoContrato
            // 
            this.TxtIdDoContrato.Enabled = false;
            this.TxtIdDoContrato.Location = new System.Drawing.Point(104, 10);
            this.TxtIdDoContrato.Name = "TxtIdDoContrato";
            this.TxtIdDoContrato.Size = new System.Drawing.Size(211, 20);
            this.TxtIdDoContrato.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo do contrato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(104, 141);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(211, 20);
            this.TxtValor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Id do cliente";
            // 
            // TxtIdDoCliente
            // 
            this.TxtIdDoCliente.Enabled = false;
            this.TxtIdDoCliente.Location = new System.Drawing.Point(104, 185);
            this.TxtIdDoCliente.Name = "TxtIdDoCliente";
            this.TxtIdDoCliente.Size = new System.Drawing.Size(211, 20);
            this.TxtIdDoCliente.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Data da criação";
            // 
            // DtpDataDaCriação
            // 
            this.DtpDataDaCriação.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataDaCriação.Location = new System.Drawing.Point(104, 97);
            this.DtpDataDaCriação.Name = "DtpDataDaCriação";
            this.DtpDataDaCriação.Size = new System.Drawing.Size(211, 20);
            this.DtpDataDaCriação.TabIndex = 2;
            // 
            // CbxTipoDoContrato
            // 
            this.CbxTipoDoContrato.FormattingEnabled = true;
            this.CbxTipoDoContrato.Items.AddRange(new object[] {
            "Compra",
            "Venda"});
            this.CbxTipoDoContrato.Location = new System.Drawing.Point(104, 54);
            this.CbxTipoDoContrato.Name = "CbxTipoDoContrato";
            this.CbxTipoDoContrato.Size = new System.Drawing.Size(211, 21);
            this.CbxTipoDoContrato.TabIndex = 1;
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(366, 10);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(747, 376);
            this.DgvClientes.TabIndex = 5;
            this.DgvClientes.TabStop = false;
            // 
            // BtnSelecionarCliente
            // 
            this.BtnSelecionarCliente.Location = new System.Drawing.Point(366, 392);
            this.BtnSelecionarCliente.Name = "BtnSelecionarCliente";
            this.BtnSelecionarCliente.Size = new System.Drawing.Size(111, 43);
            this.BtnSelecionarCliente.TabIndex = 5;
            this.BtnSelecionarCliente.Text = "Selecionar cliente";
            this.BtnSelecionarCliente.UseVisualStyleBackColor = true;
            this.BtnSelecionarCliente.Click += new System.EventHandler(this.BtnSelecionarCliente_Click);
            // 
            // SmartContratosInserir
            // 
            this.AcceptButton = this.BtnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 463);
            this.Controls.Add(this.BtnSelecionarCliente);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.CbxTipoDoContrato);
            this.Controls.Add(this.DtpDataDaCriação);
            this.Controls.Add(this.TxtIdDoCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIdDoContrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalvar);
            this.Name = "SmartContratosInserir";
            this.Text = "Cadastro de smart contrato";
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdDoContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIdDoCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpDataDaCriação;
        private System.Windows.Forms.ComboBox CbxTipoDoContrato;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Button BtnSelecionarCliente;
    }
}