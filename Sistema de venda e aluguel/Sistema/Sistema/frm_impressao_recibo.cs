using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Sistema
{
    public partial class frm_impressao_recibo : Form
    {
        public frm_impressao_recibo()
        {
            InitializeComponent();
        }

        private void documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 7);
            Font font2 = new Font("Arial", 9);
            Font font3 = new Font("Arial", 10);
            int ancho = 600;
            int y = 20;

            e.Graphics.DrawString("--- Comprovante de Pagamento Cris Martins ---", font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Endereço: Rua Ceará Nº 99, Jardim da Viga, Nova Iguaçú - RJ " + txt_cliente.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("--- Data e hora ---" + DateTime.Now, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("CONTRATO: " + txt_contrato.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + txt_cliente.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Referente a: " + txt_info.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Valor pago: R$" + txt_valor.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Falta Pagar: R$" + txt_restante.Text, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Volte Sempre! ---", font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
        }

        private void btn_imprimir_Click_1(object sender, EventArgs e)
        {
            documento = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            documento.PrinterSettings = ps;
            documento.PrintPage += documento_PrintPage;
            documento.Print();
        }
    }

}
