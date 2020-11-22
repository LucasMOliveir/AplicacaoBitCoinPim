namespace WindowsFormsApp1
{
    partial class RequisicoesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequisicoesFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnInserirRequisicao = new System.Windows.Forms.Button();
            this.TxtIdRequisicao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPesquisarId = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.DgvRequisicoes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisicoes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnAlterar);
            this.panel1.Controls.Add(this.BtnInserirRequisicao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 100);
            this.panel1.TabIndex = 0;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlterar.Image")));
            this.BtnAlterar.Location = new System.Drawing.Point(220, 3);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(211, 94);
            this.BtnAlterar.TabIndex = 0;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnInserirRequisicao
            // 
            this.BtnInserirRequisicao.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnInserirRequisicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInserirRequisicao.Image = ((System.Drawing.Image)(resources.GetObject("BtnInserirRequisicao.Image")));
            this.BtnInserirRequisicao.Location = new System.Drawing.Point(3, 3);
            this.BtnInserirRequisicao.Name = "BtnInserirRequisicao";
            this.BtnInserirRequisicao.Size = new System.Drawing.Size(211, 94);
            this.BtnInserirRequisicao.TabIndex = 0;
            this.BtnInserirRequisicao.Text = "Inserir";
            this.BtnInserirRequisicao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInserirRequisicao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInserirRequisicao.UseVisualStyleBackColor = false;
            this.BtnInserirRequisicao.Click += new System.EventHandler(this.BtnInserirRequisicao_Click);
            // 
            // TxtIdRequisicao
            // 
            this.TxtIdRequisicao.Location = new System.Drawing.Point(37, 123);
            this.TxtIdRequisicao.Name = "TxtIdRequisicao";
            this.TxtIdRequisicao.Size = new System.Drawing.Size(100, 20);
            this.TxtIdRequisicao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // BtnPesquisarId
            // 
            this.BtnPesquisarId.Location = new System.Drawing.Point(152, 118);
            this.BtnPesquisarId.Name = "BtnPesquisarId";
            this.BtnPesquisarId.Size = new System.Drawing.Size(80, 28);
            this.BtnPesquisarId.TabIndex = 3;
            this.BtnPesquisarId.Text = "Pesquisar id";
            this.BtnPesquisarId.UseVisualStyleBackColor = true;
            this.BtnPesquisarId.Click += new System.EventHandler(this.BtnPesquisarId_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(945, 206);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnAtualizar.TabIndex = 3;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // DgvRequisicoes
            // 
            this.DgvRequisicoes.AllowUserToAddRows = false;
            this.DgvRequisicoes.AllowUserToDeleteRows = false;
            this.DgvRequisicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRequisicoes.Location = new System.Drawing.Point(12, 235);
            this.DgvRequisicoes.Name = "DgvRequisicoes";
            this.DgvRequisicoes.ReadOnly = true;
            this.DgvRequisicoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRequisicoes.Size = new System.Drawing.Size(1008, 342);
            this.DgvRequisicoes.TabIndex = 4;
            // 
            // RequisicoesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 589);
            this.Controls.Add(this.DgvRequisicoes);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnPesquisarId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIdRequisicao);
            this.Controls.Add(this.panel1);
            this.Name = "RequisicoesFrm";
            this.Text = "Requisições";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisicoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnInserirRequisicao;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.TextBox TxtIdRequisicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPesquisarId;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.DataGridView DgvRequisicoes;
    }
}