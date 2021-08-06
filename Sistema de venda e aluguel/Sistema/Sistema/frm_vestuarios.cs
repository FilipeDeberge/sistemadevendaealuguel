using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.DAL;

namespace Sistema
{
    public partial class frm_vestuarios : Form
    {
        public frm_vestuarios()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_vestuarios_Load(object sender, EventArgs e)
        {
            this.vestuarioBindingSource.DataSource = DataContextFactory.DataContext.Vestuario;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.vestuarioBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.vestuarioBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Vestuário inserido com Sucesso!");
            }

        }
        private bool valida()
        {
            if (txt_descricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo descrição é obrigatório!");
                txt_descricao.Focus();
                return false;
            }
            
            if (txt_codloja.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Código Loja é obrigatório!");
                txt_codloja.Focus();
                return false;
            }


            return true;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.vestuarioBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Vestuário excluído com Sucesso!");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.vestuarioBindingSource.CancelEdit();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Categoria)e.Value).Descricao;
        }

       
    }
}

