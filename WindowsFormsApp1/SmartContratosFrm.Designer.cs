namespace WindowsFormsApp1
{
    partial class SmartContratosFrm
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
            this.BtnAlterarContrato = new System.Windows.Forms.Button();
            this.BtnCadastrarContrato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdDoContrato = new System.Windows.Forms.TextBox();
            this.BtnConsultarPorId = new System.Windows.Forms.Button();
            this.DgvContratos = new System.Windows.Forms.DataGridView();
            this.BtnAtulizar = new System.Windows.Forms.Button();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRelatorio);
            this.panel1.Controls.Add(this.BtnAlterarContrato);
            this.panel1.Controls.Add(this.BtnCadastrarContrato);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 100);
            this.panel1.TabIndex = 0;
            // 
            // BtnAlterarContrato
            // 
            this.BtnAlterarContrato.Location = new System.Drawing.Point(157, 3);
            this.BtnAlterarContrato.Name = "BtnAlterarContrato";
            this.BtnAlterarContrato.Size = new System.Drawing.Size(152, 94);
            this.BtnAlterarContrato.TabIndex = 0;
            this.BtnAlterarContrato.Text = "Alterar Contrato";
            this.BtnAlterarContrato.UseVisualStyleBackColor = true;
            this.BtnAlterarContrato.Click += new System.EventHandler(this.BtnAlterarContrato_Click);
            // 
            // BtnCadastrarContrato
            // 
            this.BtnCadastrarContrato.Location = new System.Drawing.Point(3, 3);
            this.BtnCadastrarContrato.Name = "BtnCadastrarContrato";
            this.BtnCadastrarContrato.Size = new System.Drawing.Size(152, 94);
            this.BtnCadastrarContrato.TabIndex = 0;
            this.BtnCadastrarContrato.Text = "Cadastrar contrato";
            this.BtnCadastrarContrato.UseVisualStyleBackColor = true;
            this.BtnCadastrarContrato.Click += new System.EventHandler(this.BtnCadastrarContrato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id do contrado";
            // 
            // TxtIdDoContrato
            // 
            this.TxtIdDoContrato.Location = new System.Drawing.Point(94, 116);
            this.TxtIdDoContrato.Name = "TxtIdDoContrato";
            this.TxtIdDoContrato.Size = new System.Drawing.Size(140, 20);
            this.TxtIdDoContrato.TabIndex = 2;
            // 
            // BtnConsultarPorId
            // 
            this.BtnConsultarPorId.Location = new System.Drawing.Point(240, 114);
            this.BtnConsultarPorId.Name = "BtnConsultarPorId";
            this.BtnConsultarPorId.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultarPorId.TabIndex = 3;
            this.BtnConsultarPorId.Text = "Consultar por id";
            this.BtnConsultarPorId.UseVisualStyleBackColor = true;
            this.BtnConsultarPorId.Click += new System.EventHandler(this.BtnConsultarPorId_Click);
            // 
            // DgvContratos
            // 
            this.DgvContratos.AllowUserToAddRows = false;
            this.DgvContratos.AllowUserToDeleteRows = false;
            this.DgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContratos.Location = new System.Drawing.Point(13, 163);
            this.DgvContratos.Name = "DgvContratos";
            this.DgvContratos.ReadOnly = true;
            this.DgvContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvContratos.Size = new System.Drawing.Size(983, 325);
            this.DgvContratos.TabIndex = 4;
            // 
            // BtnAtulizar
            // 
            this.BtnAtulizar.Location = new System.Drawing.Point(920, 134);
            this.BtnAtulizar.Name = "BtnAtulizar";
            this.BtnAtulizar.Size = new System.Drawing.Size(75, 23);
            this.BtnAtulizar.TabIndex = 5;
            this.BtnAtulizar.Text = "Atualizar";
            this.BtnAtulizar.UseVisualStyleBackColor = true;
            this.BtnAtulizar.Click += new System.EventHandler(this.BtnAtulizar_Click);
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.Location = new System.Drawing.Point(311, 3);
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Size = new System.Drawing.Size(151, 94);
            this.BtnRelatorio.TabIndex = 1;
            this.BtnRelatorio.Text = "Relatorio";
            this.BtnRelatorio.UseVisualStyleBackColor = true;
            this.BtnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // SmartContratosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 500);
            this.Controls.Add(this.BtnAtulizar);
            this.Controls.Add(this.DgvContratos);
            this.Controls.Add(this.BtnConsultarPorId);
            this.Controls.Add(this.TxtIdDoContrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "SmartContratosFrm";
            this.Text = "Smart contratos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAlterarContrato;
        private System.Windows.Forms.Button BtnCadastrarContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdDoContrato;
        private System.Windows.Forms.Button BtnConsultarPorId;
        private System.Windows.Forms.DataGridView DgvContratos;
        private System.Windows.Forms.Button BtnAtulizar;
        private System.Windows.Forms.Button BtnRelatorio;
    }
}