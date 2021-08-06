namespace Sistema
{
    partial class frm_menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cad_popup_vestuario = new System.Windows.Forms.ToolStripMenuItem();
            this.cad_popup_categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vestuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_vestuario = new System.Windows.Forms.Button();
            this.btn_cad_categorias = new System.Windows.Forms.Button();
            this.btn_venda = new System.Windows.Forms.Button();
            this.btn_aluguel = new System.Windows.Forms.Button();
            this.btn_buscavestuario = new System.Windows.Forms.Button();
            this.btn_baixaaluguel = new System.Windows.Forms.Button();
            this.btn_consultaAluguel = new System.Windows.Forms.Button();
            this.btn_itens_alugados = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_itens_vendidos = new System.Windows.Forms.Button();
            this.btn_recibo = new System.Windows.Forms.Button();
            this.btn_ajuste = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_retiradas = new System.Windows.Forms.Button();
            this.DG_retiradashoje = new System.Windows.Forms.DataGridView();
            this.btn_caixa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_caixa_venda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_caixa_ajuste = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_retiradashoje)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.aluguelToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cad_popup_vestuario,
            this.cad_popup_categorias});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // cad_popup_vestuario
            // 
            this.cad_popup_vestuario.Name = "cad_popup_vestuario";
            this.cad_popup_vestuario.Size = new System.Drawing.Size(130, 22);
            this.cad_popup_vestuario.Text = "Vestuário";
            this.cad_popup_vestuario.Click += new System.EventHandler(this.roupasToolStripMenuItem_Click);
            // 
            // cad_popup_categorias
            // 
            this.cad_popup_categorias.Name = "cad_popup_categorias";
            this.cad_popup_categorias.Size = new System.Drawing.Size(130, 22);
            this.cad_popup_categorias.Text = "Categorias";
            this.cad_popup_categorias.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosCategoriaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // produtosCategoriaToolStripMenuItem
            // 
            this.produtosCategoriaToolStripMenuItem.Name = "produtosCategoriaToolStripMenuItem";
            this.produtosCategoriaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.produtosCategoriaToolStripMenuItem.Text = "Produtos/Categoria";
            this.produtosCategoriaToolStripMenuItem.Click += new System.EventHandler(this.produtosCategoriaToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem1.Text = "Venda";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // aluguelToolStripMenuItem
            // 
            this.aluguelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alugarToolStripMenuItem});
            this.aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            this.aluguelToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.aluguelToolStripMenuItem.Text = "Aluguel";
            // 
            // alugarToolStripMenuItem
            // 
            this.alugarToolStripMenuItem.Name = "alugarToolStripMenuItem";
            this.alugarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.alugarToolStripMenuItem.Text = "Alugar";
            this.alugarToolStripMenuItem.Click += new System.EventHandler(this.alugarToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vestuáriosToolStripMenuItem,
            this.aluguelToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // vestuáriosToolStripMenuItem
            // 
            this.vestuáriosToolStripMenuItem.Name = "vestuáriosToolStripMenuItem";
            this.vestuáriosToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.vestuáriosToolStripMenuItem.Text = "Vestuários";
            this.vestuáriosToolStripMenuItem.Click += new System.EventHandler(this.vestuáriosToolStripMenuItem_Click);
            // 
            // aluguelToolStripMenuItem1
            // 
            this.aluguelToolStripMenuItem1.Name = "aluguelToolStripMenuItem1";
            this.aluguelToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.aluguelToolStripMenuItem1.Text = "Aluguel";
            this.aluguelToolStripMenuItem1.Click += new System.EventHandler(this.aluguelToolStripMenuItem1_Click);
            // 
            // btn_cad_vestuario
            // 
            this.btn_cad_vestuario.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_vestuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cad_vestuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_vestuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cad_vestuario.FlatAppearance.BorderSize = 0;
            this.btn_cad_vestuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_vestuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_cad_vestuario.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cad_vestuario.Image = global::Sistema.Properties.Resources.categoriasbutton;
            this.btn_cad_vestuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_vestuario.Location = new System.Drawing.Point(71, 224);
            this.btn_cad_vestuario.Name = "btn_cad_vestuario";
            this.btn_cad_vestuario.Size = new System.Drawing.Size(82, 99);
            this.btn_cad_vestuario.TabIndex = 1;
            this.btn_cad_vestuario.Text = "Cadastrar Vestuário";
            this.btn_cad_vestuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_vestuario.UseVisualStyleBackColor = false;
            this.btn_cad_vestuario.Click += new System.EventHandler(this.btn_cad_vestuario_Click);
            // 
            // btn_cad_categorias
            // 
            this.btn_cad_categorias.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_categorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cad_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categorias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cad_categorias.FlatAppearance.BorderSize = 0;
            this.btn_cad_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_cad_categorias.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cad_categorias.Image = global::Sistema.Properties.Resources.categoriasbutton;
            this.btn_cad_categorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_categorias.Location = new System.Drawing.Point(149, 224);
            this.btn_cad_categorias.Name = "btn_cad_categorias";
            this.btn_cad_categorias.Size = new System.Drawing.Size(82, 99);
            this.btn_cad_categorias.TabIndex = 2;
            this.btn_cad_categorias.Text = "Cadastrar Categorias";
            this.btn_cad_categorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_categorias.UseVisualStyleBackColor = false;
            this.btn_cad_categorias.Click += new System.EventHandler(this.btn_cad_categorias_Click);
            // 
            // btn_venda
            // 
            this.btn_venda.BackColor = System.Drawing.Color.Transparent;
            this.btn_venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_venda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_venda.FlatAppearance.BorderSize = 0;
            this.btn_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_venda.ForeColor = System.Drawing.Color.DimGray;
            this.btn_venda.Image = ((System.Drawing.Image)(resources.GetObject("btn_venda.Image")));
            this.btn_venda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_venda.Location = new System.Drawing.Point(63, 105);
            this.btn_venda.Name = "btn_venda";
            this.btn_venda.Size = new System.Drawing.Size(102, 99);
            this.btn_venda.TabIndex = 3;
            this.btn_venda.Text = "Venda de Vestuário";
            this.btn_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_venda.UseVisualStyleBackColor = false;
            this.btn_venda.Click += new System.EventHandler(this.btn_venda_Click);
            // 
            // btn_aluguel
            // 
            this.btn_aluguel.BackColor = System.Drawing.Color.Transparent;
            this.btn_aluguel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_aluguel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aluguel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_aluguel.FlatAppearance.BorderSize = 0;
            this.btn_aluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_aluguel.ForeColor = System.Drawing.Color.DimGray;
            this.btn_aluguel.Image = ((System.Drawing.Image)(resources.GetObject("btn_aluguel.Image")));
            this.btn_aluguel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_aluguel.Location = new System.Drawing.Point(0, 105);
            this.btn_aluguel.Name = "btn_aluguel";
            this.btn_aluguel.Size = new System.Drawing.Size(82, 99);
            this.btn_aluguel.TabIndex = 4;
            this.btn_aluguel.Text = "Aluguel de Vestuário";
            this.btn_aluguel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_aluguel.UseVisualStyleBackColor = false;
            this.btn_aluguel.Click += new System.EventHandler(this.btn_aluguel_Click);
            // 
            // btn_buscavestuario
            // 
            this.btn_buscavestuario.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscavestuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_buscavestuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscavestuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_buscavestuario.FlatAppearance.BorderSize = 0;
            this.btn_buscavestuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscavestuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_buscavestuario.ForeColor = System.Drawing.Color.DimGray;
            this.btn_buscavestuario.Image = global::Sistema.Properties.Resources.busca;
            this.btn_buscavestuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buscavestuario.Location = new System.Drawing.Point(954, 329);
            this.btn_buscavestuario.Name = "btn_buscavestuario";
            this.btn_buscavestuario.Size = new System.Drawing.Size(82, 99);
            this.btn_buscavestuario.TabIndex = 5;
            this.btn_buscavestuario.Text = "Busca de Vestuários";
            this.btn_buscavestuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscavestuario.UseVisualStyleBackColor = false;
            this.btn_buscavestuario.Click += new System.EventHandler(this.btn_buscavestuario_Click);
            // 
            // btn_baixaaluguel
            // 
            this.btn_baixaaluguel.BackColor = System.Drawing.Color.Transparent;
            this.btn_baixaaluguel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_baixaaluguel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_baixaaluguel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_baixaaluguel.FlatAppearance.BorderSize = 0;
            this.btn_baixaaluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_baixaaluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_baixaaluguel.ForeColor = System.Drawing.Color.DimGray;
            this.btn_baixaaluguel.Image = ((System.Drawing.Image)(resources.GetObject("btn_baixaaluguel.Image")));
            this.btn_baixaaluguel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_baixaaluguel.Location = new System.Drawing.Point(0, 343);
            this.btn_baixaaluguel.Name = "btn_baixaaluguel";
            this.btn_baixaaluguel.Size = new System.Drawing.Size(82, 99);
            this.btn_baixaaluguel.TabIndex = 6;
            this.btn_baixaaluguel.Text = "Baixa de Vestuário";
            this.btn_baixaaluguel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_baixaaluguel.UseVisualStyleBackColor = false;
            this.btn_baixaaluguel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_consultaAluguel
            // 
            this.btn_consultaAluguel.BackColor = System.Drawing.Color.Transparent;
            this.btn_consultaAluguel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_consultaAluguel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultaAluguel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_consultaAluguel.FlatAppearance.BorderSize = 0;
            this.btn_consultaAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultaAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_consultaAluguel.ForeColor = System.Drawing.Color.DimGray;
            this.btn_consultaAluguel.Image = global::Sistema.Properties.Resources.busca;
            this.btn_consultaAluguel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_consultaAluguel.Location = new System.Drawing.Point(885, 105);
            this.btn_consultaAluguel.Name = "btn_consultaAluguel";
            this.btn_consultaAluguel.Size = new System.Drawing.Size(82, 99);
            this.btn_consultaAluguel.TabIndex = 7;
            this.btn_consultaAluguel.Text = "Dados dos aluguéis";
            this.btn_consultaAluguel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_consultaAluguel.UseVisualStyleBackColor = false;
            this.btn_consultaAluguel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_itens_alugados
            // 
            this.btn_itens_alugados.BackColor = System.Drawing.Color.Transparent;
            this.btn_itens_alugados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_itens_alugados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_itens_alugados.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_itens_alugados.FlatAppearance.BorderSize = 0;
            this.btn_itens_alugados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itens_alugados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_itens_alugados.ForeColor = System.Drawing.Color.DimGray;
            this.btn_itens_alugados.Image = global::Sistema.Properties.Resources.busca;
            this.btn_itens_alugados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_itens_alugados.Location = new System.Drawing.Point(961, 105);
            this.btn_itens_alugados.Name = "btn_itens_alugados";
            this.btn_itens_alugados.Size = new System.Drawing.Size(82, 99);
            this.btn_itens_alugados.TabIndex = 8;
            this.btn_itens_alugados.Text = "Itens alugados";
            this.btn_itens_alugados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_itens_alugados.UseVisualStyleBackColor = false;
            this.btn_itens_alugados.Click += new System.EventHandler(this.btn_itens_alugados_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_cliente.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cliente.Image = global::Sistema.Properties.Resources.busca;
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cliente.Location = new System.Drawing.Point(1030, 329);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(82, 99);
            this.btn_cliente.TabIndex = 9;
            this.btn_cliente.Text = "Consulta de Cliente";
            this.btn_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Image = global::Sistema.Properties.Resources.busca;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(885, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 99);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dados de Vendas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_itens_vendidos
            // 
            this.btn_itens_vendidos.BackColor = System.Drawing.Color.Transparent;
            this.btn_itens_vendidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_itens_vendidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_itens_vendidos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_itens_vendidos.FlatAppearance.BorderSize = 0;
            this.btn_itens_vendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itens_vendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_itens_vendidos.ForeColor = System.Drawing.Color.DimGray;
            this.btn_itens_vendidos.Image = global::Sistema.Properties.Resources.busca;
            this.btn_itens_vendidos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_itens_vendidos.Location = new System.Drawing.Point(1030, 224);
            this.btn_itens_vendidos.Name = "btn_itens_vendidos";
            this.btn_itens_vendidos.Size = new System.Drawing.Size(82, 99);
            this.btn_itens_vendidos.TabIndex = 11;
            this.btn_itens_vendidos.Text = "Itens vendidos";
            this.btn_itens_vendidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_itens_vendidos.UseVisualStyleBackColor = false;
            this.btn_itens_vendidos.Click += new System.EventHandler(this.btn_itens_vendidos_Click);
            // 
            // btn_recibo
            // 
            this.btn_recibo.BackColor = System.Drawing.Color.Transparent;
            this.btn_recibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_recibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_recibo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_recibo.FlatAppearance.BorderSize = 0;
            this.btn_recibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_recibo.ForeColor = System.Drawing.Color.DimGray;
            this.btn_recibo.Image = ((System.Drawing.Image)(resources.GetObject("btn_recibo.Image")));
            this.btn_recibo.Location = new System.Drawing.Point(0, 224);
            this.btn_recibo.Name = "btn_recibo";
            this.btn_recibo.Size = new System.Drawing.Size(82, 99);
            this.btn_recibo.TabIndex = 12;
            this.btn_recibo.Text = "Imprimir Recibo";
            this.btn_recibo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_recibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_recibo.UseVisualStyleBackColor = false;
            this.btn_recibo.Click += new System.EventHandler(this.btn_recibo_Click);
            // 
            // btn_ajuste
            // 
            this.btn_ajuste.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajuste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ajuste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajuste.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ajuste.FlatAppearance.BorderSize = 0;
            this.btn_ajuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_ajuste.ForeColor = System.Drawing.Color.DimGray;
            this.btn_ajuste.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajuste.Image")));
            this.btn_ajuste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ajuste.Location = new System.Drawing.Point(149, 105);
            this.btn_ajuste.Name = "btn_ajuste";
            this.btn_ajuste.Size = new System.Drawing.Size(82, 99);
            this.btn_ajuste.TabIndex = 13;
            this.btn_ajuste.Text = "Ajuste de Vestuário";
            this.btn_ajuste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ajuste.UseVisualStyleBackColor = false;
            this.btn_ajuste.Click += new System.EventHandler(this.btn_ajuste_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Image = global::Sistema.Properties.Resources.busca;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(1030, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 99);
            this.button2.TabIndex = 14;
            this.button2.Text = "Dados de Ajustes";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_retiradas
            // 
            this.btn_retiradas.BackColor = System.Drawing.Color.Transparent;
            this.btn_retiradas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_retiradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_retiradas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_retiradas.FlatAppearance.BorderSize = 0;
            this.btn_retiradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retiradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_retiradas.ForeColor = System.Drawing.Color.DimGray;
            this.btn_retiradas.Image = global::Sistema.Properties.Resources.categoriasbutton;
            this.btn_retiradas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_retiradas.Location = new System.Drawing.Point(963, 224);
            this.btn_retiradas.Name = "btn_retiradas";
            this.btn_retiradas.Size = new System.Drawing.Size(82, 99);
            this.btn_retiradas.TabIndex = 15;
            this.btn_retiradas.Text = "Retiradas da Semana";
            this.btn_retiradas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_retiradas.UseVisualStyleBackColor = false;
            this.btn_retiradas.Click += new System.EventHandler(this.btn_retiradas_Click);
            // 
            // DG_retiradashoje
            // 
            this.DG_retiradashoje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_retiradashoje.Location = new System.Drawing.Point(301, 466);
            this.DG_retiradashoje.Name = "DG_retiradashoje";
            this.DG_retiradashoje.Size = new System.Drawing.Size(509, 178);
            this.DG_retiradashoje.TabIndex = 16;
            // 
            // btn_caixa
            // 
            this.btn_caixa.BackColor = System.Drawing.Color.Transparent;
            this.btn_caixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_caixa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_caixa.FlatAppearance.BorderSize = 0;
            this.btn_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_caixa.ForeColor = System.Drawing.Color.DimGray;
            this.btn_caixa.Image = ((System.Drawing.Image)(resources.GetObject("btn_caixa.Image")));
            this.btn_caixa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_caixa.Location = new System.Drawing.Point(418, 94);
            this.btn_caixa.Name = "btn_caixa";
            this.btn_caixa.Size = new System.Drawing.Size(87, 110);
            this.btn_caixa.TabIndex = 17;
            this.btn_caixa.Text = "Fechamento de Caixa Aluguel";
            this.btn_caixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_caixa.UseVisualStyleBackColor = false;
            this.btn_caixa.Click += new System.EventHandler(this.btn_caixa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "SERVIÇOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(939, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 34);
            this.label2.TabIndex = 19;
            this.label2.Text = "CONSULTAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "RETIRADAS DE HOJE";
            // 
            // btn_caixa_venda
            // 
            this.btn_caixa_venda.BackColor = System.Drawing.Color.Transparent;
            this.btn_caixa_venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_caixa_venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_caixa_venda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_caixa_venda.FlatAppearance.BorderSize = 0;
            this.btn_caixa_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caixa_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_caixa_venda.ForeColor = System.Drawing.Color.DimGray;
            this.btn_caixa_venda.Image = ((System.Drawing.Image)(resources.GetObject("btn_caixa_venda.Image")));
            this.btn_caixa_venda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_caixa_venda.Location = new System.Drawing.Point(604, 93);
            this.btn_caixa_venda.Name = "btn_caixa_venda";
            this.btn_caixa_venda.Size = new System.Drawing.Size(87, 110);
            this.btn_caixa_venda.TabIndex = 22;
            this.btn_caixa_venda.Text = "Fechamento de Caixa Venda";
            this.btn_caixa_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_caixa_venda.UseVisualStyleBackColor = false;
            this.btn_caixa_venda.Click += new System.EventHandler(this.btn_caixa_venda_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 34);
            this.label4.TabIndex = 23;
            this.label4.Text = "FINANCEIRO";
            // 
            // btn_caixa_ajuste
            // 
            this.btn_caixa_ajuste.BackColor = System.Drawing.Color.Transparent;
            this.btn_caixa_ajuste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_caixa_ajuste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_caixa_ajuste.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_caixa_ajuste.FlatAppearance.BorderSize = 0;
            this.btn_caixa_ajuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caixa_ajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_caixa_ajuste.ForeColor = System.Drawing.Color.DimGray;
            this.btn_caixa_ajuste.Image = ((System.Drawing.Image)(resources.GetObject("btn_caixa_ajuste.Image")));
            this.btn_caixa_ajuste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_caixa_ajuste.Location = new System.Drawing.Point(511, 94);
            this.btn_caixa_ajuste.Name = "btn_caixa_ajuste";
            this.btn_caixa_ajuste.Size = new System.Drawing.Size(87, 110);
            this.btn_caixa_ajuste.TabIndex = 24;
            this.btn_caixa_ajuste.Text = "Fechamento de Caixa Ajuste";
            this.btn_caixa_ajuste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_caixa_ajuste.UseVisualStyleBackColor = false;
            this.btn_caixa_ajuste.Click += new System.EventHandler(this.btn_caixa_ajuste_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1108, 656);
            this.Controls.Add(this.btn_caixa_ajuste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_caixa_venda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_caixa);
            this.Controls.Add(this.DG_retiradashoje);
            this.Controls.Add(this.btn_retiradas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ajuste);
            this.Controls.Add(this.btn_recibo);
            this.Controls.Add(this.btn_itens_vendidos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_itens_alugados);
            this.Controls.Add(this.btn_consultaAluguel);
            this.Controls.Add(this.btn_baixaaluguel);
            this.Controls.Add(this.btn_buscavestuario);
            this.Controls.Add(this.btn_aluguel);
            this.Controls.Add(this.btn_venda);
            this.Controls.Add(this.btn_cad_categorias);
            this.Controls.Add(this.btn_cad_vestuario);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_retiradashoje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cad_popup_vestuario;
        private System.Windows.Forms.ToolStripMenuItem cad_popup_categorias;
        private System.Windows.Forms.Button btn_cad_vestuario;
        private System.Windows.Forms.Button btn_cad_categorias;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aluguelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vestuáriosToolStripMenuItem;
        private System.Windows.Forms.Button btn_venda;
        private System.Windows.Forms.Button btn_aluguel;
        private System.Windows.Forms.Button btn_buscavestuario;
        private System.Windows.Forms.ToolStripMenuItem produtosCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aluguelToolStripMenuItem1;
        private System.Windows.Forms.Button btn_baixaaluguel;
        private System.Windows.Forms.Button btn_consultaAluguel;
        private System.Windows.Forms.Button btn_itens_alugados;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_itens_vendidos;
        private System.Windows.Forms.Button btn_recibo;
        private System.Windows.Forms.Button btn_ajuste;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_retiradas;
        private System.Windows.Forms.DataGridView DG_retiradashoje;
        private System.Windows.Forms.Button btn_caixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_caixa_venda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_caixa_ajuste;
    }
}

