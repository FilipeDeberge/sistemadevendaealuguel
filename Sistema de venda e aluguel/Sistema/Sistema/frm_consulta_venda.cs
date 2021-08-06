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
    public partial class frm_consulta_venda : Form
    {
        public frm_consulta_venda()
        {
            InitializeComponent();
        }

        private void tb_vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_sistemaDataSet1);

        }

        private void frm_consulta_venda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataNovo.tb_venda'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_vendaTableAdapter1.Fill(this.db_sistemaDataNovo.tb_venda);
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet1.tb_itens_venda'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_itens_vendaTableAdapter.Fill(this.db_sistemaDataSet1.tb_itens_venda);
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet1.tb_venda'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_vendaTableAdapter.Fill(this.db_sistemaDataSet1.tb_venda);

        }
    }
}
