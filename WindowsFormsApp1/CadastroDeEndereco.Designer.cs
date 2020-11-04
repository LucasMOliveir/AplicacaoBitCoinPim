namespace WindowsFormsApp1
{
    partial class CadastroDeEndereco
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCepEndereco = new System.Windows.Forms.TextBox();
            this.DgvCadastroDeEndereco = new System.Windows.Forms.DataGridView();
            this.EnderecoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnConsultarPorID = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCadastroDeEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnExcluir);
            this.panel1.Controls.Add(this.BtnAlterar);
            this.panel1.Controls.Add(this.BtnCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 100);
            this.panel1.TabIndex = 0;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Location = new System.Drawing.Point(334, 2);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(165, 97);
            this.BtnExcluir.TabIndex = 0;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Location = new System.Drawing.Point(168, 2);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(165, 97);
            this.BtnAlterar.TabIndex = 0;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Location = new System.Drawing.Point(2, 2);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(165, 97);
            this.BtnCadastrar.TabIndex = 0;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id do endereco";
            // 
            // TxtIdEndereco
            // 
            this.TxtIdEndereco.Location = new System.Drawing.Point(12, 136);
            this.TxtIdEndereco.Name = "TxtIdEndereco";
            this.TxtIdEndereco.Size = new System.Drawing.Size(100, 20);
            this.TxtIdEndereco.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cep do endereco";
            // 
            // TxtCepEndereco
            // 
            this.TxtCepEndereco.Location = new System.Drawing.Point(12, 198);
            this.TxtCepEndereco.Name = "TxtCepEndereco";
            this.TxtCepEndereco.Size = new System.Drawing.Size(100, 20);
            this.TxtCepEndereco.TabIndex = 2;
            this.TxtCepEndereco.TextChanged += new System.EventHandler(this.TxtCepEndereco_TextChanged);
            // 
            // DgvCadastroDeEndereco
            // 
            this.DgvCadastroDeEndereco.AllowUserToAddRows = false;
            this.DgvCadastroDeEndereco.AllowUserToDeleteRows = false;
            this.DgvCadastroDeEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCadastroDeEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnderecoId,
            this.Logradouro,
            this.Numero,
            this.Bairro,
            this.Cidade,
            this.UF,
            this.Pais,
            this.Cep,
            this.Complemento});
            this.DgvCadastroDeEndereco.Location = new System.Drawing.Point(12, 284);
            this.DgvCadastroDeEndereco.Name = "DgvCadastroDeEndereco";
            this.DgvCadastroDeEndereco.ReadOnly = true;
            this.DgvCadastroDeEndereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCadastroDeEndereco.Size = new System.Drawing.Size(1030, 295);
            this.DgvCadastroDeEndereco.TabIndex = 3;
            // 
            // EnderecoId
            // 
            this.EnderecoId.DataPropertyName = "EnderecoId";
            this.EnderecoId.HeaderText = "ID do Endereço";
            this.EnderecoId.Name = "EnderecoId";
            this.EnderecoId.ReadOnly = true;
            this.EnderecoId.Width = 150;
            // 
            // Logradouro
            // 
            this.Logradouro.DataPropertyName = "Logradouro";
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // UF
            // 
            this.UF.DataPropertyName = "UF";
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            // 
            // Pais
            // 
            this.Pais.DataPropertyName = "Pais";
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "Cep";
            this.Cep.HeaderText = "CEP";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            // 
            // Complemento
            // 
            this.Complemento.DataPropertyName = "Complemento";
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            this.Complemento.ReadOnly = true;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(966, 251);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 4;
            this.BtnConsultar.Text = "Atualizar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnConsultarPorID
            // 
            this.BtnConsultarPorID.Location = new System.Drawing.Point(118, 134);
            this.BtnConsultarPorID.Name = "BtnConsultarPorID";
            this.BtnConsultarPorID.Size = new System.Drawing.Size(107, 23);
            this.BtnConsultarPorID.TabIndex = 4;
            this.BtnConsultarPorID.Text = "Consultar por ID";
            this.BtnConsultarPorID.UseVisualStyleBackColor = true;
            this.BtnConsultarPorID.Click += new System.EventHandler(this.BtnConsultarPorID_Click);
            // 
            // CadastroDeEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 591);
            this.Controls.Add(this.BtnConsultarPorID);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.DgvCadastroDeEndereco);
            this.Controls.Add(this.TxtCepEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdEndereco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroDeEndereco";
            this.Text = "Cadastro De Endereco";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCadastroDeEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCepEndereco;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnConsultarPorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        public System.Windows.Forms.DataGridView DgvCadastroDeEndereco;
    }
}