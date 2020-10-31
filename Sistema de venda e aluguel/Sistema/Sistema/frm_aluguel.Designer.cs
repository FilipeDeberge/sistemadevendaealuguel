namespace Sistema
{
    partial class frm_aluguel
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
            System.Windows.Forms.Label codigoStatusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_aluguel));
            this.GP_alugar = new System.Windows.Forms.GroupBox();
            this.btn_verificador = new System.Windows.Forms.Button();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.alugarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.CB_pgto = new System.Windows.Forms.ComboBox();
            this.btn_finAluguel = new System.Windows.Forms.Button();
            this.data_devolucao = new System.Windows.Forms.DateTimePicker();
            this.data_entrega = new System.Windows.Forms.DateTimePicker();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_finPedido = new System.Windows.Forms.Button();
            this.btn_novoItem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_status = new System.Windows.Forms.ComboBox();
            this.tb_vestuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sistemaDataSet = new Sistema.db_sistemaDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_funcionario = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DG_aluguel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensAluguelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_vestuario = new System.Windows.Forms.ComboBox();
            this.itensAluguelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vestuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbvestuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vestuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itensAluguelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_alugar = new System.Windows.Forms.Button();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.tb_vestuarioTableAdapter = new Sistema.db_sistemaDataSetTableAdapters.tb_vestuarioTableAdapter();
            this.tableAdapterManager = new Sistema.db_sistemaDataSetTableAdapters.TableAdapterManager();
            this.itensAluguelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vestuarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_vestuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbitensalugarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_itens_alugarTableAdapter = new Sistema.db_sistemaDataSetTableAdapters.tb_itens_alugarTableAdapter();
            codigoStatusLabel = new System.Windows.Forms.Label();
            this.GP_alugar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alugarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vestuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_aluguel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvestuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vestuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbitensalugarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoStatusLabel
            // 
            codigoStatusLabel.AutoSize = true;
            codigoStatusLabel.Location = new System.Drawing.Point(646, 364);
            codigoStatusLabel.Name = "codigoStatusLabel";
            codigoStatusLabel.Size = new System.Drawing.Size(111, 13);
            codigoStatusLabel.TabIndex = 93;
            codigoStatusLabel.Text = "Forma de Pagamento:";
            // 
            // GP_alugar
            // 
            this.GP_alugar.Controls.Add(this.btn_verificador);
            this.GP_alugar.Controls.Add(this.txt_telefone);
            this.GP_alugar.Controls.Add(this.label12);
            this.GP_alugar.Controls.Add(this.txt_cliente);
            this.GP_alugar.Controls.Add(this.btn_registrar);
            this.GP_alugar.Controls.Add(codigoStatusLabel);
            this.GP_alugar.Controls.Add(this.CB_pgto);
            this.GP_alugar.Controls.Add(this.btn_finAluguel);
            this.GP_alugar.Controls.Add(this.data_devolucao);
            this.GP_alugar.Controls.Add(this.data_entrega);
            this.GP_alugar.Controls.Add(this.txt_total);
            this.GP_alugar.Controls.Add(this.label11);
            this.GP_alugar.Controls.Add(this.txt_desconto);
            this.GP_alugar.Controls.Add(this.label7);
            this.GP_alugar.Controls.Add(this.txt_sinal);
            this.GP_alugar.Controls.Add(this.label6);
            this.GP_alugar.Controls.Add(this.btn_imprimir);
            this.GP_alugar.Controls.Add(this.btn_finPedido);
            this.GP_alugar.Controls.Add(this.btn_novoItem);
            this.GP_alugar.Controls.Add(this.label10);
            this.GP_alugar.Controls.Add(this.CB_status);
            this.GP_alugar.Controls.Add(this.label3);
            this.GP_alugar.Controls.Add(this.CB_funcionario);
            this.GP_alugar.Controls.Add(this.label2);
            this.GP_alugar.Controls.Add(this.txt_codigo);
            this.GP_alugar.Controls.Add(this.label9);
            this.GP_alugar.Controls.Add(this.label8);
            this.GP_alugar.Controls.Add(this.DG_aluguel);
            this.GP_alugar.Controls.Add(this.txt_valor);
            this.GP_alugar.Controls.Add(this.label5);
            this.GP_alugar.Controls.Add(this.label4);
            this.GP_alugar.Controls.Add(this.label1);
            this.GP_alugar.Controls.Add(this.CB_vestuario);
            this.GP_alugar.Location = new System.Drawing.Point(13, 58);
            this.GP_alugar.Name = "GP_alugar";
            this.GP_alugar.Size = new System.Drawing.Size(851, 595);
            this.GP_alugar.TabIndex = 0;
            this.GP_alugar.TabStop = false;
            this.GP_alugar.Text = "Aluguel";
            // 
            // btn_verificador
            // 
            this.btn_verificador.BackColor = System.Drawing.Color.Transparent;
            this.btn_verificador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_verificador.FlatAppearance.BorderSize = 0;
            this.btn_verificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verificador.ForeColor = System.Drawing.Color.Black;
            this.btn_verificador.Image = global::Sistema.Properties.Resources.check2;
            this.btn_verificador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_verificador.Location = new System.Drawing.Point(231, 64);
            this.btn_verificador.Name = "btn_verificador";
            this.btn_verificador.Size = new System.Drawing.Size(155, 30);
            this.btn_verificador.TabIndex = 99;
            this.btn_verificador.Text = "Verificar disponibilidade";
            this.btn_verificador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_verificador.UseVisualStyleBackColor = false;
            this.btn_verificador.Click += new System.EventHandler(this.btn_verificador_Click);
            // 
            // txt_telefone
            // 
            this.txt_telefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alugarBindingSource, "Telefone", true));
            this.txt_telefone.Location = new System.Drawing.Point(706, 19);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(136, 20);
            this.txt_telefone.TabIndex = 98;
            // 
            // alugarBindingSource
            // 
            this.alugarBindingSource.DataSource = typeof(sistema.DAL.Alugar);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(678, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 97;
            this.label12.Text = "Tel:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alugarBindingSource, "Cliente", true));
            this.txt_cliente.Location = new System.Drawing.Point(408, 19);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(265, 20);
            this.txt_cliente.TabIndex = 96;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_registrar.ForeColor = System.Drawing.Color.Black;
            this.btn_registrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_registrar.Image")));
            this.btn_registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registrar.Location = new System.Drawing.Point(309, 528);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(187, 44);
            this.btn_registrar.TabIndex = 95;
            this.btn_registrar.Text = "Registrar Aluguel";
            this.btn_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // CB_pgto
            // 
            this.CB_pgto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alugarBindingSource, "FormaDePagamento", true));
            this.CB_pgto.DisplayMember = "Status";
            this.CB_pgto.Enabled = false;
            this.CB_pgto.FormattingEnabled = true;
            this.CB_pgto.Items.AddRange(new object[] {
            "Crédito",
            "Débito",
            "Dinheiro"});
            this.CB_pgto.Location = new System.Drawing.Point(759, 361);
            this.CB_pgto.Name = "CB_pgto";
            this.CB_pgto.Size = new System.Drawing.Size(80, 21);
            this.CB_pgto.TabIndex = 94;
            this.CB_pgto.ValueMember = "CodigoStatus";
            // 
            // btn_finAluguel
            // 
            this.btn_finAluguel.BackColor = System.Drawing.Color.Transparent;
            this.btn_finAluguel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_finAluguel.FlatAppearance.BorderSize = 0;
            this.btn_finAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_finAluguel.ForeColor = System.Drawing.Color.Black;
            this.btn_finAluguel.Image = ((System.Drawing.Image)(resources.GetObject("btn_finAluguel.Image")));
            this.btn_finAluguel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_finAluguel.Location = new System.Drawing.Point(668, 397);
            this.btn_finAluguel.Name = "btn_finAluguel";
            this.btn_finAluguel.Size = new System.Drawing.Size(168, 44);
            this.btn_finAluguel.TabIndex = 90;
            this.btn_finAluguel.Text = "Finalizar Aluguel";
            this.btn_finAluguel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_finAluguel.UseVisualStyleBackColor = false;
            this.btn_finAluguel.Click += new System.EventHandler(this.btn_finAluguel_Click);
            // 
            // data_devolucao
            // 
            this.data_devolucao.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alugarBindingSource, "Entrada", true));
            this.data_devolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_devolucao.Location = new System.Drawing.Point(735, 67);
            this.data_devolucao.Name = "data_devolucao";
            this.data_devolucao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.data_devolucao.Size = new System.Drawing.Size(101, 20);
            this.data_devolucao.TabIndex = 88;
            // 
            // data_entrega
            // 
            this.data_entrega.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alugarBindingSource, "Saida", true));
            this.data_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_entrega.Location = new System.Drawing.Point(515, 67);
            this.data_entrega.Name = "data_entrega";
            this.data_entrega.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.data_entrega.Size = new System.Drawing.Size(101, 20);
            this.data_entrega.TabIndex = 87;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(740, 319);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(96, 20);
            this.txt_total.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(696, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Total:";
            // 
            // txt_desconto
            // 
            this.txt_desconto.Location = new System.Drawing.Point(740, 276);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.Size = new System.Drawing.Size(96, 20);
            this.txt_desconto.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(675, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Desconto:";
            // 
            // txt_sinal
            // 
            this.txt_sinal.Location = new System.Drawing.Point(740, 236);
            this.txt_sinal.Name = "txt_sinal";
            this.txt_sinal.Size = new System.Drawing.Size(96, 20);
            this.txt_sinal.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(696, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "Sinal:";
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
            this.btn_imprimir.Location = new System.Drawing.Point(668, 448);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(168, 44);
            this.btn_imprimir.TabIndex = 80;
            this.btn_imprimir.Text = "Imprimir Nota";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
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
            this.btn_finPedido.Location = new System.Drawing.Point(668, 169);
            this.btn_finPedido.Name = "btn_finPedido";
            this.btn_finPedido.Size = new System.Drawing.Size(168, 44);
            this.btn_finPedido.TabIndex = 79;
            this.btn_finPedido.Text = "Finalizar Pedido";
            this.btn_finPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_finPedido.UseVisualStyleBackColor = false;
            this.btn_finPedido.Click += new System.EventHandler(this.btn_finpedido_Click);
            // 
            // btn_novoItem
            // 
            this.btn_novoItem.BackColor = System.Drawing.Color.Transparent;
            this.btn_novoItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_novoItem.BackgroundImage")));
            this.btn_novoItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_novoItem.FlatAppearance.BorderSize = 0;
            this.btn_novoItem.ForeColor = System.Drawing.Color.Transparent;
            this.btn_novoItem.Location = new System.Drawing.Point(556, 169);
            this.btn_novoItem.Name = "btn_novoItem";
            this.btn_novoItem.Size = new System.Drawing.Size(38, 37);
            this.btn_novoItem.TabIndex = 77;
            this.btn_novoItem.UseVisualStyleBackColor = false;
            this.btn_novoItem.Click += new System.EventHandler(this.btn_novoItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(645, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Disponível";
            // 
            // CB_status
            // 
            this.CB_status.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_vestuarioBindingSource, "disponibilidade", true));
            this.CB_status.FormattingEnabled = true;
            this.CB_status.Items.AddRange(new object[] {
            "SIM",
            "NAO"});
            this.CB_status.Location = new System.Drawing.Point(709, 107);
            this.CB_status.Name = "CB_status";
            this.CB_status.Size = new System.Drawing.Size(127, 21);
            this.CB_status.TabIndex = 75;
            // 
            // tb_vestuarioBindingSource
            // 
            this.tb_vestuarioBindingSource.DataMember = "tb_vestuario";
            this.tb_vestuarioBindingSource.DataSource = this.db_sistemaDataSet;
            // 
            // db_sistemaDataSet
            // 
            this.db_sistemaDataSet.DataSetName = "db_sistemaDataSet";
            this.db_sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Funcionário:";
            // 
            // CB_funcionario
            // 
            this.CB_funcionario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alugarBindingSource, "Funcionario.Nome", true));
            this.CB_funcionario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionarioBindingSource, "CodigoFuncionario", true));
            this.CB_funcionario.DataSource = this.funcionarioBindingSource;
            this.CB_funcionario.DisplayMember = "Nome";
            this.CB_funcionario.FormattingEnabled = true;
            this.CB_funcionario.Location = new System.Drawing.Point(220, 19);
            this.CB_funcionario.Name = "CB_funcionario";
            this.CB_funcionario.Size = new System.Drawing.Size(137, 21);
            this.CB_funcionario.TabIndex = 73;
            this.CB_funcionario.ValueMember = "CodigoFuncionario";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(sistema.DAL.Funcionario);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Data de devolução:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alugarBindingSource, "CodigoAlugar", true));
            this.txt_codigo.Location = new System.Drawing.Point(79, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(69, 20);
            this.txt_codigo.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Cod Pedido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Cliente:";
            // 
            // DG_aluguel
            // 
            this.DG_aluguel.AllowUserToAddRows = false;
            this.DG_aluguel.AllowUserToDeleteRows = false;
            this.DG_aluguel.AutoGenerateColumns = false;
            this.DG_aluguel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_aluguel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.Valor,
            this.ValorTotal});
            this.DG_aluguel.DataSource = this.itensAluguelBindingSource3;
            this.DG_aluguel.Location = new System.Drawing.Point(6, 169);
            this.DG_aluguel.Name = "DG_aluguel";
            this.DG_aluguel.ReadOnly = true;
            this.DG_aluguel.Size = new System.Drawing.Size(544, 317);
            this.DG_aluguel.TabIndex = 67;
            this.DG_aluguel.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DG_aluguel_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoVestuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodigoVestuario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vestuario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vestuario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // itensAluguelBindingSource3
            // 
            this.itensAluguelBindingSource3.DataSource = typeof(sistema.DAL.ItensAluguel);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(74, 108);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(101, 20);
            this.txt_valor.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Data de entrega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Vestuário:";
            // 
            // CB_vestuario
            // 
            this.CB_vestuario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensAluguelBindingSource, "CodigoVestuario", true));
            this.CB_vestuario.DataSource = this.vestuarioBindingSource1;
            this.CB_vestuario.DisplayMember = "Descricao";
            this.CB_vestuario.FormattingEnabled = true;
            this.CB_vestuario.Location = new System.Drawing.Point(73, 70);
            this.CB_vestuario.Name = "CB_vestuario";
            this.CB_vestuario.Size = new System.Drawing.Size(137, 21);
            this.CB_vestuario.TabIndex = 62;
            this.CB_vestuario.ValueMember = "CodigoVestuario";
            this.CB_vestuario.SelectedIndexChanged += new System.EventHandler(this.CB_vestuario_SelectedIndexChanged);
            // 
            // itensAluguelBindingSource
            // 
            this.itensAluguelBindingSource.DataSource = typeof(sistema.DAL.ItensAluguel);
            // 
            // vestuarioBindingSource1
            // 
            this.vestuarioBindingSource1.DataSource = typeof(sistema.DAL.Vestuario);
            // 
            // tbvestuarioBindingSource
            // 
            this.tbvestuarioBindingSource.DataMember = "tb_vestuario";
            this.tbvestuarioBindingSource.DataSource = this.db_sistemaDataSet;
            // 
            // vestuarioBindingSource
            // 
            this.vestuarioBindingSource.DataSource = typeof(sistema.DAL.Vestuario);
            // 
            // itensAluguelBindingSource1
            // 
            this.itensAluguelBindingSource1.DataMember = "ItensAluguel";
            this.itensAluguelBindingSource1.DataSource = this.alugarBindingSource;
            // 
            // btn_alugar
            // 
            this.btn_alugar.BackColor = System.Drawing.Color.Transparent;
            this.btn_alugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_alugar.FlatAppearance.BorderSize = 0;
            this.btn_alugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_alugar.ForeColor = System.Drawing.Color.Black;
            this.btn_alugar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alugar.Image")));
            this.btn_alugar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alugar.Location = new System.Drawing.Point(409, 12);
            this.btn_alugar.Name = "btn_alugar";
            this.btn_alugar.Size = new System.Drawing.Size(100, 44);
            this.btn_alugar.TabIndex = 80;
            this.btn_alugar.Text = "Alugar";
            this.btn_alugar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alugar.UseVisualStyleBackColor = false;
            this.btn_alugar.Click += new System.EventHandler(this.btn_alugar_Click);
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.documento_PrintPage);
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
            // itensAluguelBindingSource2
            // 
            this.itensAluguelBindingSource2.DataMember = "ItensAluguel";
            this.itensAluguelBindingSource2.DataSource = this.alugarBindingSource;
            // 
            // vestuarioBindingSource2
            // 
            this.vestuarioBindingSource2.DataSource = typeof(sistema.DAL.Vestuario);
            // 
            // tb_vestuarioBindingSource1
            // 
            this.tb_vestuarioBindingSource1.DataMember = "tb_vestuario";
            this.tb_vestuarioBindingSource1.DataSource = this.db_sistemaDataSet;
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
            // frm_aluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 661);
            this.Controls.Add(this.btn_alugar);
            this.Controls.Add(this.GP_alugar);
            this.Name = "frm_aluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluguel de Vestuário";
            this.Load += new System.EventHandler(this.frm_aluguel_Load);
            this.GP_alugar.ResumeLayout(false);
            this.GP_alugar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alugarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vestuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_aluguel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvestuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensAluguelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vestuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbitensalugarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GP_alugar;
        private System.Windows.Forms.DateTimePicker data_devolucao;
        private System.Windows.Forms.DateTimePicker data_entrega;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_finPedido;
        private System.Windows.Forms.Button btn_novoItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CB_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DG_aluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_vestuario;
        private System.Windows.Forms.Button btn_alugar;
        private System.Windows.Forms.Button btn_finAluguel;
        private System.Windows.Forms.ComboBox CB_pgto;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoVestuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vestuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label label12;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.BindingSource itensAluguelBindingSource;
        private System.Windows.Forms.BindingSource alugarBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.BindingSource itensAluguelBindingSource1;
        private System.Windows.Forms.Button btn_verificador;
        private db_sistemaDataSet db_sistemaDataSet;
        private System.Windows.Forms.BindingSource tb_vestuarioBindingSource;
        private db_sistemaDataSetTableAdapters.tb_vestuarioTableAdapter tb_vestuarioTableAdapter;
        private db_sistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource itensAluguelBindingSource3;
        private System.Windows.Forms.BindingSource itensAluguelBindingSource2;
        private System.Windows.Forms.BindingSource tbvestuarioBindingSource;
        private System.Windows.Forms.BindingSource vestuarioBindingSource;
        private System.Windows.Forms.BindingSource vestuarioBindingSource1;
        private System.Windows.Forms.BindingSource tb_vestuarioBindingSource1;
        private System.Windows.Forms.BindingSource vestuarioBindingSource2;
        private System.Windows.Forms.ComboBox CB_funcionario;
        private System.Windows.Forms.BindingSource tbitensalugarBindingSource;
        private db_sistemaDataSetTableAdapters.tb_itens_alugarTableAdapter tb_itens_alugarTableAdapter;
    }
}