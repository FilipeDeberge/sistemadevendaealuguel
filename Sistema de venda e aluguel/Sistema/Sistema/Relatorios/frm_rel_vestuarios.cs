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
using Sistema.DataSetTableAdapters;
using Sistema.DataSet1TableAdapters;

namespace Sistema.Relatorios
{
    public partial class frm_rel_pedidos : Form
    {
        public frm_rel_pedidos()
        {
            InitializeComponent();
        }

        
        private void frm_rel_pedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet.tb_vestuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_vestuarioTableAdapter.Fill(this.dataSet.tb_vestuario);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
