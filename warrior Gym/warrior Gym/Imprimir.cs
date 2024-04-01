using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace warrior_Gym
{
    public class Imprimir
    {
        private PrintDocument printDocument;
        private string cliente;
        private string fecha;
        private string mes;
        private int idCliente;
        private int idpago;
        private int monto;

        private string rutaImagen= "C:\\PROGRAMACION\\Trabajos\\Warrior_Gym\\warrior Gym\\warrior Gym\\iconos\\Warrior_GYM_comprovante.jpg";

        public Imprimir(int idCliente,int idPago, String cliente, String fecha, int monto, string mes)
        {
            this.idCliente = idCliente;
            this.idpago = idPago;
            this.cliente = cliente;
            this.fecha = fecha;
            this.mes = mes;
            this.monto = monto;

            
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
        }

        public void ImprimirTicket()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Modifica el tamaño de papel
                //printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 850, 200);

                printDocument.Print();
            }
        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            // Cargar la imagen desde la ruta y dibujarla en la página
            
            Image imagen = Image.FromFile(rutaImagen);
            e.Graphics.DrawImage(imagen, new RectangleF(0, 0, 850,200 )); // Ajusta las coordenadas y el tamaño según tus necesidades
           
            using (Font font = new Font("Arial", 20))
            using (Font font2 = new Font("Courier New", 15))
            using (SolidBrush brush = new SolidBrush(Color.Black))  
            {
                int PosY = 55,PosX=360;

                e.Graphics.DrawString($"{cliente}", font, Brushes.Black, new PointF(PosX, PosY));
                e.Graphics.DrawString($"{mes}", font, Brushes.Black, new PointF(PosX, PosY+30));
                e.Graphics.DrawString($"{fecha}", font, Brushes.Black, new PointF(PosX, PosY+60));
                e.Graphics.DrawString($"${monto}", font, Brushes.Black, new PointF(PosX, PosY + 90));
                e.Graphics.DrawString($"{idpago}", font2, Brushes.Black, new PointF(800, 170));


            }
        }
    }
}
