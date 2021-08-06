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
    public partial class frm_dados_ajustes : Form
    {
        public frm_dados_ajustes()
        {
            InitializeComponent();
        }

        private void tb_ajustarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_ajustarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_sistemaDataSet);

        }

        private void frm_dados_ajustes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet.tb_ajustar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ajustarTableAdapter.Fill(this.db_sistemaDataSet.tb_ajustar);

        }
    }
}
