namespace Sistema
{
    partial class frm_consulta_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consulta_clientes));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.db_sistemaDataSet = new Sistema.db_sistemaDataSet();
            this.tb_aluguelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_aluguelTableAdapter = new Sistema.db_sistemaDataSetTableAdapters.tb_aluguelTableAdapter();
            this.tableAdapterManager = new Sistema.db_sistemaDataSetTableAdapters.TableAdapterManager();
            this.tb_aluguelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tb_aluguelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_aluguelDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.idaluguelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vestuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalgeralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltapagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataaluguelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formadepagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conheceuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_aluguelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_aluguelBindingNavigator)).BeginInit();
            this.tb_aluguelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_aluguelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(158, 40);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(184, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite aqui o CPF do cliente:";
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
            this.tableAdapterManager.UpdateOrder = Sistema.db_sistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_aluguelBindingNavigator
            // 
            this.tb_aluguelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_aluguelBindingNavigator.BindingSource = this.tb_aluguelBindingSource;
            this.tb_aluguelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_aluguelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_aluguelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_aluguelBindingNavigatorSaveItem});
            this.tb_aluguelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_aluguelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_aluguelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_aluguelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_aluguelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_aluguelBindingNavigator.Name = "tb_aluguelBindingNavigator";
            this.tb_aluguelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_aluguelBindingNavigator.Size = new System.Drawing.Size(1233, 25);
            this.tb_aluguelBindingNavigator.TabIndex = 2;
            this.tb_aluguelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // tb_aluguelBindingNavigatorSaveItem
            // 
            this.tb_aluguelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_aluguelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_aluguelBindingNavigatorSaveItem.Image")));
            this.tb_aluguelBindingNavigatorSaveItem.Name = "tb_aluguelBindingNavigatorSaveItem";
            this.tb_aluguelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_aluguelBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_aluguelBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_aluguelBindingNavigatorSaveItem_Click);
            // 
            // tb_aluguelDataGridView
            // 
            this.tb_aluguelDataGridView.AllowUserToAddRows = false;
            this.tb_aluguelDataGridView.AllowUserToDeleteRows = false;
            this.tb_aluguelDataGridView.AutoGenerateColumns = false;
            this.tb_aluguelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_aluguelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idaluguelDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.vestuarioDataGridViewTextBoxColumn,
            this.entradaDataGridViewTextBoxColumn,
            this.saidaDataGridViewTextBoxColumn,
            this.totalgeralDataGridViewTextBoxColumn,
            this.faltapagarDataGridViewTextBoxColumn,
            this.sinalDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.dataaluguelDataGridViewTextBoxColumn,
            this.formadepagamentoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.funcionarioDataGridViewTextBoxColumn,
            this.conheceuDataGridViewTextBoxColumn});
            this.tb_aluguelDataGridView.DataSource = this.tb_aluguelBindingSource;
            this.tb_aluguelDataGridView.Location = new System.Drawing.Point(8, 72);
            this.tb_aluguelDataGridView.Name = "tb_aluguelDataGridView";
            this.tb_aluguelDataGridView.Size = new System.Drawing.Size(1094, 328);
            this.tb_aluguelDataGridView.TabIndex = 3;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(348, 38);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(93, 23);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // idaluguelDataGridViewTextBoxColumn
            // 
            this.idaluguelDataGridViewTextBoxColumn.DataPropertyName = "id_aluguel";
            this.idaluguelDataGridViewTextBoxColumn.HeaderText = "Contrato";
            this.idaluguelDataGridViewTextBoxColumn.Name = "idaluguelDataGridViewTextBoxColumn";
            this.idaluguelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // vestuarioDataGridViewTextBoxColumn
            // 
            this.vestuarioDataGridViewTextBoxColumn.DataPropertyName = "vestuario";
            this.vestuarioDataGridViewTextBoxColumn.HeaderText = "Vestuario";
            this.vestuarioDataGridViewTextBoxColumn.Name = "vestuarioDataGridViewTextBoxColumn";
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            this.entradaDataGridViewTextBoxColumn.DataPropertyName = "entrada";
            this.entradaDataGridViewTextBoxColumn.HeaderText = "Devolução";
            this.entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            // 
            // saidaDataGridViewTextBoxColumn
            // 
            this.saidaDataGridViewTextBoxColumn.DataPropertyName = "saida";
            this.saidaDataGridViewTextBoxColumn.HeaderText = "Retirada";
            this.saidaDataGridViewTextBoxColumn.Name = "saidaDataGridViewTextBoxColumn";
            // 
            // totalgeralDataGridViewTextBoxColumn
            // 
            this.totalgeralDataGridViewTextBoxColumn.DataPropertyName = "total_geral";
            this.totalgeralDataGridViewTextBoxColumn.HeaderText = "Total Geral";
            this.totalgeralDataGridViewTextBoxColumn.Name = "totalgeralDataGridViewTextBoxColumn";
            // 
            // faltapagarDataGridViewTextBoxColumn
            // 
            this.faltapagarDataGridViewTextBoxColumn.DataPropertyName = "falta_pagar";
            this.faltapagarDataGridViewTextBoxColumn.HeaderText = "Falta Pagar";
            this.faltapagarDataGridViewTextBoxColumn.Name = "faltapagarDataGridViewTextBoxColumn";
            // 
            // sinalDataGridViewTextBoxColumn
            // 
            this.sinalDataGridViewTextBoxColumn.DataPropertyName = "sinal";
            this.sinalDataGridViewTextBoxColumn.HeaderText = "Sinal";
            this.sinalDataGridViewTextBoxColumn.Name = "sinalDataGridViewTextBoxColumn";
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            // 
            // dataaluguelDataGridViewTextBoxColumn
            // 
            this.dataaluguelDataGridViewTextBoxColumn.DataPropertyName = "data_aluguel";
            this.dataaluguelDataGridViewTextBoxColumn.HeaderText = "Data do Aluguel";
            this.dataaluguelDataGridViewTextBoxColumn.Name = "dataaluguelDataGridViewTextBoxColumn";
            // 
            // formadepagamentoDataGridViewTextBoxColumn
            // 
            this.formadepagamentoDataGridViewTextBoxColumn.DataPropertyName = "forma_de_pagamento";
            this.formadepagamentoDataGridViewTextBoxColumn.HeaderText = "Forma de Pgto";
            this.formadepagamentoDataGridViewTextBoxColumn.Name = "formadepagamentoDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
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
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data do Evento";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // funcionarioDataGridViewTextBoxColumn
            // 
            this.funcionarioDataGridViewTextBoxColumn.DataPropertyName = "funcionario";
            this.funcionarioDataGridViewTextBoxColumn.HeaderText = "funcionario";
            this.funcionarioDataGridViewTextBoxColumn.Name = "funcionarioDataGridViewTextBoxColumn";
            // 
            // conheceuDataGridViewTextBoxColumn
            // 
            this.conheceuDataGridViewTextBoxColumn.DataPropertyName = "conheceu";
            this.conheceuDataGridViewTextBoxColumn.HeaderText = "Como conheceu";
            this.conheceuDataGridViewTextBoxColumn.Name = "conheceuDataGridViewTextBoxColumn";
            // 
            // frm_consulta_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 450);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.tb_aluguelDataGridView);
            this.Controls.Add(this.tb_aluguelBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_consulta_clientes";
            this.Text = "Consulta Clientes CPF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_consulta_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_aluguelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_aluguelBindingNavigator)).EndInit();
            this.tb_aluguelBindingNavigator.ResumeLayout(false);
            this.tb_aluguelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_aluguelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private db_sistemaDataSet db_sistemaDataSet;
        private System.Windows.Forms.BindingSource tb_aluguelBindingSource;
        private db_sistemaDataSetTableAdapters.tb_aluguelTableAdapter tb_aluguelTableAdapter;
        private db_sistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_aluguelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_aluguelBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tb_aluguelDataGridView;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaluguelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vestuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalgeralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltapagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataaluguelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formadepagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conheceuDataGridViewTextBoxColumn;
    }
}