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
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }

        private void frm_venda_Load(object sender, EventArgs e)
        {
            this.Size = new Size(640, 83);
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
            this.Size = new Size(640, 582);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            btn_novavenda.Enabled = false;

            this.itensVendaBindingSource.DataSource = DataContextFactory.DataContext.ItensVenda.Where (x => x.CodigoVestuario == this.VendaCorrente.CodigoVenda);
            NovoItem();
            CB_cliente.Enabled = false;
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
            this.DG_vendas.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();
        }

        private void DG_vendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Vestuario) e.Value) .Descricao;
        }

        

        private void CB_vestuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_vestuario.SelectedItem != null)
            {
                var pro = (Vestuario)CB_vestuario.SelectedItem;
                this.ItemCorrente.CodigoVestuario = (int)pro.CodigoVestuario;
                this.ItemCorrente.Valor = (decimal)pro.Valor;
            }
        }

        private void MostraSomaValores()
        {
            decimal  total = 0;
            foreach (DataGridViewRow dg in DG_vendas.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subtotal = v1 * v2;
                dg.Cells[4].Value = subtotal;
                total += subtotal;
            }

            this.VendaCorrente.Valor = total;
        }

        private void btn_finPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o Pedido?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itensVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;
                btn_novoitem.Enabled = false;
                CB_vestuario.Enabled = false;
                txt_quantidade.Enabled = false;
                txt_desconto.ReadOnly = false;
                txt_desconto.Focus();
                btn_finPedido.Enabled = false;
                btn_finVenda.Enabled = true;
                txt_codigo.Enabled = false;
            }
        }

        private void btn_finVenda_Click(object sender, EventArgs e)
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

        private void CB_pgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_pgto.SelectedItem != null)
            {
                var status = (StatusPagamento)CB_pgto.SelectedItem;
                if(status.CodigoStatus == 1)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.CodigoStatus;
                    this.ContaCorrente.DataPagamento = DateTime.Now;
                    btn_finalizar.Enabled = true;
                    txt_data_venc.Enabled = false; 
                }
                else if (status.CodigoStatus == 2)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.CodigoStatus;
                    this.ContaCorrente.DataVencimento = DateTime.Now;
                    txt_data_venc.Enabled = true;
                    btn_finalizar.Enabled = true;

                }
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.contasReceberBindingSource.EndEdit();
            txt_data_venc.Enabled = false;
            btn_finalizar.Enabled = false;
            CB_pgto.Enabled = false;
            btn_imprimir.Enabled = true;
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Venda finalizada com Sucesso!");

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DG_vendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
