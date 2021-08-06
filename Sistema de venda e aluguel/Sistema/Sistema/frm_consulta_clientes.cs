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
    public partial class frm_consulta_clientes : Form
    {
        public frm_consulta_clientes()
        {
            InitializeComponent();
        }

        private void tb_aluguelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_aluguelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_sistemaDataSet);

        }

        private void frm_consulta_clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet.tb_aluguel'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_aluguelTableAdapter.Fill(this.db_sistemaDataSet.tb_aluguel);
            this.tb_aluguelBindingSource.DataSource = DataContextFactory.DataContext.Alugar;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                foreach (DataGridViewRow dg in tb_aluguelDataGridView.Rows)
                {
                    string.Format("CPF like '%{0}%'", txt_search.Text);
                    tb_aluguelDataGridView.DataSource = dg.DataBoundItem;
                }
                
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            this.Pesquisar(txt_search.Text);
        }

        public void Pesquisar(string busca)
        {
            this.tb_aluguelBindingSource.DataSource = DataContextFactory.DataContext.Alugar.Where(x => x.Cpf == busca);
        }
    }
}
