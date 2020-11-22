namespace WindowsFormsApp1
{
    partial class RequisicoesInserirFrm
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtIdDaRequisicao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTipoDaRequisicao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtQuantidadeDeMoedas = new System.Windows.Forms.TextBox();
            this.TxtIdDoCliente = new System.Windows.Forms.TextBox();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.DtpData = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSelecionarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id da requisicao";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(713, 415);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 6;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtIdDaRequisicao
            // 
            this.TxtIdDaRequisicao.Enabled = false;
            this.TxtIdDaRequisicao.Location = new System.Drawing.Point(127, 17);
            this.TxtIdDaRequisicao.Name = "TxtIdDaRequisicao";
            this.TxtIdDaRequisicao.Size = new System.Drawing.Size(100, 20);
            this.TxtIdDaRequisicao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo da requisicao";
            // 
            // TxtTipoDaRequisicao
            // 
            this.TxtTipoDaRequisicao.Location = new System.Drawing.Point(127, 52);
            this.TxtTipoDaRequisicao.Name = "TxtTipoDaRequisicao";
            this.TxtTipoDaRequisicao.Size = new System.Drawing.Size(100, 20);
            this.TxtTipoDaRequisicao.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(127, 120);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(100, 20);
            this.TxtValor.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantidade de moedas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id do cliente";
            // 
            // TxtQuantidadeDeMoedas
            // 
            this.TxtQuantidadeDeMoedas.Location = new System.Drawing.Point(127, 148);
            this.TxtQuantidadeDeMoedas.Name = "TxtQuantidadeDeMoedas";
            this.TxtQuantidadeDeMoedas.Size = new System.Drawing.Size(100, 20);
            this.TxtQuantidadeDeMoedas.TabIndex = 4;
            // 
            // TxtIdDoCliente
            // 
            this.TxtIdDoCliente.Enabled = false;
            this.TxtIdDoCliente.Location = new System.Drawing.Point(127, 183);
            this.TxtIdDoCliente.Name = "TxtIdDoCliente";
            this.TxtIdDoCliente.Size = new System.Drawing.Size(100, 20);
            this.TxtIdDoCliente.TabIndex = 5;
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(324, 23);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(464, 386);
            this.DgvClientes.TabIndex = 3;
            // 
            // DtpData
            // 
            this.DtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpData.Location = new System.Drawing.Point(127, 88);
            this.DtpData.Name = "DtpData";
            this.DtpData.Size = new System.Drawing.Size(100, 20);
            this.DtpData.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Selecionar cliente";
            // 
            // BtnSelecionarCliente
            // 
            this.BtnSelecionarCliente.Location = new System.Drawing.Point(324, 415);
            this.BtnSelecionarCliente.Name = "BtnSelecionarCliente";
            this.BtnSelecionarCliente.Size = new System.Drawing.Size(108, 23);
            this.BtnSelecionarCliente.TabIndex = 7;
            this.BtnSelecionarCliente.Text = "Selecionar cliente";
            this.BtnSelecionarCliente.UseVisualStyleBackColor = true;
            this.BtnSelecionarCliente.Click += new System.EventHandler(this.BtnSelecionarCliente_Click);
            // 
            // RequisicoesInserirFrm
            // 
            this.AcceptButton = this.BtnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSelecionarCliente);
            this.Controls.Add(this.DtpData);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.TxtIdDoCliente);
            this.Controls.Add(this.TxtQuantidadeDeMoedas);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTipoDaRequisicao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtIdDaRequisicao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "RequisicoesInserirFrm";
            this.Text = "Cadastrar requisições";
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtIdDaRequisicao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTipoDaRequisicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtQuantidadeDeMoedas;
        private System.Windows.Forms.TextBox TxtIdDoCliente;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.DateTimePicker DtpData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSelecionarCliente;
    }
}