namespace Sistema
{
    partial class frm_retiradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_retiradas));
            this.db_sistemaDataNovo = new Sistema.db_sistemaDataNovo();
            this.tb_aluguelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_aluguelTableAdapter = new Sistema.db_sistemaDataNovoTableAdapters.tb_aluguelTableAdapter();
            this.tableAdapterManager = new Sistema.db_sistemaDataNovoTableAdapters.TableAdapterManager();
            this.DG_retiradas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_aluguelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_retiradas)).BeginInit();
            this.SuspendLayout();
            // 
            // db_sistemaDataNovo
            // 
            this.db_sistemaDataNovo.DataSetName = "db_sistemaDataNovo";
            this.db_sistemaDataNovo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_aluguelBindingSource
            // 
            this.tb_aluguelBindingSource.DataMember = "tb_aluguel";
            this.tb_aluguelBindingSource.DataSource = this.db_sistemaDataNovo;
            // 
            // tb_aluguelTableAdapter
            // 
            this.tb_aluguelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_ajustarTableAdapter = null;
            this.tableAdapterManager.tb_aluguelTableAdapter = this.tb_aluguelTableAdapter;
            this.tableAdapterManager.tb_categoriaTableAdapter = null;
            this.tableAdapterManager.tb_contas_receberTableAdapter = null;
            this.tableAdapterManager.tb_funcionariosTableAdapter = null;
            this.tableAdapterManager.tb_itens_alugarTableAdapter = null;
            this.tableAdapterManager.tb_itens_vendaTableAdapter = null;
            this.tableAdapterManager.tb_pessoaTableAdapter = null;
            this.tableAdapterManager.tb_status_pagamentoTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.tb_vendaTableAdapter = null;
            this.tableAdapterManager.tb_vestuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema.db_sistemaDataNovoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DG_retiradas
            // 
            this.DG_retiradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_retiradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_retiradas.Location = new System.Drawing.Point(0, 0);
            this.DG_retiradas.Name = "DG_retiradas";
            this.DG_retiradas.Size = new System.Drawing.Size(800, 455);
            this.DG_retiradas.TabIndex = 0;
            // 
            // frm_retiradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.DG_retiradas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_retiradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Próximas Retiradas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_retiradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_aluguelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_retiradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private db_sistemaDataNovo db_sistemaDataNovo;
        private System.Windows.Forms.BindingSource tb_aluguelBindingSource;
        private db_sistemaDataNovoTableAdapters.tb_aluguelTableAdapter tb_aluguelTableAdapter;
        private db_sistemaDataNovoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView DG_retiradas;
    }
}