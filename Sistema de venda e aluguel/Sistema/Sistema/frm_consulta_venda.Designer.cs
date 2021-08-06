namespace Sistema
{
    partial class frm_consulta_venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consulta_venda));
            this.db_sistemaDataSet1 = new Sistema.db_sistemaDataSet1();
            this.tb_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_vendaTableAdapter = new Sistema.db_sistemaDataSet1TableAdapters.tb_vendaTableAdapter();
            this.tableAdapterManager = new Sistema.db_sistemaDataSet1TableAdapters.TableAdapterManager();
            this.tb_vendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_vendaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_vendaDataGridView = new System.Windows.Forms.DataGridView();
            this.tbitensvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_itens_vendaTableAdapter = new Sistema.db_sistemaDataSet1TableAdapters.tb_itens_vendaTableAdapter();
            this.db_sistemaDataNovo = new Sistema.db_sistemaDataNovo();
            this.tbvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_vendaTableAdapter1 = new Sistema.db_sistemaDataNovoTableAdapters.tb_vendaTableAdapter();
            this.tbvendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingNavigator)).BeginInit();
            this.tb_vendaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbitensvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvendaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // db_sistemaDataSet1
            // 
            this.db_sistemaDataSet1.DataSetName = "db_sistemaDataSet1";
            this.db_sistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_vendaBindingSource
            // 
            this.tb_vendaBindingSource.DataMember = "tb_venda";
            this.tb_vendaBindingSource.DataSource = this.db_sistemaDataSet1;
            // 
            // tb_vendaTableAdapter
            // 
            this.tb_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_aluguelTableAdapter = null;
            this.tableAdapterManager.tb_categoriaTableAdapter = null;
            this.tableAdapterManager.tb_contas_receberTableAdapter = null;
            this.tableAdapterManager.tb_funcionariosTableAdapter = null;
            this.tableAdapterManager.tb_itens_alugarTableAdapter = null;
            this.tableAdapterManager.tb_itens_vendaTableAdapter = null;
            this.tableAdapterManager.tb_pessoaTableAdapter = null;
            this.tableAdapterManager.tb_status_pagamentoTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.tb_vendaTableAdapter = this.tb_vendaTableAdapter;
            this.tableAdapterManager.tb_vestuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema.db_sistemaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_vendaBindingNavigator
            // 
            this.tb_vendaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_vendaBindingNavigator.BindingSource = this.tb_vendaBindingSource;
            this.tb_vendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_vendaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_vendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_vendaBindingNavigatorSaveItem});
            this.tb_vendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_vendaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_vendaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_vendaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_vendaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_vendaBindingNavigator.Name = "tb_vendaBindingNavigator";
            this.tb_vendaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_vendaBindingNavigator.Size = new System.Drawing.Size(742, 25);
            this.tb_vendaBindingNavigator.TabIndex = 0;
            this.tb_vendaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_vendaBindingNavigatorSaveItem
            // 
            this.tb_vendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_vendaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_vendaBindingNavigatorSaveItem.Image")));
            this.tb_vendaBindingNavigatorSaveItem.Name = "tb_vendaBindingNavigatorSaveItem";
            this.tb_vendaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_vendaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_vendaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_vendaBindingNavigatorSaveItem_Click);
            // 
            // tb_vendaDataGridView
            // 
            this.tb_vendaDataGridView.AutoGenerateColumns = false;
            this.tb_vendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_vendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.data,
            this.cliente,
            this.dataGridViewTextBoxColumn2,
            this.valor_pago,
            this.desconto,
            this.funcionario});
            this.tb_vendaDataGridView.DataSource = this.tbvendaBindingSource1;
            this.tb_vendaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_vendaDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tb_vendaDataGridView.Name = "tb_vendaDataGridView";
            this.tb_vendaDataGridView.Size = new System.Drawing.Size(742, 425);
            this.tb_vendaDataGridView.TabIndex = 1;
            // 
            // tbitensvendaBindingSource
            // 
            this.tbitensvendaBindingSource.DataMember = "tb_itens_venda";
            this.tbitensvendaBindingSource.DataSource = this.db_sistemaDataSet1;
            // 
            // tb_itens_vendaTableAdapter
            // 
            this.tb_itens_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // db_sistemaDataNovo
            // 
            this.db_sistemaDataNovo.DataSetName = "db_sistemaDataNovo";
            this.db_sistemaDataNovo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbvendaBindingSource
            // 
            this.tbvendaBindingSource.DataMember = "tb_venda";
            this.tbvendaBindingSource.DataSource = this.db_sistemaDataNovo;
            // 
            // tb_vendaTableAdapter1
            // 
            this.tb_vendaTableAdapter1.ClearBeforeFill = true;
            // 
            // tbvendaBindingSource1
            // 
            this.tbvendaBindingSource1.DataMember = "tb_venda";
            this.tbvendaBindingSource1.DataSource = this.db_sistemaDataNovo;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_venda";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_venda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "data";
            this.data.Name = "data";
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "cliente";
            this.cliente.Name = "cliente";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn2.HeaderText = "valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // valor_pago
            // 
            this.valor_pago.DataPropertyName = "valor_pago";
            this.valor_pago.HeaderText = "valor_pago";
            this.valor_pago.Name = "valor_pago";
            // 
            // desconto
            // 
            this.desconto.DataPropertyName = "desconto";
            this.desconto.HeaderText = "desconto";
            this.desconto.Name = "desconto";
            // 
            // funcionario
            // 
            this.funcionario.DataPropertyName = "funcionario";
            this.funcionario.HeaderText = "funcionario";
            this.funcionario.Name = "funcionario";
            // 
            // frm_consulta_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.tb_vendaDataGridView);
            this.Controls.Add(this.tb_vendaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_consulta_venda";
            this.Text = "Consulta de Vendas";
            this.Load += new System.EventHandler(this.frm_consulta_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingNavigator)).EndInit();
            this.tb_vendaBindingNavigator.ResumeLayout(false);
            this.tb_vendaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbitensvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvendaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_sistemaDataSet1 db_sistemaDataSet1;
        private System.Windows.Forms.BindingSource tb_vendaBindingSource;
        private db_sistemaDataSet1TableAdapters.tb_vendaTableAdapter tb_vendaTableAdapter;
        private db_sistemaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_vendaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_vendaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tb_vendaDataGridView;
        private System.Windows.Forms.BindingSource tbitensvendaBindingSource;
        private db_sistemaDataSet1TableAdapters.tb_itens_vendaTableAdapter tb_itens_vendaTableAdapter;
        private db_sistemaDataNovo db_sistemaDataNovo;
        private System.Windows.Forms.BindingSource tbvendaBindingSource;
        private db_sistemaDataNovoTableAdapters.tb_vendaTableAdapter tb_vendaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionario;
        private System.Windows.Forms.BindingSource tbvendaBindingSource1;
    }
}