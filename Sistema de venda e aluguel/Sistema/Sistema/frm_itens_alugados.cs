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
    public partial class frm_itens_alugados : Form
    {
        public frm_itens_alugados()
        {
            InitializeComponent();
        }

        private void frm_itens_alugados_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet.tb_itens_alugar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_itens_alugarTableAdapter.Fill(this.db_sistemaDataSet.tb_itens_alugar);

        }
    }
}
