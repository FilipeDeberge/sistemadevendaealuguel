using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Relatorios
{
    public partial class frm_rel_aluguel : Form
    {
        public frm_rel_aluguel()
        {
            InitializeComponent();
        }

        private void frm_rel_aluguel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetAtual.tb_aluguel'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_aluguelTableAdapter.Fill(this.dataSetAtual.tb_aluguel);
            this.reportViewer1.RefreshReport();
        }
    }
}
