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
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codigoVestuarioLabel;
            System.Windows.Forms.Label valorPagoLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label codigoStatusLabel;
            System.Windows.Forms.Label dataVencimentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_venda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CB_cliente = new System.Windows.Forms.ComboBox();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_novavenda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.txt_data_venc = new System.Windows.Forms.DateTimePicker();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CB_pgto = new System.Windows.Forms.ComboBox();
            this.statusPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_finVenda = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_finPedido = new System.Windows.Forms.Button();
            this.txt_valorTotal = new System.Windows.Forms.TextBox();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_novoitem = new System.Windows.Forms.Button();
            this.CB_vestuario = new System.Windows.Forms.ComboBox();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vestuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DG_vendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigoVestuarioLabel = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            codigoStatusLabel = new System.Windows.Forms.Label();
            dataVencimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Location = new System.Drawing.Point(388, 35);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(39, 13);
            codigoPessoaLabel.TabIndex = 1;
            codigoPessoaLabel.Text = "Cliente";
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
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(6, 91);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 2;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(6, 119);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 4;
            valorLabel.Text = "Valor:";
            // 
            // codigoVestuarioLabel
            // 
            codigoVestuarioLabel.AutoSize = true;
            codigoVestuarioLabel.Location = new System.Drawing.Point(6, 61);
            codigoVestuarioLabel.Name = "codigoVestuarioLabel";
            codigoVestuarioLabel.Size = new System.Drawing.Size(54, 13);
            codigoVestuarioLabel.TabIndex = 8;
            codigoVestuarioLabel.Text = "Vestuário:";
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Location = new System.Drawing.Point(11, 448);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(61, 13);
            valorPagoLabel.TabIndex = 17;
            valorPagoLabel.Text = "Valor Total:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(39, 380);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(34, 13);
            valorLabel1.TabIndex = 16;
            valorLabel1.Text = "Valor:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(17, 414);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(56, 13);
            descontoLabel.TabIndex = 15;
            descontoLabel.Text = "Desconto:";
            // 
            // codigoStatusLabel
            // 
            codigoStatusLabel.AutoSize = true;
            codigoStatusLabel.Location = new System.Drawing.Point(365, 381);
            codigoStatusLabel.Name = "codigoStatusLabel";
            codigoStatusLabel.Size = new System.Drawing.Size(111, 13);
            codigoStatusLabel.TabIndex = 23;
            codigoStatusLabel.Text = "Forma de Pagamento:";
            // 
            // dataVencimentoLabel
            // 
            dataVencimentoLabel.AutoSize = true;
            dataVencimentoLabel.Location = new System.Drawing.Point(365, 415);
            dataVencimentoLabel.Name = "dataVencimentoLabel";
            dataVencimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataVencimentoLabel.TabIndex = 24;
            dataVencimentoLabel.Text = "Data Vencimento:";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(sistema.DAL.Venda);
            // 
            // CB_cliente
            // 
            this.CB_cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.CB_cliente.DataSource = this.pessoasBindingSource;
            this.CB_cliente.DisplayMember = "Nome";
            this.CB_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_cliente.FormattingEnabled = true;
            this.CB_cliente.Location = new System.Drawing.Point(433, 31);
            this.CB_cliente.Name = "CB_cliente";
            this.CB_cliente.Size = new System.Drawing.Size(142, 21);
            this.CB_cliente.TabIndex = 2;
            this.CB_cliente.ValueMember = "CodigoPessoa";
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
            this.btn_novavenda.Location = new System.Drawing.Point(271, 12);
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
            this.groupBox1.Controls.Add(this.btn_finalizar);
            this.groupBox1.Controls.Add(dataVencimentoLabel);
            this.groupBox1.Controls.Add(codigoPessoaLabel);
            this.groupBox1.Controls.Add(this.txt_data_venc);
            this.groupBox1.Controls.Add(this.CB_cliente);
            this.groupBox1.Controls.Add(codigoStatusLabel);
            this.groupBox1.Controls.Add(this.CB_pgto);
            this.groupBox1.Controls.Add(this.btn_finVenda);
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.btn_finPedido);
            this.groupBox1.Controls.Add(this.txt_valorTotal);
            this.groupBox1.Controls.Add(this.txt_desconto);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(valorPagoLabel);
            this.groupBox1.Controls.Add(valorLabel1);
            this.groupBox1.Controls.Add(descontoLabel);
            this.groupBox1.Controls.Add(this.btn_novoitem);
            this.groupBox1.Controls.Add(codigoVestuarioLabel);
            this.groupBox1.Controls.Add(this.CB_vestuario);
            this.groupBox1.Controls.Add(this.DG_vendas);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.txt_quantidade);
            this.groupBox1.Controls.Add(codigoVendaLabel);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 492);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas";
            this.groupBox1.Visible = false;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finalizar.Enabled = false;
            this.btn_finalizar.Location = new System.Drawing.Point(479, 437);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(122, 49);
            this.btn_finalizar.TabIndex = 26;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // txt_data_venc
            // 
            this.txt_data_venc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "DataVencimento", true));
            this.txt_data_venc.Enabled = false;
            this.txt_data_venc.Location = new System.Drawing.Point(479, 411);
            this.txt_data_venc.Name = "txt_data_venc";
            this.txt_data_venc.Size = new System.Drawing.Size(121, 20);
            this.txt_data_venc.TabIndex = 25;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(sistema.DAL.ContasReceber);
            // 
            // CB_pgto
            // 
            this.CB_pgto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contasReceberBindingSource, "CodigoStatus", true));
            this.CB_pgto.DataSource = this.statusPagamentoBindingSource;
            this.CB_pgto.DisplayMember = "Status";
            this.CB_pgto.Enabled = false;
            this.CB_pgto.FormattingEnabled = true;
            this.CB_pgto.Location = new System.Drawing.Point(479, 379);
            this.CB_pgto.Name = "CB_pgto";
            this.CB_pgto.Size = new System.Drawing.Size(121, 21);
            this.CB_pgto.TabIndex = 24;
            this.CB_pgto.ValueMember = "CodigoStatus";
            this.CB_pgto.SelectedIndexChanged += new System.EventHandler(this.CB_pgto_SelectedIndexChanged);
            // 
            // statusPagamentoBindingSource
            // 
            this.statusPagamentoBindingSource.DataSource = typeof(sistema.DAL.StatusPagamento);
            // 
            // btn_finVenda
            // 
            this.btn_finVenda.Enabled = false;
            this.btn_finVenda.Location = new System.Drawing.Point(185, 411);
            this.btn_finVenda.Name = "btn_finVenda";
            this.btn_finVenda.Size = new System.Drawing.Size(101, 23);
            this.btn_finVenda.TabIndex = 23;
            this.btn_finVenda.Text = "Finalizar Venda";
            this.btn_finVenda.UseVisualStyleBackColor = true;
            this.btn_finVenda.Click += new System.EventHandler(this.btn_finVenda_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Location = new System.Drawing.Point(185, 445);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(101, 23);
            this.btn_imprimir.TabIndex = 22;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_finPedido
            // 
            this.btn_finPedido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_finPedido.Location = new System.Drawing.Point(185, 377);
            this.btn_finPedido.Name = "btn_finPedido";
            this.btn_finPedido.Size = new System.Drawing.Size(101, 23);
            this.btn_finPedido.TabIndex = 21;
            this.btn_finPedido.Text = "Finalizar Pedido";
            this.btn_finPedido.UseVisualStyleBackColor = false;
            this.btn_finPedido.Click += new System.EventHandler(this.btn_finPedido_Click);
            // 
            // txt_valorTotal
            // 
            this.txt_valorTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.txt_valorTotal.Location = new System.Drawing.Point(79, 445);
            this.txt_valorTotal.Name = "txt_valorTotal";
            this.txt_valorTotal.ReadOnly = true;
            this.txt_valorTotal.Size = new System.Drawing.Size(100, 20);
            this.txt_valorTotal.TabIndex = 20;
            // 
            // txt_desconto
            // 
            this.txt_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.txt_desconto.Location = new System.Drawing.Point(79, 411);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.ReadOnly = true;
            this.txt_desconto.Size = new System.Drawing.Size(100, 20);
            this.txt_desconto.TabIndex = 19;
            // 
            // txt_valor
            // 
            this.txt_valor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.txt_valor.Location = new System.Drawing.Point(79, 377);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 18;
            // 
            // btn_novoitem
            // 
            this.btn_novoitem.BackColor = System.Drawing.Color.Transparent;
            this.btn_novoitem.BackgroundImage = global::Sistema.Properties.Resources.Plus_36851;
            this.btn_novoitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_novoitem.Location = new System.Drawing.Point(228, 48);
            this.btn_novoitem.Name = "btn_novoitem";
            this.btn_novoitem.Size = new System.Drawing.Size(41, 39);
            this.btn_novoitem.TabIndex = 5;
            this.btn_novoitem.UseVisualStyleBackColor = false;
            this.btn_novoitem.Click += new System.EventHandler(this.btn_novoitem_Click);
            // 
            // CB_vestuario
            // 
            this.CB_vestuario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "CodigoVestuario", true));
            this.CB_vestuario.DataSource = this.vestuarioBindingSource;
            this.CB_vestuario.DisplayMember = "Descricao";
            this.CB_vestuario.FormattingEnabled = true;
            this.CB_vestuario.Location = new System.Drawing.Point(102, 58);
            this.CB_vestuario.Name = "CB_vestuario";
            this.CB_vestuario.Size = new System.Drawing.Size(100, 21);
            this.CB_vestuario.TabIndex = 9;
            this.CB_vestuario.ValueMember = "Codigo";
            this.CB_vestuario.SelectedIndexChanged += new System.EventHandler(this.CB_vestuario_SelectedIndexChanged);
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(sistema.DAL.ItensVenda);
            // 
            // vestuarioBindingSource
            // 
            this.vestuarioBindingSource.DataSource = typeof(sistema.DAL.Vestuario);
            // 
            // DG_vendas
            // 
            this.DG_vendas.AllowUserToAddRows = false;
            this.DG_vendas.AllowUserToDeleteRows = false;
            this.DG_vendas.AutoGenerateColumns = false;
            this.DG_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.DG_vendas.DataSource = this.itensVendaBindingSource;
            this.DG_vendas.Location = new System.Drawing.Point(0, 161);
            this.DG_vendas.Name = "DG_vendas";
            this.DG_vendas.ReadOnly = true;
            this.DG_vendas.Size = new System.Drawing.Size(601, 195);
            this.DG_vendas.TabIndex = 8;
            this.DG_vendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_vendas_CellContentClick);
            this.DG_vendas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DG_vendas_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoVestuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código Vestuário";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Vestuario";
            this.dataGridViewTextBoxColumn7.HeaderText = "Vestuário";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vestuarioBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(102, 116);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 5;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "Quantidade", true));
            this.txt_quantidade.Location = new System.Drawing.Point(102, 88);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(100, 20);
            this.txt_quantidade.TabIndex = 3;
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
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(633, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_novavenda);
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
            ((System.ComponentModel.ISupportInitialize)(this.DG_vendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox CB_cliente;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.Button btn_novavenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.DataGridView DG_vendas;
        private System.Windows.Forms.ComboBox CB_vestuario;
        private System.Windows.Forms.BindingSource vestuarioBindingSource;
        private System.Windows.Forms.Button btn_novoitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_finVenda;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_finPedido;
        private System.Windows.Forms.TextBox txt_valorTotal;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox CB_pgto;
        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.DateTimePicker txt_data_venc;
        private System.Windows.Forms.BindingSource statusPagamentoBindingSource;
    }
}