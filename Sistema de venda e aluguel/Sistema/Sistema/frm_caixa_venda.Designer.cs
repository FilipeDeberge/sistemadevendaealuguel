namespace Sistema
{
    partial class frm_caixa_venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_caixa_venda));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg_totalgeral = new System.Windows.Forms.DataGridView();
            this.DG_caixa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_totalgeral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_caixa)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "FLUXO DO DIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "TOTAL GERAL";
            // 
            // dg_totalgeral
            // 
            this.dg_totalgeral.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dg_totalgeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_totalgeral.Location = new System.Drawing.Point(329, 385);
            this.dg_totalgeral.Name = "dg_totalgeral";
            this.dg_totalgeral.Size = new System.Drawing.Size(145, 72);
            this.dg_totalgeral.TabIndex = 19;
            // 
            // DG_caixa
            // 
            this.DG_caixa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DG_caixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_caixa.Location = new System.Drawing.Point(12, 46);
            this.DG_caixa.Name = "DG_caixa";
            this.DG_caixa.Size = new System.Drawing.Size(776, 277);
            this.DG_caixa.TabIndex = 16;
            // 
            // frm_caixa_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg_totalgeral);
            this.Controls.Add(this.DG_caixa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_caixa_venda";
            this.Text = "Fechamento de Caixa Vendas";
            this.Load += new System.EventHandler(this.frm_caixa_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_totalgeral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_caixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_totalgeral;
        private System.Windows.Forms.DataGridView DG_caixa;
    }
}