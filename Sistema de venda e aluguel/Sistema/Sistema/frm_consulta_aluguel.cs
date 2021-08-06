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
    public partial class frm_consulta_aluguel : Form
    {
        public frm_consulta_aluguel()
        {
            InitializeComponent();
        }

        private void tb_aluguelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_aluguelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_sistemaDataSet);

        }

        private void frm_consulta_aluguel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet.tb_aluguel'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_aluguelTableAdapter.Fill(this.db_sistemaDataSet.tb_aluguel);

        }

     
        private void Pesquisar(string busca)
        {
            this.tb_aluguelBindingSource.DataSource = DataContextFactory.DataContext.Alugar.Where(x => x.Cpf == busca);
        }

        private void btn_pesquisar_Click_1(object sender, EventArgs e)
        {
            this.Pesquisar(txt_search.Text);
        }
    }
}
