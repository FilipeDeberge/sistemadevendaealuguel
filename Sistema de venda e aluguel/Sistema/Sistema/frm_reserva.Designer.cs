namespace Sistema
{
    partial class frm_reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reserva));
            this.db_sistemaDataSet = new Sistema.db_sistemaDataSet();
            this.tb_aluguelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_aluguelTableAdapter = new Sistema.db_sistemaDataSetTableAdapters.tb_aluguelTableAdapter();
            this.tableAdapterManager = new Sistema.db_sistemaDataSetTableAdapters.TableAdapterManager();
            this.alugarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alugarDataGridView = new System.Windows.Forms.DataGridView();
            this.alugarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idaluguelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vestuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formadepagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_aluguelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alugarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alugarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alugarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // db_sistemaDataSet
            // 
            this.db_sistemaDataSet.DataSetName = "db_sistemaDataSet";
            this.db_sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_aluguelBindingSource
            // 
            this.tb_aluguelBindingSource.DataMember = "tb_aluguel";
            this.tb_aluguelBindingSource.DataSource = this.db_sistemaDataSet;
            // 
            // tb_aluguelTableAdapter
            // 
            this.tb_aluguelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            this.tableAdapterManager.UpdateOrder = Sistema.db_sistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alugarBindingSource
            // 
            this.alugarBindingSource.DataSource = typeof(sistema.DAL.Alugar);
            // 
            // alugarDataGridView
            // 
            this.alugarDataGridView.AutoGenerateColumns = false;
            this.alugarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alugarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idaluguelDataGridViewTextBoxColumn,
            this.vestuarioDataGridViewTextBoxColumn,
            this.entradaDataGridViewTextBoxColumn,
            this.saidaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.idpessoaDataGridViewTextBoxColumn,
            this.idfuncionarioDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.sinalDataGridViewTextBoxColumn,
            this.formadepagamentoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.diasDataGridViewTextBoxColumn});
            this.alugarDataGridView.DataSource = this.tb_aluguelBindingSource;
            this.alugarDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alugarDataGridView.Location = new System.Drawing.Point(0, 0);
            this.alugarDataGridView.Name = "alugarDataGridView";
            this.alugarDataGridView.Size = new System.Drawing.Size(1370, 450);
            this.alugarDataGridView.TabIndex = 0;
            // 
            // alugarBindingSource1
            // 
            this.alugarBindingSource1.DataSource = typeof(sistema.DAL.Alugar);
            // 
            // idaluguelDataGridViewTextBoxColumn
            // 
            this.idaluguelDataGridViewTextBoxColumn.DataPropertyName = "id_aluguel";
            this.idaluguelDataGridViewTextBoxColumn.HeaderText = "id_aluguel";
            this.idaluguelDataGridViewTextBoxColumn.Name = "idaluguelDataGridViewTextBoxColumn";
            this.idaluguelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vestuarioDataGridViewTextBoxColumn
            // 
            this.vestuarioDataGridViewTextBoxColumn.DataPropertyName = "vestuario";
            this.vestuarioDataGridViewTextBoxColumn.HeaderText = "vestuario";
            this.vestuarioDataGridViewTextBoxColumn.Name = "vestuarioDataGridViewTextBoxColumn";
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            this.entradaDataGridViewTextBoxColumn.DataPropertyName = "entrada";
            this.entradaDataGridViewTextBoxColumn.HeaderText = "entrada";
            this.entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            // 
            // saidaDataGridViewTextBoxColumn
            // 
            this.saidaDataGridViewTextBoxColumn.DataPropertyName = "saida";
            this.saidaDataGridViewTextBoxColumn.HeaderText = "saida";
            this.saidaDataGridViewTextBoxColumn.Name = "saidaDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // idpessoaDataGridViewTextBoxColumn
            // 
            this.idpessoaDataGridViewTextBoxColumn.DataPropertyName = "id_pessoa";
            this.idpessoaDataGridViewTextBoxColumn.HeaderText = "id_pessoa";
            this.idpessoaDataGridViewTextBoxColumn.Name = "idpessoaDataGridViewTextBoxColumn";
            // 
            // idfuncionarioDataGridViewTextBoxColumn
            // 
            this.idfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "id_funcionario";
            this.idfuncionarioDataGridViewTextBoxColumn.HeaderText = "id_funcionario";
            this.idfuncionarioDataGridViewTextBoxColumn.Name = "idfuncionarioDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "desconto";
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            // 
            // sinalDataGridViewTextBoxColumn
            // 
            this.sinalDataGridViewTextBoxColumn.DataPropertyName = "sinal";
            this.sinalDataGridViewTextBoxColumn.HeaderText = "sinal";
            this.sinalDataGridViewTextBoxColumn.Name = "sinalDataGridViewTextBoxColumn";
            // 
            // formadepagamentoDataGridViewTextBoxColumn
            // 
            this.formadepagamentoDataGridViewTextBoxColumn.DataPropertyName = "forma_de_pagamento";
            this.formadepagamentoDataGridViewTextBoxColumn.HeaderText = "forma_de_pagamento";
            this.formadepagamentoDataGridViewTextBoxColumn.Name = "formadepagamentoDataGridViewTextBoxColumn";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // diasDataGridViewTextBoxColumn
            // 
            this.diasDataGridViewTextBoxColumn.DataPropertyName = "dias";
            this.diasDataGridViewTextBoxColumn.HeaderText = "dias";
            this.diasDataGridViewTextBoxColumn.Name = "diasDataGridViewTextBoxColumn";
            // 
            // frm_reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.alugarDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_reserva";
            this.Text = "Consulta de Reserva";
            this.Load += new System.EventHandler(this.frm_reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_aluguelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alugarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alugarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alugarBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private db_sistemaDataSet db_sistemaDataSet;
        private System.Windows.Forms.BindingSource tb_aluguelBindingSource;
        private db_sistemaDataSetTableAdapters.tb_aluguelTableAdapter tb_aluguelTableAdapter;
        private db_sistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource alugarBindingSource;
        private System.Windows.Forms.DataGridView alugarDataGridView;
        private System.Windows.Forms.BindingSource alugarBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaluguelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vestuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formadepagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDataGridViewTextBoxColumn;
    }
}