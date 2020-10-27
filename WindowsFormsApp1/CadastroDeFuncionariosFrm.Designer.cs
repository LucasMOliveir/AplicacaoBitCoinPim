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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterarRegistro = new System.Windows.Forms.Button();
            this.BtnInserirFuncionario = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.BtnPesquisarPorId = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
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
            this.panel1.Size = new System.Drawing.Size(984, 100);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
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
            // 
            // CadastroDeFuncionariosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.BtnPesquisarPorId);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "CadastroDeFuncionariosFrm";
            this.Text = "Cadastro De Funcionarios";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterarRegistro;
        private System.Windows.Forms.Button BtnInserirFuncionario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button BtnPesquisarPorId;
    }
}