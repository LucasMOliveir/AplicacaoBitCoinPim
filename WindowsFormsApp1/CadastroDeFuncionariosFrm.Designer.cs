namespace WindowsFormsApp1
{
    partial class CadastroDeFuncionariosFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeFuncionariosFrm));
            this.TxtUsuarioFuncionarioId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterarRegistro = new System.Windows.Forms.Button();
            this.BtnInserirFuncionario = new System.Windows.Forms.Button();
            this.TxtUsuarioFuncionarioNome = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.BtnPesquisarPorId = new System.Windows.Forms.Button();
            this.DgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuarioFuncionarioId
            // 
            this.TxtUsuarioFuncionarioId.Location = new System.Drawing.Point(57, 130);
            this.TxtUsuarioFuncionarioId.Name = "TxtUsuarioFuncionarioId";
            this.TxtUsuarioFuncionarioId.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuarioFuncionarioId.TabIndex = 0;
            this.TxtUsuarioFuncionarioId.TextChanged += new System.EventHandler(this.TxtUsuarioFuncionarioId_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnExcluir);
            this.panel1.Controls.Add(this.BtnAlterarRegistro);
            this.panel1.Controls.Add(this.BtnInserirFuncionario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 100);
            this.panel1.TabIndex = 1;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.Location = new System.Drawing.Point(418, 0);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(212, 100);
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.Text = "Excluir registro";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnAlterarRegistro
            // 
            this.BtnAlterarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlterarRegistro.Image")));
            this.BtnAlterarRegistro.Location = new System.Drawing.Point(210, 0);
            this.BtnAlterarRegistro.Name = "BtnAlterarRegistro";
            this.BtnAlterarRegistro.Size = new System.Drawing.Size(212, 100);
            this.BtnAlterarRegistro.TabIndex = 3;
            this.BtnAlterarRegistro.Text = "Alterar registro";
            this.BtnAlterarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAlterarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlterarRegistro.UseVisualStyleBackColor = true;
            this.BtnAlterarRegistro.Click += new System.EventHandler(this.BtnAlterarRegistro_Click);
            // 
            // BtnInserirFuncionario
            // 
            this.BtnInserirFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("BtnInserirFuncionario.Image")));
            this.BtnInserirFuncionario.Location = new System.Drawing.Point(0, 0);
            this.BtnInserirFuncionario.Name = "BtnInserirFuncionario";
            this.BtnInserirFuncionario.Size = new System.Drawing.Size(212, 100);
            this.BtnInserirFuncionario.TabIndex = 3;
            this.BtnInserirFuncionario.Text = "Inserir";
            this.BtnInserirFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInserirFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInserirFuncionario.UseVisualStyleBackColor = true;
            this.BtnInserirFuncionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtUsuarioFuncionarioNome
            // 
            this.TxtUsuarioFuncionarioNome.Location = new System.Drawing.Point(57, 175);
            this.TxtUsuarioFuncionarioNome.Name = "TxtUsuarioFuncionarioNome";
            this.TxtUsuarioFuncionarioNome.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuarioFuncionarioNome.TabIndex = 0;
            this.TxtUsuarioFuncionarioNome.TextChanged += new System.EventHandler(this.TxtUsuarioFuncionarioNome_TextChanged);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(13, 133);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(19, 13);
            this.LblId.TabIndex = 2;
            this.LblId.Text = "Id:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(13, 178);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome:";
            // 
            // BtnPesquisarPorId
            // 
            this.BtnPesquisarPorId.Location = new System.Drawing.Point(163, 123);
            this.BtnPesquisarPorId.Name = "BtnPesquisarPorId";
            this.BtnPesquisarPorId.Size = new System.Drawing.Size(116, 32);
            this.BtnPesquisarPorId.TabIndex = 3;
            this.BtnPesquisarPorId.Text = "Pesquisar por id";
            this.BtnPesquisarPorId.UseVisualStyleBackColor = true;
            this.BtnPesquisarPorId.Click += new System.EventHandler(this.BtnPesquisarPorId_Click);
            // 
            // DgvFuncionarios
            // 
            this.DgvFuncionarios.AllowUserToAddRows = false;
            this.DgvFuncionarios.AllowUserToDeleteRows = false;
            this.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionarios.Location = new System.Drawing.Point(12, 215);
            this.DgvFuncionarios.Name = "DgvFuncionarios";
            this.DgvFuncionarios.ReadOnly = true;
            this.DgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFuncionarios.Size = new System.Drawing.Size(960, 234);
            this.DgvFuncionarios.TabIndex = 4;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(897, 186);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // CadastroDeFuncionariosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 461);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.DgvFuncionarios);
            this.Controls.Add(this.BtnPesquisarPorId);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtUsuarioFuncionarioNome);
            this.Controls.Add(this.TxtUsuarioFuncionarioId);
            this.Name = "CadastroDeFuncionariosFrm";
            this.Text = "Cadastro De Funcionarios";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuarioFuncionarioId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterarRegistro;
        private System.Windows.Forms.Button BtnInserirFuncionario;
        private System.Windows.Forms.TextBox TxtUsuarioFuncionarioNome;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button BtnPesquisarPorId;
        private System.Windows.Forms.DataGridView DgvFuncionarios;
        private System.Windows.Forms.Button btnAtualizar;
    }
}