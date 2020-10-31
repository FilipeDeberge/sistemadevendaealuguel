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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void roupasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_vestuarios frm = new frm_vestuarios();
            frm.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cad_vestuario_Click(object sender, EventArgs e)
        {
            frm_vestuarios frm = new frm_vestuarios();
            frm.Show();
        }

        private void btn_cad_categorias_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void btn_venda_Click(object sender, EventArgs e)
        {
            frm_venda frm = new frm_venda();
            frm.Show();
        }

        private void btn_aluguel_Click(object sender, EventArgs e)
        {
            frm_aluguel frm = new frm_aluguel();
            frm.Show();
        }

        private void produtosCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_consultavestuario frm = new frm_consultavestuario();
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_venda frm = new frm_venda ();
            frm.Show();
        }

        private void vestuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void alugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_aluguel frm = new frm_aluguel();
            frm.Show();
        }

        private void aluguelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_buscavestuario_Click(object sender, EventArgs e)
        {
            frm_consultavestuario frm = new frm_consultavestuario();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
