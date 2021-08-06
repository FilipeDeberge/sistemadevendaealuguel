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
using System.Data.OleDb;

namespace Sistema
{
    public partial class frm_retiradas : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=DEBERGE\\SQLEXPRESS;Initial Catalog=db_sistema;Persist Security Info=True;User ID=sa;Password=Mefazviver77");
        //SqlCommand comando = new SqlCommand();
        public frm_retiradas()
        {
            InitializeComponent();
        }



        private void frm_retiradas_Load(object sender, EventArgs e)
        {
            CarregarDados();

        }


        private void CarregarDados()
        {
            //define a string de conexao com provedor caminho e nome do banco de dados
            string strProvider = "Data Source=DEBERGE\\SQLEXPRESS;Initial Catalog=db_sistema;Persist Security Info=True;User ID=sa;Password=Mefazviver77";
            //define a instrução SQL
            string strSql = "select id_aluguel, saida as 'Retirada', cliente, null as Conferido, null as Entregue, entrada as 'Devolução', null as 'Sem Avaria', null as Observação, falta_pagar as 'Pendencia' from tb_aluguel where saida between getdate() and DATEADD(d,7,getdate())";

            //cria a conexão com o banco de dados
            SqlConnection con = new SqlConnection(strProvider);
            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand (strSql, con);

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
            DG_retiradas.DataSource = clientes;

        }
    }
}
