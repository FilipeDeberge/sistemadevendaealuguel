using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema
{
    public partial class frm_caixa_venda : Form
    {
        public frm_caixa_venda()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            //define a string de conexao com provedor caminho e nome do banco de dados
            string strProvider = "Data Source=DEBERGE\\SQLEXPRESS;Initial Catalog=db_sistema;Persist Security Info=True;User ID=sa;Password=Mefazviver77";
            //define a instrução SQL
            string strSql = "select id_venda as 'Contrato', cliente, data, valor_pago from tb_venda where data = (SELECT CONVERT (date, GETDATE()))";

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
            DG_caixa.DataSource = clientes;

        }


        private void Total_Geral()
        {
            string strProvider = "Data Source=DEBERGE\\SQLEXPRESS;Initial Catalog=db_sistema;Persist Security Info=True;User ID=sa;Password=Mefazviver77";
            //define a instrução SQL
            string strSql = "select sum(valor_pago) as Valor from tb_venda  where data = (SELECT CONVERT(date, GETDATE()))";

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
            dg_totalgeral.DataSource = clientes;

        }

        private void frm_caixa_venda_Load(object sender, EventArgs e)
        {
            CarregarDados();
           
            Total_Geral();
        }
    }
}
