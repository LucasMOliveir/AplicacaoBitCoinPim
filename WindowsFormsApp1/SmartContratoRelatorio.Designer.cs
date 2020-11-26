namespace WindowsFormsApp1
{
    partial class SmartContratoRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ContratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteContratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PimDBDataSet3 = new WindowsFormsApp1.PimDBDataSet3();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteTableAdapter = new WindowsFormsApp1.PimDBDataSet3TableAdapters.ClienteTableAdapter();
            this.ClienteContratoTableAdapter = new WindowsFormsApp1.PimDBDataSet3TableAdapters.ClienteContratoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ContratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteContratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PimDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ContratoBindingSource
            // 
            this.ContratoBindingSource.DataMember = "Contrato";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClienteContratoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.RelatorioSmartContrato.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 395);
            this.reportViewer1.TabIndex = 0;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(118, 29);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 20);
            this.BtnFiltrar.TabIndex = 1;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(12, 29);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.TxtIdCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id do clinete";
            // 
            // ClienteContratoBindingSource
            // 
            this.ClienteContratoBindingSource.DataMember = "ClienteContrato";
            this.ClienteContratoBindingSource.DataSource = this.PimDBDataSet3;
            // 
            // PimDBDataSet3
            // 
            this.PimDBDataSet3.DataSetName = "PimDBDataSet3";
            this.PimDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "Cliente";
            this.ClienteBindingSource.DataSource = this.PimDBDataSet3;
            // 
            // ClienteTableAdapter
            // 
            this.ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteContratoTableAdapter
            // 
            this.ClienteContratoTableAdapter.ClearBeforeFill = true;
            // 
            // SmartContratoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SmartContratoRelatorio";
            this.Text = "Relatorio - Smart contrato";
            this.Load += new System.EventHandler(this.SmartContratoRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteContratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PimDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ContratoBindingSource;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private PimDBDataSet3 PimDBDataSet3;
        private PimDBDataSet3TableAdapters.ClienteTableAdapter ClienteTableAdapter;
        private System.Windows.Forms.BindingSource ClienteContratoBindingSource;
        private PimDBDataSet3TableAdapters.ClienteContratoTableAdapter ClienteContratoTableAdapter;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label label1;
    }
}