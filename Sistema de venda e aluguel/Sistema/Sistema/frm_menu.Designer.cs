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
            this.btn_rel_aluguel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
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
            this.cad_popup_vestuario.Size = new System.Drawing.Size(180, 22);
            this.cad_popup_vestuario.Text = "Vestuário";
            this.cad_popup_vestuario.Click += new System.EventHandler(this.roupasToolStripMenuItem_Click);
            // 
            // cad_popup_categorias
            // 
            this.cad_popup_categorias.Name = "cad_popup_categorias";
            this.cad_popup_categorias.Size = new System.Drawing.Size(180, 22);
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
            this.vestuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vestuáriosToolStripMenuItem.Text = "Vestuários";
            this.vestuáriosToolStripMenuItem.Click += new System.EventHandler(this.vestuáriosToolStripMenuItem_Click);
            // 
            // aluguelToolStripMenuItem1
            // 
            this.aluguelToolStripMenuItem1.Name = "aluguelToolStripMenuItem1";
            this.aluguelToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
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
            this.btn_cad_vestuario.Location = new System.Drawing.Point(404, 54);
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
            this.btn_cad_categorias.Location = new System.Drawing.Point(522, 54);
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
            this.btn_venda.Location = new System.Drawing.Point(100, 54);
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
            this.btn_aluguel.Location = new System.Drawing.Point(12, 54);
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
            this.btn_buscavestuario.Location = new System.Drawing.Point(12, 307);
            this.btn_buscavestuario.Name = "btn_buscavestuario";
            this.btn_buscavestuario.Size = new System.Drawing.Size(82, 99);
            this.btn_buscavestuario.TabIndex = 5;
            this.btn_buscavestuario.Text = "Busca de Vestuários";
            this.btn_buscavestuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscavestuario.UseVisualStyleBackColor = false;
            this.btn_buscavestuario.Click += new System.EventHandler(this.btn_buscavestuario_Click);
            // 
            // btn_rel_aluguel
            // 
            this.btn_rel_aluguel.BackColor = System.Drawing.Color.Transparent;
            this.btn_rel_aluguel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_rel_aluguel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rel_aluguel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_rel_aluguel.FlatAppearance.BorderSize = 0;
            this.btn_rel_aluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rel_aluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_rel_aluguel.ForeColor = System.Drawing.Color.DimGray;
            this.btn_rel_aluguel.Image = global::Sistema.Properties.Resources.busca;
            this.btn_rel_aluguel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rel_aluguel.Location = new System.Drawing.Point(522, 307);
            this.btn_rel_aluguel.Name = "btn_rel_aluguel";
            this.btn_rel_aluguel.Size = new System.Drawing.Size(82, 99);
            this.btn_rel_aluguel.TabIndex = 6;
            this.btn_rel_aluguel.Text = "Relatórios de Aluguéis";
            this.btn_rel_aluguel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rel_aluguel.UseVisualStyleBackColor = false;
            this.btn_rel_aluguel.Click += new System.EventHandler(this.button1_Click);
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
            this.button2.Location = new System.Drawing.Point(120, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 99);
            this.button2.TabIndex = 7;
            this.button2.Text = "Busca de Reserva";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(616, 423);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_rel_aluguel);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btn_rel_aluguel;
        private System.Windows.Forms.Button button2;
    }
}

