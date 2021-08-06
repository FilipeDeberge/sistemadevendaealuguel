namespace Sistema
{
    partial class frm_itens_alugados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_itens_alugados));
            this.itensAluguelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itensAluguelDataGridView = new System.Windows.Forms.DataGridView();
            this.itensAluguelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.itensAluguelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.db_sistemaDataSet = new Sistema.db_sistemaDataSet();
            this.tbitensalugarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_itens_alugarTableAdapter = new Sistema.db_sistemaDataSetTableAdapters.tb_itens_alugarTableAdapter();
            this.idaluguelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvestuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iditemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelBindingNavigator)).BeginInit();
            this.itensAluguelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbitensalugarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itensAluguelBindingNavigator
            // 
            this.itensAluguelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itensAluguelBindingNavigator.BindingSource = this.itensAluguelBindingSource;
            this.itensAluguelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itensAluguelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itensAluguelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.itensAluguelBindingNavigatorSaveItem});
            this.itensAluguelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itensAluguelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itensAluguelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itensAluguelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itensAluguelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itensAluguelBindingNavigator.Name = "itensAluguelBindingNavigator";
            this.itensAluguelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itensAluguelBindingNavigator.Size = new System.Drawing.Size(645, 25);
            this.itensAluguelBindingNavigator.TabIndex = 0;
            this.itensAluguelBindingNavigator.Text = "bindingNavigator1";
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
            // itensAluguelDataGridView
            // 
            this.itensAluguelDataGridView.AllowUserToAddRows = false;
            this.itensAluguelDataGridView.AllowUserToDeleteRows = false;
            this.itensAluguelDataGridView.AutoGenerateColumns = false;
            this.itensAluguelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensAluguelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idaluguelDataGridViewTextBoxColumn,
            this.idvestuarioDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.iditemDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.itensAluguelDataGridView.DataSource = this.tbitensalugarBindingSource;
            this.itensAluguelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itensAluguelDataGridView.Location = new System.Drawing.Point(0, 25);
            this.itensAluguelDataGridView.Name = "itensAluguelDataGridView";
            this.itensAluguelDataGridView.ReadOnly = true;
            this.itensAluguelDataGridView.Size = new System.Drawing.Size(645, 425);
            this.itensAluguelDataGridView.TabIndex = 1;
            // 
            // itensAluguelBindingSource
            // 
            this.itensAluguelBindingSource.DataSource = typeof(sistema.DAL.ItensAluguel);
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
            // itensAluguelBindingNavigatorSaveItem
            // 
            this.itensAluguelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itensAluguelBindingNavigatorSaveItem.Enabled = false;
            this.itensAluguelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itensAluguelBindingNavigatorSaveItem.Image")));
            this.itensAluguelBindingNavigatorSaveItem.Name = "itensAluguelBindingNavigatorSaveItem";
            this.itensAluguelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.itensAluguelBindingNavigatorSaveItem.Text = "Salvar Dados";
            // 
            // db_sistemaDataSet
            // 
            this.db_sistemaDataSet.DataSetName = "db_sistemaDataSet";
            this.db_sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbitensalugarBindingSource
            // 
            this.tbitensalugarBindingSource.DataMember = "tb_itens_alugar";
            this.tbitensalugarBindingSource.DataSource = this.db_sistemaDataSet;
            // 
            // tb_itens_alugarTableAdapter
            // 
            this.tb_itens_alugarTableAdapter.ClearBeforeFill = true;
            // 
            // idaluguelDataGridViewTextBoxColumn
            // 
            this.idaluguelDataGridViewTextBoxColumn.DataPropertyName = "id_aluguel";
            this.idaluguelDataGridViewTextBoxColumn.HeaderText = "Código do Aluguel";
            this.idaluguelDataGridViewTextBoxColumn.Name = "idaluguelDataGridViewTextBoxColumn";
            this.idaluguelDataGridViewTextBoxColumn.ReadOnly = true;
            this.idaluguelDataGridViewTextBoxColumn.Width = 150;
            // 
            // idvestuarioDataGridViewTextBoxColumn
            // 
            this.idvestuarioDataGridViewTextBoxColumn.DataPropertyName = "id_vestuario";
            this.idvestuarioDataGridViewTextBoxColumn.HeaderText = "Código do Vestuario";
            this.idvestuarioDataGridViewTextBoxColumn.Name = "idvestuarioDataGridViewTextBoxColumn";
            this.idvestuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idvestuarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor do Item";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iditemDataGridViewTextBoxColumn
            // 
            this.iditemDataGridViewTextBoxColumn.DataPropertyName = "id_item";
            this.iditemDataGridViewTextBoxColumn.HeaderText = "id_item";
            this.iditemDataGridViewTextBoxColumn.Name = "iditemDataGridViewTextBoxColumn";
            this.iditemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_itens_alugados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.itensAluguelDataGridView);
            this.Controls.Add(this.itensAluguelBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_itens_alugados";
            this.Text = "Itens Alugados";
            this.Load += new System.EventHandler(this.frm_itens_alugados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelBindingNavigator)).EndInit();
            this.itensAluguelBindingNavigator.ResumeLayout(false);
            this.itensAluguelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbitensalugarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource itensAluguelBindingSource;
        private System.Windows.Forms.BindingNavigator itensAluguelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton itensAluguelBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView itensAluguelDataGridView;
        private db_sistemaDataSet db_sistemaDataSet;
        private System.Windows.Forms.BindingSource tbitensalugarBindingSource;
        private db_sistemaDataSetTableAdapters.tb_itens_alugarTableAdapter tb_itens_alugarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaluguelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvestuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iditemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
    }
}