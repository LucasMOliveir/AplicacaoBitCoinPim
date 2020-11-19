namespace WindowsFormsApp1
{
    partial class CadastroDeUsuarioInserirFrm
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
            this.TxtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCpfCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmailCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTelefoneFixoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCelularCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtIdEnderecoCliente = new System.Windows.Forms.TextBox();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DtpDataDeNascmentoCliente = new System.Windows.Forms.DateTimePicker();
            this.DgvEndereco = new System.Windows.Forms.DataGridView();
            this.BtnSelecionarEndereco = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.TxtSenhaCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // TxtNomeCliente
            // 
            this.TxtNomeCliente.Location = new System.Drawing.Point(32, 101);
            this.TxtNomeCliente.Name = "TxtNomeCliente";
            this.TxtNomeCliente.Size = new System.Drawing.Size(146, 20);
            this.TxtNomeCliente.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPF";
            // 
            // TxtCpfCliente
            // 
            this.TxtCpfCliente.Location = new System.Drawing.Point(32, 163);
            this.TxtCpfCliente.Name = "TxtCpfCliente";
            this.TxtCpfCliente.Size = new System.Drawing.Size(146, 20);
            this.TxtCpfCliente.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-Mail";
            // 
            // TxtEmailCliente
            // 
            this.TxtEmailCliente.Location = new System.Drawing.Point(32, 280);
            this.TxtEmailCliente.Name = "TxtEmailCliente";
            this.TxtEmailCliente.Size = new System.Drawing.Size(146, 20);
            this.TxtEmailCliente.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefone fixo";
            // 
            // TxtTelefoneFixoCliente
            // 
            this.TxtTelefoneFixoCliente.Location = new System.Drawing.Point(32, 440);
            this.TxtTelefoneFixoCliente.Name = "TxtTelefoneFixoCliente";
            this.TxtTelefoneFixoCliente.Size = new System.Drawing.Size(146, 20);
            this.TxtTelefoneFixoCliente.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Celular";
            // 
            // TxtCelularCliente
            // 
            this.TxtCelularCliente.Location = new System.Drawing.Point(32, 486);
            this.TxtCelularCliente.Name = "TxtCelularCliente";
            this.TxtCelularCliente.Size = new System.Drawing.Size(146, 20);
            this.TxtCelularCliente.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Id do endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Id do cliente";
            // 
            // TxtIdEnderecoCliente
            // 
            this.TxtIdEnderecoCliente.Enabled = false;
            this.TxtIdEnderecoCliente.Location = new System.Drawing.Point(238, 343);
            this.TxtIdEnderecoCliente.Name = "TxtIdEnderecoCliente";
            this.TxtIdEnderecoCliente.Size = new System.Drawing.Size(146, 20);
            this.TxtIdEnderecoCliente.TabIndex = 1;
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Enabled = false;
            this.TxtIdCliente.Location = new System.Drawing.Point(32, 37);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(146, 20);
            this.TxtIdCliente.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Data de nascimento";
            // 
            // DtpDataDeNascmentoCliente
            // 
            this.DtpDataDeNascmentoCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataDeNascmentoCliente.Location = new System.Drawing.Point(32, 331);
            this.DtpDataDeNascmentoCliente.Name = "DtpDataDeNascmentoCliente";
            this.DtpDataDeNascmentoCliente.Size = new System.Drawing.Size(146, 20);
            this.DtpDataDeNascmentoCliente.TabIndex = 3;
            // 
            // DgvEndereco
            // 
            this.DgvEndereco.AllowUserToAddRows = false;
            this.DgvEndereco.AllowUserToDeleteRows = false;
            this.DgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEndereco.Location = new System.Drawing.Point(238, 37);
            this.DgvEndereco.Name = "DgvEndereco";
            this.DgvEndereco.ReadOnly = true;
            this.DgvEndereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEndereco.Size = new System.Drawing.Size(851, 263);
            this.DgvEndereco.TabIndex = 3;
            // 
            // BtnSelecionarEndereco
            // 
            this.BtnSelecionarEndereco.Location = new System.Drawing.Point(1001, 315);
            this.BtnSelecionarEndereco.Name = "BtnSelecionarEndereco";
            this.BtnSelecionarEndereco.Size = new System.Drawing.Size(88, 36);
            this.BtnSelecionarEndereco.TabIndex = 7;
            this.BtnSelecionarEndereco.Text = "Selecionar endereço";
            this.BtnSelecionarEndereco.UseVisualStyleBackColor = true;
            this.BtnSelecionarEndereco.Click += new System.EventHandler(this.BtnSelecionarEndereco_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(1014, 597);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(29, 372);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha";
            // 
            // TxtSenhaCliente
            // 
            this.TxtSenhaCliente.Location = new System.Drawing.Point(32, 388);
            this.TxtSenhaCliente.Name = "TxtSenhaCliente";
            this.TxtSenhaCliente.Size = new System.Drawing.Size(146, 20);
            this.TxtSenhaCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selecione o endereço";
            // 
            // CadastroDeUsuarioInserirFrm
            // 
            this.AcceptButton = this.BtnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 632);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnSelecionarEndereco);
            this.Controls.Add(this.DgvEndereco);
            this.Controls.Add(this.DtpDataDeNascmentoCliente);
            this.Controls.Add(this.TxtSenhaCliente);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.TxtTelefoneFixoCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEmailCliente);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtIdEnderecoCliente);
            this.Controls.Add(this.TxtCpfCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCelularCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtNomeCliente);
            this.Controls.Add(this.label1);
            this.Name = "CadastroDeUsuarioInserirFrm";
            this.Text = "Inserir Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCpfCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmailCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTelefoneFixoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCelularCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtIdEnderecoCliente;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpDataDeNascmentoCliente;
        private System.Windows.Forms.DataGridView DgvEndereco;
        private System.Windows.Forms.Button BtnSelecionarEndereco;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox TxtSenhaCliente;
        private System.Windows.Forms.Label label3;
    }
}