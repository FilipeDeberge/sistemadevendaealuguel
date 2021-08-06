namespace Sistema
{
    partial class frm_venda
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
            System.Windows.Forms.Label codigoPessoaLabel;
            System.Windows.Forms.Label codigoVendaLabel;
            System.Windows.Forms.Label valorPagoLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label codigoStatusLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_venda));
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_novavenda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_finPedido = new System.Windows.Forms.Button();
            this.btn_finVenda = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.txt_itens = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_funcionario = new System.Windows.Forms.ComboBox();
            this.dt_venda = new System.Windows.Forms.DateTimePicker();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_valorTotal = new System.Windows.Forms.TextBox();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vestuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbfuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sistemaDataSet = new Sistema.db_sistemaDataSet();
            this.tb_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sistemaDataSet1 = new Sistema.db_sistemaDataSet1();
            this.tb_vendaTableAdapter = new Sistema.db_sistemaDataSet1TableAdapters.tb_vendaTableAdapter();
            this.tableAdapterManager = new Sistema.db_sistemaDataSet1TableAdapters.TableAdapterManager();
            this.tb_funcionariosTableAdapter = new Sistema.db_sistemaDataSetTableAdapters.tb_funcionariosTableAdapter();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.CB_pgto = new System.Windows.Forms.ComboBox();
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            codigoStatusLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Location = new System.Drawing.Point(214, 35);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(42, 13);
            codigoPessoaLabel.TabIndex = 1;
            codigoPessoaLabel.Text = "Cliente:";
            // 
            // codigoVendaLabel
            // 
            codigoVendaLabel.AutoSize = true;
            codigoVendaLabel.Location = new System.Drawing.Point(6, 35);
            codigoVendaLabel.Name = "codigoVendaLabel";
            codigoVendaLabel.Size = new System.Drawing.Size(77, 13);
            codigoVendaLabel.TabIndex = 0;
            codigoVendaLabel.Text = "Codigo Venda:";
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Location = new System.Drawing.Point(214, 384);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(58, 13);
            valorPagoLabel.TabIndex = 17;
            valorPagoLabel.Text = "Valor Total";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(71, 313);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(34, 13);
            valorLabel1.TabIndex = 16;
            valorLabel1.Text = "Valor:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(49, 347);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(56, 13);
            descontoLabel.TabIndex = 15;
            descontoLabel.Text = "Desconto:";
            // 
            // codigoStatusLabel
            // 
            codigoStatusLabel.AutoSize = true;
            codigoStatusLabel.Location = new System.Drawing.Point(279, 313);
            codigoStatusLabel.Name = "codigoStatusLabel";
            codigoStatusLabel.Size = new System.Drawing.Size(108, 13);
            codigoStatusLabel.TabIndex = 23;
            codigoStatusLabel.Text = "Forma de Pagamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(257, 79);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 13);
            label1.TabIndex = 28;
            label1.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 13);
            label2.TabIndex = 30;
            label2.Text = "Funcionário:";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(sistema.DAL.Venda);
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(sistema.DAL.Pessoas);
            // 
            // btn_novavenda
            // 
            this.btn_novavenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_novavenda.Image = ((System.Drawing.Image)(resources.GetObject("btn_novavenda.Image")));
            this.btn_novavenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novavenda.Location = new System.Drawing.Point(206, 12);
            this.btn_novavenda.Name = "btn_novavenda";
            this.btn_novavenda.Size = new System.Drawing.Size(109, 41);
            this.btn_novavenda.TabIndex = 3;
            this.btn_novavenda.Text = "Vender";
            this.btn_novavenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novavenda.UseVisualStyleBackColor = true;
            this.btn_novavenda.Click += new System.EventHandler(this.btn_novavenda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_pgto);
            this.groupBox1.Controls.Add(this.btn_finalizar);
            this.groupBox1.Controls.Add(this.btn_finPedido);
            this.groupBox1.Controls.Add(this.btn_finVenda);
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.txt_itens);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cb_funcionario);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.dt_venda);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Controls.Add(codigoPessoaLabel);
            this.groupBox1.Controls.Add(codigoStatusLabel);
            this.groupBox1.Controls.Add(this.txt_valorTotal);
            this.groupBox1.Controls.Add(this.txt_desconto);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(valorPagoLabel);
            this.groupBox1.Controls.Add(valorLabel1);
            this.groupBox1.Controls.Add(descontoLabel);
            this.groupBox1.Controls.Add(codigoVendaLabel);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 582);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas";
            this.groupBox1.Visible = false;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_finalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_finalizar.FlatAppearance.BorderSize = 0;
            this.btn_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.ForeColor = System.Drawing.Color.Black;
            this.btn_finalizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_finalizar.Image")));
            this.btn_finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_finalizar.Location = new System.Drawing.Point(151, 533);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(191, 40);
            this.btn_finalizar.TabIndex = 155;
            this.btn_finalizar.Text = "Registrar Venda";
            this.btn_finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click_1);
            // 
            // btn_finPedido
            // 
            this.btn_finPedido.BackColor = System.Drawing.Color.Transparent;
            this.btn_finPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_finPedido.FlatAppearance.BorderSize = 0;
            this.btn_finPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_finPedido.ForeColor = System.Drawing.Color.Black;
            this.btn_finPedido.Image = ((System.Drawing.Image)(resources.GetObject("btn_finPedido.Image")));
            this.btn_finPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_finPedido.Location = new System.Drawing.Point(169, 257);
            this.btn_finPedido.Name = "btn_finPedido";
            this.btn_finPedido.Size = new System.Drawing.Size(154, 34);
            this.btn_finPedido.TabIndex = 154;
            this.btn_finPedido.Text = "Finalizar Pedido";
            this.btn_finPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_finPedido.UseVisualStyleBackColor = false;
            this.btn_finPedido.Click += new System.EventHandler(this.btn_finPedido_Click_1);
            // 
            // btn_finVenda
            // 
            this.btn_finVenda.BackColor = System.Drawing.Color.Transparent;
            this.btn_finVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_finVenda.FlatAppearance.BorderSize = 0;
            this.btn_finVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_finVenda.ForeColor = System.Drawing.Color.Black;
            this.btn_finVenda.Image = ((System.Drawing.Image)(resources.GetObject("btn_finVenda.Image")));
            this.btn_finVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_finVenda.Location = new System.Drawing.Point(162, 426);
            this.btn_finVenda.Name = "btn_finVenda";
            this.btn_finVenda.Size = new System.Drawing.Size(168, 39);
            this.btn_finVenda.TabIndex = 153;
            this.btn_finVenda.Text = "Finalizar Venda";
            this.btn_finVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_finVenda.UseVisualStyleBackColor = false;
            this.btn_finVenda.Click += new System.EventHandler(this.btn_finVenda_Click_1);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.Black;
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimir.Location = new System.Drawing.Point(174, 478);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(141, 41);
            this.btn_imprimir.TabIndex = 152;
            this.btn_imprimir.Text = "Imprimir Nota";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // txt_itens
            // 
            this.txt_itens.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Vestuario", true));
            this.txt_itens.Location = new System.Drawing.Point(102, 134);
            this.txt_itens.Name = "txt_itens";
            this.txt_itens.Size = new System.Drawing.Size(282, 117);
            this.txt_itens.TabIndex = 151;
            this.txt_itens.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(179, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 16);
            this.label18.TabIndex = 150;
            this.label18.Text = "Vestuários Vendidos:";
            // 
            // cb_funcionario
            // 
            this.cb_funcionario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoFuncionario", true));
            this.cb_funcionario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Funcionario", true));
            this.cb_funcionario.FormattingEnabled = true;
            this.cb_funcionario.Items.AddRange(new object[] {
            "Pedro",
            "Cristiano",
            "Filipe"});
            this.cb_funcionario.Location = new System.Drawing.Point(79, 76);
            this.cb_funcionario.Name = "cb_funcionario";
            this.cb_funcionario.Size = new System.Drawing.Size(142, 21);
            this.cb_funcionario.TabIndex = 31;
            // 
            // dt_venda
            // 
            this.dt_venda.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendaBindingSource, "Data", true));
            this.dt_venda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Data", true));
            this.dt_venda.Location = new System.Drawing.Point(292, 76);
            this.dt_venda.Name = "dt_venda";
            this.dt_venda.Size = new System.Drawing.Size(121, 20);
            this.dt_venda.TabIndex = 29;
            this.dt_venda.Value = new System.DateTime(2021, 7, 3, 17, 38, 0, 0);
            // 
            // txt_cliente
            // 
            this.txt_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Cliente", true));
            this.txt_cliente.Location = new System.Drawing.Point(259, 32);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(187, 20);
            this.txt_cliente.TabIndex = 27;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(sistema.DAL.ContasReceber);
            // 
            // statusPagamentoBindingSource
            // 
            this.statusPagamentoBindingSource.DataSource = typeof(sistema.DAL.StatusPagamento);
            // 
            // txt_valorTotal
            // 
            this.txt_valorTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.txt_valorTotal.Location = new System.Drawing.Point(194, 400);
            this.txt_valorTotal.Name = "txt_valorTotal";
            this.txt_valorTotal.ReadOnly = true;
            this.txt_valorTotal.Size = new System.Drawing.Size(100, 20);
            this.txt_valorTotal.TabIndex = 20;
            // 
            // txt_desconto
            // 
            this.txt_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.txt_desconto.Location = new System.Drawing.Point(111, 344);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.Size = new System.Drawing.Size(100, 20);
            this.txt_desconto.TabIndex = 19;
            // 
            // txt_valor
            // 
            this.txt_valor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.txt_valor.Location = new System.Drawing.Point(111, 310);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 18;
            // 
            // txt_codigo
            // 
            this.txt_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CodigoVenda", true));
            this.txt_codigo.Location = new System.Drawing.Point(102, 32);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(sistema.DAL.ItensVenda);
            // 
            // vestuarioBindingSource
            // 
            this.vestuarioBindingSource.DataSource = typeof(sistema.DAL.Vestuario);
            // 
            // tbfuncionariosBindingSource
            // 
            this.tbfuncionariosBindingSource.DataMember = "tb_funcionarios";
            this.tbfuncionariosBindingSource.DataSource = this.db_sistemaDataSet;
            // 
            // db_sistemaDataSet
            // 
            this.db_sistemaDataSet.DataSetName = "db_sistemaDataSet";
            this.db_sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_vendaBindingSource
            // 
            this.tb_vendaBindingSource.DataMember = "tb_venda";
            this.tb_vendaBindingSource.DataSource = this.db_sistemaDataSet1;
            // 
            // db_sistemaDataSet1
            // 
            this.db_sistemaDataSet1.DataSetName = "db_sistemaDataSet1";
            this.db_sistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_vendaTableAdapter
            // 
            this.tb_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_ajustarTableAdapter = null;
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
            // tb_funcionariosTableAdapter
            // 
            this.tb_funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.documento_PrintPage_1);
            // 
            // CB_pgto
            // 
            this.CB_pgto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "FormaDePagamento", true));
            this.CB_pgto.FormattingEnabled = true;
            this.CB_pgto.Items.AddRange(new object[] {
            "Crédito",
            "Débito",
            "Dinheiro",
            "Mais de 1 cartão"});
            this.CB_pgto.Location = new System.Drawing.Point(266, 329);
            this.CB_pgto.Name = "CB_pgto";
            this.CB_pgto.Size = new System.Drawing.Size(128, 21);
            this.CB_pgto.TabIndex = 156;
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(514, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_novavenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.Button btn_novavenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.BindingSource vestuarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox txt_valorTotal;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.BindingSource statusPagamentoBindingSource;
        private System.Windows.Forms.DateTimePicker dt_venda;
        private System.Windows.Forms.TextBox txt_cliente;
        private db_sistemaDataSet1 db_sistemaDataSet1;
        private System.Windows.Forms.BindingSource tb_vendaBindingSource;
        private db_sistemaDataSet1TableAdapters.tb_vendaTableAdapter tb_vendaTableAdapter;
        private db_sistemaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cb_funcionario;
        private db_sistemaDataSet db_sistemaDataSet;
        private System.Windows.Forms.BindingSource tbfuncionariosBindingSource;
        private db_sistemaDataSetTableAdapters.tb_funcionariosTableAdapter tb_funcionariosTableAdapter;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.RichTextBox txt_itens;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_finVenda;
        private System.Windows.Forms.Button btn_finPedido;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.ComboBox CB_pgto;
    }
}