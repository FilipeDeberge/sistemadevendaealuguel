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
    public partial class frm_reserva : Form
    {
        public frm_reserva()
        {
            InitializeComponent();
        }

        private void tb_aluguelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_aluguelBindingSource.EndEdit();
            this.alugarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_sistemaDataSet);

        }

        private void frm_reserva_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet.tb_aluguel'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_aluguelTableAdapter.Fill(this.db_sistemaDataSet.tb_aluguel);
           
        }
    }
}
