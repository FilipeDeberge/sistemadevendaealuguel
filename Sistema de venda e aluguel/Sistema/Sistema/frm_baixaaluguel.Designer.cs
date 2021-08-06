namespace Sistema
{
    partial class frm_baixaaluguel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_baixaaluguel));
            this.db_sistemaDataSet = new Sistema.db_sistemaDataSet();
            this.tb_vestuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_vestuarioTableAdapter = new Sistema.db_sistemaDataSetTableAdapters.tb_vestuarioTableAdapter();
            this.tableAdapterManager = new Sistema.db_sistemaDataSetTableAdapters.TableAdapterManager();
            this.tb_vestuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_vestuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tb_vestuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vestuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vestuarioBindingNavigator)).BeginInit();
            this.tb_vestuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vestuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // db_sistemaDataSet
            // 
            this.db_sistemaDataSet.DataSetName = "db_sistemaDataSet";
            this.db_sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_vestuarioBindingSource
            // 
            this.tb_vestuarioBindingSource.DataMember = "tb_vestuario";
            this.tb_vestuarioBindingSource.DataSource = this.db_sistemaDataSet;
            // 
            // tb_vestuarioTableAdapter
            // 
            this.tb_vestuarioTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tb_vendaTableAdapter = null;
            this.tableAdapterManager.tb_vestuarioTableAdapter = this.tb_vestuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Sistema.db_sistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_vestuarioBindingNavigator
            // 
            this.tb_vestuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_vestuarioBindingNavigator.BindingSource = this.tb_vestuarioBindingSource;
            this.tb_vestuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_vestuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_vestuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_vestuarioBindingNavigatorSaveItem});
            this.tb_vestuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_vestuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_vestuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_vestuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_vestuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_vestuarioBindingNavigator.Name = "tb_vestuarioBindingNavigator";
            this.tb_vestuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_vestuarioBindingNavigator.Size = new System.Drawing.Size(544, 25);
            this.tb_vestuarioBindingNavigator.TabIndex = 0;
            this.tb_vestuarioBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_vestuarioDataGridView
            // 
            this.tb_vestuarioDataGridView.AllowUserToDeleteRows = false;
            this.tb_vestuarioDataGridView.AutoGenerateColumns = false;
            this.tb_vestuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_vestuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.tb_vestuarioDataGridView.DataSource = this.tb_vestuarioBindingSource;
            this.tb_vestuarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_vestuarioDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tb_vestuarioDataGridView.Name = "tb_vestuarioDataGridView";
            this.tb_vestuarioDataGridView.Size = new System.Drawing.Size(544, 425);
            this.tb_vestuarioDataGridView.TabIndex = 1;
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
            // tb_vestuarioBindingNavigatorSaveItem
            // 
            this.tb_vestuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_vestuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_vestuarioBindingNavigatorSaveItem.Image")));
            this.tb_vestuarioBindingNavigatorSaveItem.Name = "tb_vestuarioBindingNavigatorSaveItem";
            this.tb_vestuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_vestuarioBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_vestuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_vestuarioBindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_vestuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Vestuário";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "desc_vestuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição Vestuário";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "disponibilidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Disponibilidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frm_baixaaluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.tb_vestuarioDataGridView);
            this.Controls.Add(this.tb_vestuarioBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_baixaaluguel";
            this.Text = "Baixa de Aluguel";
            this.Load += new System.EventHandler(this.frm_baixaaluguel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vestuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vestuarioBindingNavigator)).EndInit();
            this.tb_vestuarioBindingNavigator.ResumeLayout(false);
            this.tb_vestuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vestuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_sistemaDataSet db_sistemaDataSet;
        private System.Windows.Forms.BindingSource tb_vestuarioBindingSource;
        private db_sistemaDataSetTableAdapters.tb_vestuarioTableAdapter tb_vestuarioTableAdapter;
        private db_sistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_vestuarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_vestuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tb_vestuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}