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
    public partial class frm_consultavestuario : Form
    {
        public frm_consultavestuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_consultavestuario_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)CB_categoria.SelectedValue);
        }

        public void Pesquisar(int codigoCategoria)
        {
            this.vestuarioBindingSource.DataSource = DataContextFactory.DataContext.Vestuario.Where(x => x.CodigoCategoria == codigoCategoria);
        }
    }
}
