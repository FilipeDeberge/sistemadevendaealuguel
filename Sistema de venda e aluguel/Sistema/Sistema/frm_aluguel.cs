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
    public partial class frm_aluguel : Form
    {


        public frm_aluguel()
        {
            InitializeComponent();
        }

        private void frm_aluguel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet2.tb_aluguel'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_aluguelTableAdapter1.Fill(this.db_sistemaDataSet2.tb_aluguel);
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet.tb_aluguel'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_aluguelTableAdapter.Fill(this.db_sistemaDataSet.tb_aluguel);
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet.tb_itens_alugar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_itens_alugarTableAdapter.Fill(this.db_sistemaDataSet.tb_itens_alugar);
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet.tb_vestuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_vestuarioTableAdapter.Fill(this.db_sistemaDataSet.tb_vestuario);
            this.Size = new Size(890, 100);
            this.alugarBindingSource.DataSource = DataContextFactory.DataContext.Alugar;
            this.tb_vestuarioBindingSource.DataSource = DataContextFactory.DataContext.Vestuario;
            this.vestuarioBindingSource.DataSource = DataContextFactory.DataContext.Vestuario;
            this.vestuarioBindingSource1.DataSource = DataContextFactory.DataContext.Vestuario;
            this.vestuarioBindingSource2.DataSource = DataContextFactory.DataContext.Vestuario;
            this.funcionarioBindingSource.DataSource = DataContextFactory.DataContext.Funcionario;
            this.itensAluguelBindingSource.DataSource = DataContextFactory.DataContext.ItensAluguel;
            this.alugarBindingSource.AddNew();
        }
        public Alugar AluguelCorrente
        {
            get
            {
                return (Alugar)this.alugarBindingSource.Current;
            }
        }

        public ItensAluguel ItemCorrente
        {
            get
            {
                return (ItensAluguel)this.itensAluguelBindingSource.Current;
            }
        }




        private void btn_alugar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(968, 700);
            this.alugarBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            GP_alugar.Visible = true;
            btn_alugar.Enabled = false;

            this.itensAluguelBindingSource.DataSource = DataContextFactory.DataContext.ItensAluguel.Where(x => x.CodigoVestuario == this.AluguelCorrente.CodigoAlugar);
            NovoItem();
            txt_cliente.Enabled = true;
            txt_cpf.Enabled = true;
            txt_rg.Enabled = true;
            txt_telefone.Enabled = true;
            txt_endereco.Enabled = true;
            CB_funcionario.Enabled = true;
        }

        private void NovoItem()
        {
            this.itensAluguelBindingSource.AddNew();
            this.ItemCorrente.CodigoAluguel = this.AluguelCorrente.CodigoAlugar;
            this.ItemCorrente.Quantidade = 1;
           
        }

        private void btn_novoItem_Click(object sender, EventArgs e)
        {
            this.itensAluguelBindingSource.EndEdit();
            this.DG_aluguel.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();
        }

        private void DG_aluguel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Vestuario)e.Value).Descricao;
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
            decimal total = 0;
            foreach (DataGridViewRow dg in DG_aluguel.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal subtotal = v1;
                dg.Cells[3].Value = subtotal;
                total += subtotal;
            }

            this.AluguelCorrente.TotalGeral = total;
        }
        
        private void VerificarDisponibilidade()
        {
            var verificar = DataContextFactory.DataContext.Vestuario.Count(x => x.Disponibilidade != "NAO" && x.Descricao == CB_vestuario.Text);

            if (verificar > 0)
            {
                MessageBox.Show("Roupa disponível!");
            }
            else
            {
                MessageBox.Show("Essa roupa já está alugada ou reservada!");
            }
        }
        private void btn_finpedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o Pedido?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itensAluguelBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.AluguelCorrente.Desconto = 0;
                this.AluguelCorrente.Sinal = 0;
                btn_novoItem.Enabled = false;
                CB_vestuario.Enabled = false;
                txt_desconto.ReadOnly = false;
                txt_desconto.Focus();
                txt_sinal.ReadOnly = false;
                txt_sinal.Focus();
                btn_finPedido.Enabled = false;
                btn_finAluguel.Enabled = true;
                txt_codigo.Enabled = false;
                CB_pgto.Enabled = true;
            }
        }

        private void btn_finAluguel_Click(object sender, EventArgs e)
        {
            this.AluguelCorrente.Desconto = Convert.ToDecimal(txt_desconto.Text);
            this.AluguelCorrente.Sinal = Convert.ToDecimal(txt_sinal.Text);
            this.AluguelCorrente.FaltaPagar = (decimal)(this.AluguelCorrente.TotalGeral - this.AluguelCorrente.Desconto - this.AluguelCorrente.Sinal);
            this.alugarBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            txt_desconto.Enabled = false;
            txt_sinal.Enabled = false;
            btn_finAluguel.Enabled = false;
            CB_pgto.Enabled = false;


        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            CB_pgto.Enabled = false;
            btn_imprimir.Enabled = true;
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Aluguel finalizado com Sucesso!");
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
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

            
            
            e.Graphics.DrawString("--- Comprovante de Aluguel Cris Martins ---", font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Endereço: Rua Ceará Nº 99, Jardim da Viga, Nova Iguaçú - RJ " + txt_cliente.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("--- Data e hora ---" + DateTime.Now, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("CONTRATO: " + txt_codigo.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Fique atento a data de devolução, que será no dia: " + data_devolucao.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + txt_cliente.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("Funcionário: " + CB_funcionario.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Vestuários ---", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString(txt_itens.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("--- Forma de Pagamento: " + CB_pgto.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Total Geral: R$ " + txt_total_geral.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Sinal: R$ " + txt_sinal.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Falta Pagar: R$ " + txt_total.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("*** TERMO DE RESPONSABILIDADE***" , font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("01 - A locadora se compromete a reservar os itens locados," , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString(" mediante o pagamento a título de sinal de 50%", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("(cinquenta por cento) do valor total deste contrato" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("02 - O contrato deverá ser quitado até a data de retirada." , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("03 - Após a formalização do contrato de aluguel não haverá" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("devolução dos valores pagos a locadora, mesmo que os itens" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("locados não sejam retirados." , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("04 - Os valores pagos a este contrato não poderão ser" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("transferidos para outro contrato." , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("05 - O cliente será responsável por perda ou dano que ocorrer com" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("os itens locados." , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("06 - Caso algum item locado nao seja devolvido, o cliente deverá" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("arcar com os respectivos valores: cabide(R$ 5,00)," , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("capa(R$ 20,00), sacola para sapatos(R$ 10,00), sapato(R$80,00)," , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("outros itens serão cobrados com base no valor de fábrica." , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("07 - Devolução fora do prazo pagará novo aluguel." , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("08 - Os itens locados deverão ser provados pelo cliente no" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("momento da retirada." , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("09 - Os itens locados não deverão ser lavados e/ou passaods pelo" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("cliente." , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("10 - Somente será aceito cartão de crédito no ato do aluguel." , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("o saldo devedor deverá ser quitado até a data de retirada," , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("sendo no débito ou em espécie." , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("11 - Para contratos do setor feminino - é imprescindível que" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("traga no dia da prova a sandália que fará uso em conjunto" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("com o vestido" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("                    ________________________________________" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("                                                 (assinatura)", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Obrigado e volte sempre! ---", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
            
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("-----------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString(" ", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("-------------------------- BUTI  ------------------------", font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Aluguel..:" + DateTime.Now, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("----------RETIRADA: " + data_entrega.Text, font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("----------CONTRATO: " + txt_codigo.Text, font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Fique atento a data de devolução, que será no dia: " + data_devolucao.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
        }

        private void btn_verificador_Click(object sender, EventArgs e)
        {
            VerificarDisponibilidade();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }

}
