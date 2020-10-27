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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnPesquisarPorId = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.LblId.Location = new System.Drawing.Point(13, 133);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(19, 13);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Id:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(57, 175);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // BtnPesquisarPorId
            // 
            this.BtnPesquisarPorId.Location = new System.Drawing.Point(224, 128);
            this.BtnPesquisarPorId.Name = "BtnPesquisarPorId";
            this.BtnPesquisarPorId.Size = new System.Drawing.Size(116, 32);
            this.BtnPesquisarPorId.TabIndex = 3;
            this.BtnPesquisarPorId.Text = "Pesquisar por id";
            this.BtnPesquisarPorId.UseVisualStyleBackColor = true;
            // 
            // CadastroDeUsuariosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.BtnPesquisarPorId);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroDeUsuariosFrm";
            this.Text = "Cadastro De Usuarios";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnPesquisarPorId;
    }
}