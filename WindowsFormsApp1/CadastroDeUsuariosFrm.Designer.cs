namespace WindowsFormsApp1
{
    partial class CadastroDeUsuariosFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeUsuariosFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExcluirRegistro = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BtnPesquisarPorId = new System.Windows.Forms.Button();
            this.DgvCadastroUsuario = new System.Windows.Forms.DataGridView();
            this.IdDoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfDoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailDoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDeNascDoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenhaDoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneFixoDoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CelularDoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDoEnderecoDoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCadastroUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExcluirRegistro);
            this.panel1.Controls.Add(this.BtnAlterar);
            this.panel1.Controls.Add(this.BtnInserir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 0;
            // 
            // BtnExcluirRegistro
            // 
            this.BtnExcluirRegistro.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluirRegistro.Image")));
            this.BtnExcluirRegistro.Location = new System.Drawing.Point(422, 0);
            this.BtnExcluirRegistro.Name = "BtnExcluirRegistro";
            this.BtnExcluirRegistro.Size = new System.Drawing.Size(212, 100);
            this.BtnExcluirRegistro.TabIndex = 0;
            this.BtnExcluirRegistro.Text = "Excluir registro";
            this.BtnExcluirRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluirRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExcluirRegistro.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlterar.Image")));
            this.BtnAlterar.Location = new System.Drawing.Point(211, 0);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(212, 100);
            this.BtnAlterar.TabIndex = 0;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Image = ((System.Drawing.Image)(resources.GetObject("BtnInserir.Image")));
            this.BtnInserir.Location = new System.Drawing.Point(0, 0);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(212, 100);
            this.BtnInserir.TabIndex = 0;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(20, 126);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(19, 13);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Id:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(20, 167);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(81, 126);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 2;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(81, 165);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 2;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // BtnPesquisarPorId
            // 
            this.BtnPesquisarPorId.Location = new System.Drawing.Point(187, 120);
            this.BtnPesquisarPorId.Name = "BtnPesquisarPorId";
            this.BtnPesquisarPorId.Size = new System.Drawing.Size(116, 32);
            this.BtnPesquisarPorId.TabIndex = 3;
            this.BtnPesquisarPorId.Text = "Pesquisar por id";
            this.BtnPesquisarPorId.UseVisualStyleBackColor = true;
            this.BtnPesquisarPorId.Click += new System.EventHandler(this.BtnPesquisarPorId_Click);
            // 
            // DgvCadastroUsuario
            // 
            this.DgvCadastroUsuario.AllowUserToAddRows = false;
            this.DgvCadastroUsuario.AllowUserToDeleteRows = false;
            this.DgvCadastroUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCadastroUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDoCliente,
            this.NomeDoCliente,
            this.CpfDoCliente,
            this.EmailDoCliente,
            this.DataDeNascDoCliente,
            this.SenhaDoCliente,
            this.TelefoneFixoDoCliente,
            this.CelularDoCliente,
            this.IdDoEnderecoDoCliente});
            this.DgvCadastroUsuario.Location = new System.Drawing.Point(12, 198);
            this.DgvCadastroUsuario.Name = "DgvCadastroUsuario";
            this.DgvCadastroUsuario.ReadOnly = true;
            this.DgvCadastroUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCadastroUsuario.Size = new System.Drawing.Size(960, 244);
            this.DgvCadastroUsuario.TabIndex = 4;
            // 
            // IdDoCliente
            // 
            this.IdDoCliente.DataPropertyName = "ClienteId";
            this.IdDoCliente.HeaderText = "Id do cliente";
            this.IdDoCliente.Name = "IdDoCliente";
            this.IdDoCliente.ReadOnly = true;
            // 
            // NomeDoCliente
            // 
            this.NomeDoCliente.DataPropertyName = "Nome";
            this.NomeDoCliente.HeaderText = "Nome";
            this.NomeDoCliente.Name = "NomeDoCliente";
            this.NomeDoCliente.ReadOnly = true;
            // 
            // CpfDoCliente
            // 
            this.CpfDoCliente.DataPropertyName = "CPF";
            this.CpfDoCliente.HeaderText = "CPF";
            this.CpfDoCliente.Name = "CpfDoCliente";
            this.CpfDoCliente.ReadOnly = true;
            // 
            // EmailDoCliente
            // 
            this.EmailDoCliente.DataPropertyName = "Email";
            this.EmailDoCliente.HeaderText = "E-mail";
            this.EmailDoCliente.Name = "EmailDoCliente";
            this.EmailDoCliente.ReadOnly = true;
            // 
            // DataDeNascDoCliente
            // 
            this.DataDeNascDoCliente.DataPropertyName = "DataDeNascimento";
            this.DataDeNascDoCliente.HeaderText = "Data de nascimento";
            this.DataDeNascDoCliente.Name = "DataDeNascDoCliente";
            this.DataDeNascDoCliente.ReadOnly = true;
            // 
            // SenhaDoCliente
            // 
            this.SenhaDoCliente.DataPropertyName = "Senha";
            this.SenhaDoCliente.HeaderText = "Senha";
            this.SenhaDoCliente.Name = "SenhaDoCliente";
            this.SenhaDoCliente.ReadOnly = true;
            // 
            // TelefoneFixoDoCliente
            // 
            this.TelefoneFixoDoCliente.DataPropertyName = "TelefoneFixo";
            this.TelefoneFixoDoCliente.HeaderText = "Telefone fixo";
            this.TelefoneFixoDoCliente.Name = "TelefoneFixoDoCliente";
            this.TelefoneFixoDoCliente.ReadOnly = true;
            // 
            // CelularDoCliente
            // 
            this.CelularDoCliente.DataPropertyName = "Celular";
            this.CelularDoCliente.HeaderText = "Celular";
            this.CelularDoCliente.Name = "CelularDoCliente";
            this.CelularDoCliente.ReadOnly = true;
            // 
            // IdDoEnderecoDoCliente
            // 
            this.IdDoEnderecoDoCliente.DataPropertyName = "EnderecoId";
            this.IdDoEnderecoDoCliente.HeaderText = "Id do Endereço";
            this.IdDoEnderecoDoCliente.Name = "IdDoEnderecoDoCliente";
            this.IdDoEnderecoDoCliente.ReadOnly = true;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(896, 161);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnAtualizar.TabIndex = 5;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // CadastroDeUsuariosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.DgvCadastroUsuario);
            this.Controls.Add(this.BtnPesquisarPorId);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroDeUsuariosFrm";
            this.Text = "Cadastro De Usuarios";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCadastroUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnExcluirRegistro;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BtnPesquisarPorId;
        private System.Windows.Forms.DataGridView DgvCadastroUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfDoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailDoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeNascDoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenhaDoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneFixoDoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CelularDoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDoEnderecoDoCliente;
        private System.Windows.Forms.Button BtnAtualizar;
    }
}