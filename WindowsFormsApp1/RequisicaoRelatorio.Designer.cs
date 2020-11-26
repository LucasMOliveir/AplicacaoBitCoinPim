namespace WindowsFormsApp1
{
    partial class RequisicaoRelatorio
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TxtIdDoCliente = new System.Windows.Forms.TextBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PimDBDataSetRequisicao = new WindowsFormsApp1.PimDBDataSetRequisicao();
            this.ClienteRequisicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteRequisicaoTableAdapter = new WindowsFormsApp1.PimDBDataSetRequisicaoTableAdapters.ClienteRequisicaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PimDBDataSetRequisicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteRequisicaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "RequisicaoCliente";
            reportDataSource2.Value = this.ClienteRequisicaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.RelatorioRequisicao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 384);
            this.reportViewer1.TabIndex = 0;
            // 
            // TxtIdDoCliente
            // 
            this.TxtIdDoCliente.Location = new System.Drawing.Point(15, 40);
            this.TxtIdDoCliente.Name = "TxtIdDoCliente";
            this.TxtIdDoCliente.Size = new System.Drawing.Size(100, 20);
            this.TxtIdDoCliente.TabIndex = 1;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(121, 40);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 20);
            this.BtnFiltrar.TabIndex = 2;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id do cliente";
            // 
            // PimDBDataSetRequisicao
            // 
            this.PimDBDataSetRequisicao.DataSetName = "PimDBDataSetRequisicao";
            this.PimDBDataSetRequisicao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClienteRequisicaoBindingSource
            // 
            this.ClienteRequisicaoBindingSource.DataMember = "ClienteRequisicao";
            this.ClienteRequisicaoBindingSource.DataSource = this.PimDBDataSetRequisicao;
            // 
            // ClienteRequisicaoTableAdapter
            // 
            this.ClienteRequisicaoTableAdapter.ClearBeforeFill = true;
            // 
            // RequisicaoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.TxtIdDoCliente);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RequisicaoRelatorio";
            this.Text = "Relatorio de requisição";
            this.Load += new System.EventHandler(this.RequisicaoRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PimDBDataSetRequisicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteRequisicaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox TxtIdDoCliente;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ClienteRequisicaoBindingSource;
        private PimDBDataSetRequisicao PimDBDataSetRequisicao;
        private PimDBDataSetRequisicaoTableAdapters.ClienteRequisicaoTableAdapter ClienteRequisicaoTableAdapter;
    }
}