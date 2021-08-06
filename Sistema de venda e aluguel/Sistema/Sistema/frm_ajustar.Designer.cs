namespace Sistema
{
    partial class frm_ajustar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ajustar));
            this.GP_ajustar = new System.Windows.Forms.GroupBox();
            this.txt_colete = new System.Windows.Forms.TextBox();
            this.tb_ajustarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sistemaDataSet = new Sistema.db_sistemaDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_calca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_paleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_total_geral = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.CB_pgto = new System.Windows.Forms.ComboBox();
            this.data_retirada = new System.Windows.Forms.DateTimePicker();
            this.data_ajuste = new System.Windows.Forms.DateTimePicker();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_funcionario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ajustarTableAdapter = new Sistema.db_sistemaDataSetTableAdapters.tb_ajustarTableAdapter();
            this.tableAdapterManager = new Sistema.db_sistemaDataSetTableAdapters.TableAdapterManager();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.ajustarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_finAjuste = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_finPedido = new System.Windows.Forms.Button();
            this.btn_ajustar = new System.Windows.Forms.Button();
            this.dataClasses1DataContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codigoStatusLabel = new System.Windows.Forms.Label();
            this.GP_ajustar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ajustarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajustarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClasses1DataContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoStatusLabel
            // 
            codigoStatusLabel.AutoSize = true;
            codigoStatusLabel.Location = new System.Drawing.Point(191, 391);
            codigoStatusLabel.Name = "codigoStatusLabel";
            codigoStatusLabel.Size = new System.Drawing.Size(111, 13);
            codigoStatusLabel.TabIndex = 93;
            codigoStatusLabel.Text = "Forma de Pagamento:";
            // 
            // GP_ajustar
            // 
            this.GP_ajustar.Controls.Add(this.txt_colete);
            this.GP_ajustar.Controls.Add(this.label10);
            this.GP_ajustar.Controls.Add(this.txt_calca);
            this.GP_ajustar.Controls.Add(this.label5);
            this.GP_ajustar.Controls.Add(this.txt_paleto);
            this.GP_ajustar.Controls.Add(this.label1);
            this.GP_ajustar.Controls.Add(this.txt_total_geral);
            this.GP_ajustar.Controls.Add(this.label19);
            this.GP_ajustar.Controls.Add(this.txt_email);
            this.GP_ajustar.Controls.Add(this.label16);
            this.GP_ajustar.Controls.Add(this.txt_cpf);
            this.GP_ajustar.Controls.Add(this.label15);
            this.GP_ajustar.Controls.Add(this.txt_endereco);
            this.GP_ajustar.Controls.Add(this.label14);
            this.GP_ajustar.Controls.Add(this.txt_rg);
            this.GP_ajustar.Controls.Add(this.label13);
            this.GP_ajustar.Controls.Add(this.txt_telefone);
            this.GP_ajustar.Controls.Add(this.label12);
            this.GP_ajustar.Controls.Add(this.txt_cliente);
            this.GP_ajustar.Controls.Add(this.btn_registrar);
            this.GP_ajustar.Controls.Add(codigoStatusLabel);
            this.GP_ajustar.Controls.Add(this.CB_pgto);
            this.GP_ajustar.Controls.Add(this.btn_finAjuste);
            this.GP_ajustar.Controls.Add(this.data_retirada);
            this.GP_ajustar.Controls.Add(this.data_ajuste);
            this.GP_ajustar.Controls.Add(this.txt_total);
            this.GP_ajustar.Controls.Add(this.label11);
            this.GP_ajustar.Controls.Add(this.txt_desconto);
            this.GP_ajustar.Controls.Add(this.label7);
            this.GP_ajustar.Controls.Add(this.txt_sinal);
            this.GP_ajustar.Controls.Add(this.label6);
            this.GP_ajustar.Controls.Add(this.btn_imprimir);
            this.GP_ajustar.Controls.Add(this.btn_finPedido);
            this.GP_ajustar.Controls.Add(this.label3);
            this.GP_ajustar.Controls.Add(this.CB_funcionario);
            this.GP_ajustar.Controls.Add(this.label2);
            this.GP_ajustar.Controls.Add(this.txt_codigo);
            this.GP_ajustar.Controls.Add(this.label9);
            this.GP_ajustar.Controls.Add(this.label8);
            this.GP_ajustar.Controls.Add(this.label4);
            this.GP_ajustar.Location = new System.Drawing.Point(4, 62);
            this.GP_ajustar.Name = "GP_ajustar";
            this.GP_ajustar.Size = new System.Drawing.Size(551, 598);
            this.GP_ajustar.TabIndex = 82;
            this.GP_ajustar.TabStop = false;
            this.GP_ajustar.Text = "Ajuste";
            // 
            // txt_colete
            // 
            this.txt_colete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "TamanhoColete", true));
            this.txt_colete.Location = new System.Drawing.Point(103, 209);
            this.txt_colete.Name = "txt_colete";
            this.txt_colete.Size = new System.Drawing.Size(110, 20);
            this.txt_colete.TabIndex = 157;
            // 
            // tb_ajustarBindingSource
            // 
            this.tb_ajustarBindingSource.DataMember = "tb_ajustar";
            this.tb_ajustarBindingSource.DataSource = this.db_sistemaDataSet;
            // 
            // db_sistemaDataSet
            // 
            this.db_sistemaDataSet.DataSetName = "db_sistemaDataSet";
            this.db_sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 156;
            this.label10.Text = "Tamanho Colete:";
            // 
            // txt_calca
            // 
            this.txt_calca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "TamanhoCalca", true));
            this.txt_calca.Location = new System.Drawing.Point(103, 175);
            this.txt_calca.Name = "txt_calca";
            this.txt_calca.Size = new System.Drawing.Size(110, 20);
            this.txt_calca.TabIndex = 155;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 154;
            this.label5.Text = "Tamanho Calça:";
            // 
            // txt_paleto
            // 
            this.txt_paleto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "TamanhoPaleto", true));
            this.txt_paleto.Location = new System.Drawing.Point(103, 142);
            this.txt_paleto.Name = "txt_paleto";
            this.txt_paleto.Size = new System.Drawing.Size(110, 20);
            this.txt_paleto.TabIndex = 153;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 152;
            this.label1.Text = "Tamanho Paleto:";
            // 
            // txt_total_geral
            // 
            this.txt_total_geral.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "TotalGeral", true));
            this.txt_total_geral.Location = new System.Drawing.Point(415, 353);
            this.txt_total_geral.Name = "txt_total_geral";
            this.txt_total_geral.Size = new System.Drawing.Size(96, 20);
            this.txt_total_geral.TabIndex = 151;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(348, 356);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 150;
            this.label19.Text = "Total Geral:";
            // 
            // txt_email
            // 
            this.txt_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "Email", true));
            this.txt_email.Location = new System.Drawing.Point(371, 89);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(140, 20);
            this.txt_email.TabIndex = 144;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(327, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 143;
            this.label16.Text = "E-mail:";
            // 
            // txt_cpf
            // 
            this.txt_cpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "Cpf", true));
            this.txt_cpf.Location = new System.Drawing.Point(54, 54);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(125, 20);
            this.txt_cpf.TabIndex = 97;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 97;
            this.label15.Text = "CPF:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "Endereco", true));
            this.txt_endereco.Location = new System.Drawing.Point(73, 89);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(231, 20);
            this.txt_endereco.TabIndex = 107;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 97;
            this.label14.Text = "Endereço:";
            // 
            // txt_rg
            // 
            this.txt_rg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "Rg", true));
            this.txt_rg.Location = new System.Drawing.Point(226, 54);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(96, 20);
            this.txt_rg.TabIndex = 102;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 101;
            this.label13.Text = "RG:";
            // 
            // txt_telefone
            // 
            this.txt_telefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "Telefone", true));
            this.txt_telefone.Location = new System.Drawing.Point(369, 54);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(110, 20);
            this.txt_telefone.TabIndex = 105;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(338, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 97;
            this.label12.Text = "Tel:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "Cliente", true));
            this.txt_cliente.Location = new System.Drawing.Point(222, 19);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(289, 20);
            this.txt_cliente.TabIndex = 96;
            // 
            // CB_pgto
            // 
            this.CB_pgto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "FormaDePagamento", true));
            this.CB_pgto.DisplayMember = "Status";
            this.CB_pgto.Enabled = false;
            this.CB_pgto.FormattingEnabled = true;
            this.CB_pgto.Items.AddRange(new object[] {
            "Crédito",
            "Débito",
            "Dinheiro",
            "Mais de 1 Cartão"});
            this.CB_pgto.Location = new System.Drawing.Point(312, 388);
            this.CB_pgto.Name = "CB_pgto";
            this.CB_pgto.Size = new System.Drawing.Size(122, 21);
            this.CB_pgto.TabIndex = 119;
            this.CB_pgto.ValueMember = "CodigoStatus";
            // 
            // data_retirada
            // 
            this.data_retirada.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ajustarBindingSource, "Retirada", true));
            this.data_retirada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_retirada.Location = new System.Drawing.Point(410, 205);
            this.data_retirada.Name = "data_retirada";
            this.data_retirada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.data_retirada.Size = new System.Drawing.Size(101, 20);
            this.data_retirada.TabIndex = 109;
            // 
            // data_ajuste
            // 
            this.data_ajuste.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ajustarBindingSource, "DataAjuste", true));
            this.data_ajuste.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_ajuste.Location = new System.Drawing.Point(410, 171);
            this.data_ajuste.Name = "data_ajuste";
            this.data_ajuste.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.data_ajuste.Size = new System.Drawing.Size(101, 20);
            this.data_ajuste.TabIndex = 108;
            // 
            // txt_total
            // 
            this.txt_total.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "FaltaPagar", true));
            this.txt_total.Location = new System.Drawing.Point(73, 388);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(96, 20);
            this.txt_total.TabIndex = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Falta Pagar:";
            // 
            // txt_desconto
            // 
            this.txt_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "Desconto", true));
            this.txt_desconto.Location = new System.Drawing.Point(237, 353);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.Size = new System.Drawing.Size(96, 20);
            this.txt_desconto.TabIndex = 117;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Desconto:";
            // 
            // txt_sinal
            // 
            this.txt_sinal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "Sinal", true));
            this.txt_sinal.Location = new System.Drawing.Point(55, 353);
            this.txt_sinal.Name = "txt_sinal";
            this.txt_sinal.Size = new System.Drawing.Size(96, 20);
            this.txt_sinal.TabIndex = 116;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "Sinal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Funcionário:";
            // 
            // CB_funcionario
            // 
            this.CB_funcionario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "Funcionario", true));
            this.CB_funcionario.FormattingEnabled = true;
            this.CB_funcionario.Items.AddRange(new object[] {
            "Pedro",
            "Cristiano",
            "Filipe"});
            this.CB_funcionario.Location = new System.Drawing.Point(382, 129);
            this.CB_funcionario.Name = "CB_funcionario";
            this.CB_funcionario.Size = new System.Drawing.Size(129, 21);
            this.CB_funcionario.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Data de Retirada:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajustarBindingSource, "CodigoAjustar", true));
            this.txt_codigo.Location = new System.Drawing.Point(73, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(69, 20);
            this.txt_codigo.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Contrato:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Data de Ajuste:";
            // 
            // tb_ajustarTableAdapter
            // 
            this.tb_ajustarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_ajustarTableAdapter = this.tb_ajustarTableAdapter;
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
            this.tableAdapterManager.tb_vestuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema.db_sistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ajustarBindingSource
            // 
            this.ajustarBindingSource.DataSource = typeof(sistema.DAL.Ajustar);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.Black;
            this.btn_registrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_registrar.Image")));
            this.btn_registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registrar.Location = new System.Drawing.Point(348, 536);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(195, 50);
            this.btn_registrar.TabIndex = 141;
            this.btn_registrar.Text = "Registrar Ajuste";
            this.btn_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click_1);
            // 
            // btn_finAjuste
            // 
            this.btn_finAjuste.BackColor = System.Drawing.Color.Transparent;
            this.btn_finAjuste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_finAjuste.FlatAppearance.BorderSize = 0;
            this.btn_finAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_finAjuste.ForeColor = System.Drawing.Color.Black;
            this.btn_finAjuste.Image = ((System.Drawing.Image)(resources.GetObject("btn_finAjuste.Image")));
            this.btn_finAjuste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_finAjuste.Location = new System.Drawing.Point(194, 453);
            this.btn_finAjuste.Name = "btn_finAjuste";
            this.btn_finAjuste.Size = new System.Drawing.Size(168, 44);
            this.btn_finAjuste.TabIndex = 120;
            this.btn_finAjuste.Text = "Finalizar Ajuste";
            this.btn_finAjuste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_finAjuste.UseVisualStyleBackColor = false;
            this.btn_finAjuste.Click += new System.EventHandler(this.btn_finAjuste_Click_1);
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
            this.btn_imprimir.Location = new System.Drawing.Point(16, 542);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(168, 44);
            this.btn_imprimir.TabIndex = 121;
            this.btn_imprimir.Text = "Imprimir Nota";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click_1);
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
            this.btn_finPedido.Location = new System.Drawing.Point(194, 271);
            this.btn_finPedido.Name = "btn_finPedido";
            this.btn_finPedido.Size = new System.Drawing.Size(168, 44);
            this.btn_finPedido.TabIndex = 115;
            this.btn_finPedido.Text = "Finalizar Pedido";
            this.btn_finPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_finPedido.UseVisualStyleBackColor = false;
            this.btn_finPedido.Click += new System.EventHandler(this.btn_finPedido_Click_1);
            // 
            // btn_ajustar
            // 
            this.btn_ajustar.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajustar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ajustar.FlatAppearance.BorderSize = 0;
            this.btn_ajustar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ajustar.ForeColor = System.Drawing.Color.Black;
            this.btn_ajustar.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajustar.Image")));
            this.btn_ajustar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajustar.Location = new System.Drawing.Point(226, 12);
            this.btn_ajustar.Name = "btn_ajustar";
            this.btn_ajustar.Size = new System.Drawing.Size(100, 44);
            this.btn_ajustar.TabIndex = 81;
            this.btn_ajustar.Text = "Ajustar";
            this.btn_ajustar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ajustar.UseVisualStyleBackColor = false;
            this.btn_ajustar.Click += new System.EventHandler(this.btn_ajustar_Click);
            // 
            // dataClasses1DataContextBindingSource
            // 
            this.dataClasses1DataContextBindingSource.DataSource = typeof(sistema.DAL.DataClasses1DataContext);
            // 
            // frm_ajustar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 669);
            this.Controls.Add(this.GP_ajustar);
            this.Controls.Add(this.btn_ajustar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ajustar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste de Vestuário";
            this.Load += new System.EventHandler(this.frm_ajustar_Load);
            this.GP_ajustar.ResumeLayout(false);
            this.GP_ajustar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ajustarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajustarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClasses1DataContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajustar;
        private System.Windows.Forms.GroupBox GP_ajustar;
        private System.Windows.Forms.TextBox txt_total_geral;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.ComboBox CB_pgto;
        private System.Windows.Forms.Button btn_finAjuste;
        private System.Windows.Forms.DateTimePicker data_retirada;
        private System.Windows.Forms.DateTimePicker data_ajuste;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_finPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_funcionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_colete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_calca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_paleto;
        private System.Windows.Forms.Label label1;
        private db_sistemaDataSet db_sistemaDataSet;
        private System.Windows.Forms.BindingSource tb_ajustarBindingSource;
        private db_sistemaDataSetTableAdapters.tb_ajustarTableAdapter tb_ajustarTableAdapter;
        private db_sistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.BindingSource dataClasses1DataContextBindingSource;
        private System.Windows.Forms.BindingSource ajustarBindingSource;
    }
}