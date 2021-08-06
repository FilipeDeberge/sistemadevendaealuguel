namespace Sistema
{
    partial class frm_consultavestuario
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
            this.vestuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.vestuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_categoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vestuarioDataGridView
            // 
            this.vestuarioDataGridView.AllowUserToAddRows = false;
            this.vestuarioDataGridView.AllowUserToDeleteRows = false;
            this.vestuarioDataGridView.AutoGenerateColumns = false;
            this.vestuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vestuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn2});
            this.vestuarioDataGridView.DataSource = this.vestuarioBindingSource;
            this.vestuarioDataGridView.Location = new System.Drawing.Point(0, 65);
            this.vestuarioDataGridView.Name = "vestuarioDataGridView";
            this.vestuarioDataGridView.ReadOnly = true;
            this.vestuarioDataGridView.Size = new System.Drawing.Size(543, 305);
            this.vestuarioDataGridView.TabIndex = 1;
            // 
            // vestuarioBindingSource
            // 
            this.vestuarioBindingSource.DataSource = typeof(sistema.DAL.Vestuario);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Location = new System.Drawing.Point(358, 20);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CB_categoria
            // 
            this.CB_categoria.DataSource = this.categoriaBindingSource;
            this.CB_categoria.DisplayMember = "Descricao";
            this.CB_categoria.FormattingEnabled = true;
            this.CB_categoria.Location = new System.Drawing.Point(135, 21);
            this.CB_categoria.Name = "CB_categoria";
            this.CB_categoria.Size = new System.Drawing.Size(217, 21);
            this.CB_categoria.TabIndex = 4;
            this.CB_categoria.ValueMember = "Codigo";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(sistema.DAL.Categoria);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodigoVestuario";
            this.Column1.HeaderText = "Código do Vestuário";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Vestuário";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // frm_consultavestuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(543, 370);
            this.Controls.Add(this.CB_categoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.vestuarioDataGridView);
            this.Name = "frm_consultavestuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Vestuários por Categoria";
            this.Load += new System.EventHandler(this.frm_consultavestuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vestuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vestuarioBindingSource;
        private System.Windows.Forms.DataGridView vestuarioDataGridView;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_categoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}