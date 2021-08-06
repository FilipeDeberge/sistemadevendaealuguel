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
    public partial class frm_caixa_ajustar : Form
    {
        public frm_caixa_ajustar()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            //define a string de conexao com provedor caminho e nome do banco de dados
            string strProvider = "Data Source=DEBERGE\\SQLEXPRESS;Initial Catalog=db_sistema;Persist Security Info=True;User ID=sa;Password=Mefazviver77";
            //define a instrução SQL
            string strSql = "select id_ajustar as 'Contrato', cliente, data_ajuste, sinal, desconto, total_geral, falta_pagar from tb_ajustar where data_ajuste = (SELECT CONVERT (date, GETDATE()))";

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

        private void Sinal()
        {
            string strProvider = "Data Source=DEBERGE\\SQLEXPRESS;Initial Catalog=db_sistema;Persist Security Info=True;User ID=sa;Password=Mefazviver77";
            //define a instrução SQL
            string strSql = "select sum(sinal) as Valor from tb_ajustar where data_ajuste = (SELECT CONVERT(date, GETDATE()))";

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
            DG_sinal.DataSource = clientes;

        }

        private void Falta_Pagar()
        {
            string strProvider = "Data Source=DEBERGE\\SQLEXPRESS;Initial Catalog=db_sistema;Persist Security Info=True;User ID=sa;Password=Mefazviver77";
            //define a instrução SQL
            string strSql = "select sum(falta_pagar) as Valor from tb_ajustar  where data_ajuste = (SELECT CONVERT(date, GETDATE()))";

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
            DG_faltapagar.DataSource = clientes;

        }
        private void Total_Geral()
        {
            string strProvider = "Data Source=DEBERGE\\SQLEXPRESS;Initial Catalog=db_sistema;Persist Security Info=True;User ID=sa;Password=Mefazviver77";
            //define a instrução SQL
            string strSql = "select sum(total_geral) as Valor from tb_ajustar  where data_ajuste = (SELECT CONVERT(date, GETDATE()))";

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
        private void Dinheiro()
        {
            string strProvider = "Data Source=DEBERGE\\SQLEXPRESS;Initial Catalog=db_sistema;Persist Security Info=True;User ID=sa;Password=Mefazviver77";
            //define a instrução SQL
            string strSql = "select sum(sinal) as Valor from tb_ajustar  where data_ajuste = (SELECT CONVERT(date, GETDATE())) and forma_de_pagamento = 'Dinheiro'";

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
            DG_dinheiro.DataSource = clientes;
        }

        private void frm_caixa_ajustar_Load(object sender, EventArgs e)
        {
            CarregarDados();
            Sinal();
            Falta_Pagar();
            Total_Geral();
            Dinheiro();
        }
    }
}
