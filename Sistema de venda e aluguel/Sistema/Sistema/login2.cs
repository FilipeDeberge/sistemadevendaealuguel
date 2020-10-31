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
    public partial class frm_login2 : Form
    {
        public bool logado = false;
        public frm_login2()
        {
            InitializeComponent();
        }

        private void EfetuarLogin()
        {
            var user = DataContextFactory.DataContext.Usuarios.Count(x => x.Usuario == txt_usuario.Text && x.Senha == txt_senha.Text);

            if (user > 0)
            {
                this.logado = true;
                this.Dispose();
                MessageBox.Show("Bem vindo!");
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }
        private void frm_login2_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            EfetuarLogin();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
