using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frm_itens_vendidos : Form
    {
        public frm_itens_vendidos()
        {
            InitializeComponent();
        }

        private void tb_itens_vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_itens_vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_sistemaDataSet1);

        }

        private void frm_itens_vendidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet1.tb_itens_venda'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_itens_vendaTableAdapter.Fill(this.db_sistemaDataSet1.tb_itens_venda);

        }
    }
}
