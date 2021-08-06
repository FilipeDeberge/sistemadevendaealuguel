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
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }

        private void frm_venda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet.tb_funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_funcionariosTableAdapter.Fill(this.db_sistemaDataSet.tb_funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet1.tb_venda'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_vendaTableAdapter.Fill(this.db_sistemaDataSet1.tb_venda);
            this.Size = new Size(530, 100);
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Venda;
            this.vestuarioBindingSource.DataSource = DataContextFactory.DataContext.Vestuario;
            this.contasReceberBindingSource.DataSource = DataContextFactory.DataContext.ContasReceber;
            this.statusPagamentoBindingSource.DataSource = DataContextFactory.DataContext.StatusPagamento;
            this.vendaBindingSource.AddNew();
        }

        public Venda VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }

        public ItensVenda ItemCorrente
        {
            get
            {
                return (ItensVenda)this.itensVendaBindingSource.Current;
            }
        }

        public ContasReceber ContaCorrente
        {
            get
            {
                return (ContasReceber)this.contasReceberBindingSource.Current;
            }
        }

        private void btn_novavenda_Click(object sender, EventArgs e)
        {
            this.Size = new Size(530, 684);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            btn_novavenda.Enabled = false;
            CB_pgto.Visible = true;

            this.itensVendaBindingSource.DataSource = DataContextFactory.DataContext.ItensVenda.Where (x => x.CodigoVestuario == this.VendaCorrente.CodigoVenda);
          
            
        }

        private void NovoItem()
        {
            this.itensVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ItemCorrente.Quantidade = 1;
        }

        private void btn_novoitem_Click(object sender, EventArgs e)
        {
            this.itensVendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            
           
        }


        private void btn_finPedido_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o Pedido?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itensVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;
                txt_desconto.ReadOnly = false;
                txt_desconto.Focus();
                btn_finPedido.Enabled = false;
                btn_finVenda.Enabled = true;
                txt_codigo.Enabled = false;
            }
        }

        private void btn_finVenda_Click_1(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(txt_desconto.Text);
            this.VendaCorrente.ValorPago = (decimal)(this.VendaCorrente.Valor - this.VendaCorrente.Desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            txt_desconto.Enabled = false;
            btn_finVenda.Enabled = false;
            CB_pgto.Enabled = true;

            this.contasReceberBindingSource.AddNew();
            this.ContaCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ContaCorrente.DataCompra = DateTime.Now;
            this.ContaCorrente.DataVencimento = DateTime.Now;
        }



        private void btn_finalizar_Click_1(object sender, EventArgs e)
        {
            this.contasReceberBindingSource.EndEdit();
            btn_finVenda.Enabled = false;
            CB_pgto.Enabled = false;
            btn_imprimir.Enabled = true;
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Venda finalizada com Sucesso!");

        }
        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }


        private void documento_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 7);
            Font font2 = new Font("Arial", 9);
            Font font3 = new Font("Arial", 10);
            int ancho = 600;
            int y = 20;


            e.Graphics.DrawString("--- Comprovante de Venda Cris Martins ---", font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Endereço: Rua Ceará Nº 99, Jardim da Viga, Nova Iguaçú - RJ " + txt_cliente.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("--- Data e hora ---" + DateTime.Now, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("CONTRATO: " + txt_codigo.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + txt_cliente.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("Funcionário: " + cb_funcionario.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Vestuários ---", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString(txt_itens.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("--- Forma de Pagamento: " + CB_pgto.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Desconto: R$ " + txt_desconto.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Total Geral: R$ " + txt_valorTotal.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            documento = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            documento.PrinterSettings = ps;
            documento.PrintPage += documento_PrintPage_1;
            documento.Print();
        }
    }
}
