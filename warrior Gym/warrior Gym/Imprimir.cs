using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DocumentFormat.OpenXml.Vml.Office;

namespace warrior_Gym
{
    public class Imprimir
    {
        private PrintDocument printDocument;
        private PrintDocument printTabla;
        private string cliente;
        private string fecha;
        private string mes;
        private int idCliente;
        private int idpago;
        private int monto;
        private List<Pagos> listaPagos; 

        private string rutaImagen= "C:\\PROGRAMACION\\Trabajos\\Warrior_Gym\\warrior Gym\\warrior Gym\\iconos\\Warrior_GYM_comprovante.jpg";
        private string rutaLogo = "C:\\PROGRAMACION\\Trabajos\\Warrior_Gym\\warrior Gym\\warrior Gym\\iconos\\Warrior_GYM_1.jpg";

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
        //////////////////////////////////////////// 
        //imprimir tabla
        public Imprimir(List<Pagos> listaPagos, string mes)
        {
            this.listaPagos = listaPagos;
            this.mes = mes;
            printTabla = new PrintDocument();
            printTabla.PrintPage += PrintTablaOnPrintPage;
        }
        public void ImprimirTicketTabla()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printTabla;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Modifica el tamaño de papel
                //printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 850, 200);

                printTabla.Print();
            }
        }
        private void PrintTablaOnPrintPage(object sender, PrintPageEventArgs e)
        {
            string MES="";
            // Cargar la imagen desde la ruta y dibujarla en la página

            Image imagen = Image.FromFile(rutaLogo);
            e.Graphics.DrawImage(imagen, new RectangleF(0, 0, 100, 100)); // Ajusta las coordenadas y el tamaño según tus necesidades
            using (Font Titulo = new Font("Arial", 30))
            {
                int PosY = 30, PosX = 300;

                e.Graphics.DrawString($"{mes}", Titulo, Brushes.Black, new PointF(PosX, PosY));
            }

            switch (mes)
            {
                case "Enero":
                    MES = "Ene";
                    break;
                case "Febrero":
                    MES = "Feb";
                    break;
                case "Marzo":
                    MES = "Maz";
                    break;
                case "Abril":
                    MES = "Abr";
                    break;
                case "Mayo":
                    MES = "May";
                    break;
                case "Junio":
                    MES = "Jun";
                    break;
                case "Julio":
                    MES = "Jul";
                    break;
                case "Agosto":
                    MES = "Ago";
                    break;
                case "Septiembre":
                    MES = "Sep";
                    break;
                case "Octubre":
                    MES = "Oct";
                    break;
                case "Noviembre":
                    MES = "Nov";
                    break;
                case "Diciembre":
                    MES = "Dic";
                    break;
            }


            using (Font font = new Font("Arial", 20))
            using (Font font2 = new Font("Courier New", 15))
            using (SolidBrush brush = new SolidBrush(Color.Black))
            {
                int PosY = 100, PosX = 0;

                e.Graphics.DrawString($"Cliente", font, Brushes.Black, new PointF(PosX, PosY));
                e.Graphics.DrawString($"Mes", font, Brushes.Black, new PointF(PosX+270, PosY));
                e.Graphics.DrawString($"Monto", font, Brushes.Black, new PointF(PosX+350, PosY));
                e.Graphics.DrawString($"Fecha", font, Brushes.Black, new PointF(PosX + 450, PosY));
                e.Graphics.DrawString($"id_Cliente", font, Brushes.Black, new PointF(PosX+570, PosY));
                e.Graphics.DrawString($"id_pago", font, Brushes.Black, new PointF(PosX+710, PosY));


                foreach (Pagos pago in listaPagos)
                {
                    
                    // Incrementa la posición Y para dibujar la siguiente fila
                    PosY += 30;

                    // Dibuja los valores de cada pago en la fila correspondiente
                    e.Graphics.DrawString($"{pago.cliente}", font2, Brushes.Black, new PointF(PosX-5, PosY));
                    e.Graphics.DrawString($"{MES}", font2, Brushes.Black, new PointF(PosX + 270, PosY));
                    e.Graphics.DrawString($"{pago.monto}", font2, Brushes.Black, new PointF(PosX + 350, PosY));
                    e.Graphics.DrawString($"{pago.fecha}", font2, Brushes.Black, new PointF(PosX + 450, PosY));
                    e.Graphics.DrawString($"{pago.id_cliente}", font2, Brushes.Black, new PointF(PosX + 630, PosY));
                    e.Graphics.DrawString($"{pago.id_pago}", font2, Brushes.Black, new PointF(PosX + 730, PosY));

                   
                }

            }
        }
    }
}
