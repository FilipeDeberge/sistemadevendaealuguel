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
using System.Data.SqlClient;

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
            frm_baixaaluguel frm = new frm_baixaaluguel();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_consulta_aluguel frm = new frm_consulta_aluguel();
            frm.Show();
        }

        private void btn_itens_alugados_Click(object sender, EventArgs e)
        {
            frm_itens_alugados frm = new frm_itens_alugados();
            frm.Show();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            frm_consulta_clientes frm = new frm_consulta_clientes();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_consulta_venda frm = new frm_consulta_venda();
            frm.Show();
        }

        private void btn_itens_vendidos_Click(object sender, EventArgs e)
        {
            frm_itens_vendidos frm = new frm_itens_vendidos();
            frm.Show();
        }

        private void btn_recibo_Click(object sender, EventArgs e)
        {
            frm_impressao_recibo frm = new frm_impressao_recibo();
            frm.Show();
        }

        private void btn_ajuste_Click(object sender, EventArgs e)
        {
            frm_ajustar frm = new frm_ajustar();
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frm_dados_ajustes frm = new frm_dados_ajustes();
            frm.Show();
        }

        private void btn_retiradas_Click(object sender, EventArgs e)
        {
            frm_retiradas frm = new frm_retiradas();
            frm.Show();
        }

        private void btn_caixa_Click(object sender, EventArgs e)
        {
            frm_caixa frm = new frm_caixa();
            frm.Show();
        }

        private void Retiradas_Hoje()
        {
            string strProvider = "Data Source=DEBERGE\\SQLEXPRESS;Initial Catalog=db_sistema;Persist Security Info=True;User ID=sa;Password=Mefazviver77";
            //define a instrução SQL
            string strSql = "select id_aluguel, saida as 'Retirada', cliente, entrada as 'Devolução', falta_pagar from tb_aluguel  where saida = (SELECT CONVERT(date, GETDATE()))";

            //cria a conexão com o banco de dados
            SqlConnection con = new SqlConnection(strProvider);
            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, con);

            //abre a conexao
            con.Open();

            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            //cria um dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //cria um objeto datatable
            DataTable clientes = new DataTable();

            //preenche o datatable via dataadapter
            da.Fill(clientes);

            //atribui o datatable ao datagridview para exibir o resultado
            DG_retiradashoje.DataSource = clientes;

        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            Retiradas_Hoje();
        }

        private void btn_caixa_ajuste_Click(object sender, EventArgs e)
        {
            frm_caixa_ajustar frm = new frm_caixa_ajustar();
            frm.Show();
        }

        private void btn_caixa_venda_Click(object sender, EventArgs e)
        {
            frm_caixa_venda frm = new frm_caixa_venda();
            frm.Show();
        }
    }
}
