namespace Sistema.Relatorios
{
    partial class frm_rel_aluguel
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetAtual = new Sistema.DataSetAtual();
            this.tbaluguelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_aluguelTableAdapter = new Sistema.DataSetAtualTableAdapters.tb_aluguelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaluguelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbaluguelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Relatorios.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(873, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetAtual
            // 
            this.dataSetAtual.DataSetName = "DataSetAtual";
            this.dataSetAtual.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbaluguelBindingSource
            // 
            this.tbaluguelBindingSource.DataMember = "tb_aluguel";
            this.tbaluguelBindingSource.DataSource = this.dataSetAtual;
            // 
            // tb_aluguelTableAdapter
            // 
            this.tb_aluguelTableAdapter.ClearBeforeFill = true;
            // 
            // frm_rel_aluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_rel_aluguel";
            this.Text = "frm_rel_aluguel";
            this.Load += new System.EventHandler(this.frm_rel_aluguel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaluguelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetAtual dataSetAtual;
        private System.Windows.Forms.BindingSource tbaluguelBindingSource;
        private DataSetAtualTableAdapters.tb_aluguelTableAdapter tb_aluguelTableAdapter;
    }
}