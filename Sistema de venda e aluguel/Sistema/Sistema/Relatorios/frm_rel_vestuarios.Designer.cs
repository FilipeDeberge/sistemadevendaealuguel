namespace Sistema.Relatorios
{
    partial class frm_rel_pedidos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbvestuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Sistema.DataSet();
            this.VestuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_vestuarioTableAdapter = new Sistema.DataSetTableAdapters.tb_vestuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbvestuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VestuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbvestuarioBindingSource
            // 
            this.tbvestuarioBindingSource.DataMember = "tb_vestuario";
            this.tbvestuarioBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VestuarioBindingSource
            // 
            this.VestuarioBindingSource.DataSource = typeof(void);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tbvestuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Relatorios.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(761, 532);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_vestuarioTableAdapter
            // 
            this.tb_vestuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frm_rel_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 532);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_rel_pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Pedidos";
            this.Load += new System.EventHandler(this.frm_rel_pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbvestuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VestuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VestuarioBindingSource;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource tbvestuarioBindingSource;
        private DataSetTableAdapters.tb_vestuarioTableAdapter tb_vestuarioTableAdapter;
    }
}