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
using System.Drawing.Printing;

namespace Sistema
{
    public partial class frm_ajustar : Form
    {
        public frm_ajustar()
        {
            InitializeComponent();
        }


        private void frm_ajustar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet.tb_ajustar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ajustarTableAdapter.Fill(this.db_sistemaDataSet.tb_ajustar);
            this.ajustarBindingSource.DataSource = DataContextFactory.DataContext.Ajustar;
            this.Size = new Size(576, 100);
            this.ajustarBindingSource.AddNew();

        }
        public Ajustar AjusteCorrente
        {
            get
            {
                return (Ajustar)this.ajustarBindingSource.Current;
            }
        }
        private void btn_ajustar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(576, 708);
            this.ajustarBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            GP_ajustar.Visible = true;
            btn_ajustar.Enabled = false;
            txt_cliente.Enabled = true;
            txt_cpf.Enabled = true;
            txt_rg.Enabled = true;
            txt_telefone.Enabled = true;
            txt_endereco.Enabled = true;
            CB_funcionario.Enabled = true;
        }

        private void btn_finPedido_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o Pedido?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.ajustarBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.AjusteCorrente.Desconto = 0;
                this.AjusteCorrente.Sinal = 0;
                txt_desconto.ReadOnly = false;
                txt_desconto.Focus();
                txt_sinal.ReadOnly = false;
                txt_sinal.Focus();
                btn_finPedido.Enabled = false;
                btn_finAjuste.Enabled = true;
                txt_codigo.Enabled = false;
                CB_pgto.Enabled = true;
            }
        }

        private void btn_finAjuste_Click_1(object sender, EventArgs e)
        {
            this.AjusteCorrente.Desconto = Convert.ToDecimal(txt_desconto.Text);
            this.AjusteCorrente.Sinal = Convert.ToDecimal(txt_sinal.Text);
            this.AjusteCorrente.FaltaPagar = (decimal)(this.AjusteCorrente.TotalGeral - this.AjusteCorrente.Desconto - this.AjusteCorrente.Sinal);
            this.ajustarBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            txt_desconto.Enabled = false;
            txt_sinal.Enabled = false;
            btn_finAjuste.Enabled = false;
            CB_pgto.Enabled = false;
        }
        private void btn_registrar_Click_1(object sender, EventArgs e)
        {
            CB_pgto.Enabled = false;
            btn_imprimir.Enabled = true;
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Ajuste finalizado com Sucesso!");
        }

        private void btn_imprimir_Click_1(object sender, EventArgs e)
        {
            documento = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            documento.PrinterSettings = ps;
            documento.PrintPage += documento_PrintPage;
            documento.Print();
        }

        private void documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 7);
            Font font2 = new Font("Arial", 9);
            Font font3 = new Font("Arial", 10);
            int ancho = 600;
            int y = 20;



            e.Graphics.DrawString("--- Comprovante de Ajuste Cris Martins ---", font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Endereço: Rua Ceará Nº 99, Jardim da Viga, Nova Iguaçú - RJ " + txt_cliente.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("--- Data e hora ---" + DateTime.Now, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("CONTRATO: " + txt_codigo.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Fique atento a data de retirada, que será no dia: " + data_retirada.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + txt_cliente.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("Funcionário: " + CB_funcionario.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Vestuários ---", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("Paleto:" + txt_paleto.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("Colete:" + txt_colete.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("Calça:" + txt_paleto.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("--- Forma de Pagamento: " + CB_pgto.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Total Geral: R$ " + txt_total_geral.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Sinal: R$ " + txt_sinal.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Falta Pagar: R$ " + txt_total.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
        }


    }

}
