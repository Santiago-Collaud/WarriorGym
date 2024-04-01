using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warrior_Gym
{
    public partial class Pago : Form
    {
        int idCliente_;
        string nombreCompleto;
        
        public Pago(int idCliente,string nombre,string apellido,long celular)
        {
            InitializeComponent();
            label_nombre_cliente.Text = nombre + " " + apellido;

            nombreCompleto= nombre + " " + apellido;

            label_Celular.Text = celular.ToString();
            idCliente_ = idCliente;
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            try
            {
                DateTime fechaSeleccionada = monthCalendar1.SelectionStart;
                DateTime ahora = DateTime.Now;

                int dia_ahora, mes_ahora, año_ahora;

                dia_ahora = ahora.Day;
                mes_ahora = ahora.Month;
                año_ahora = ahora.Year;

                int dia = fechaSeleccionada.Day;
                int mes = fechaSeleccionada.Month;
                int año = fechaSeleccionada.Year;

                string fecha_de_pago = dia.ToString() + "/" + mes.ToString() + "/" + año.ToString();

                string mes_pagado = CB_mesPagado.Text;


                int monto = int.Parse(textBox_monto.Text);

                if ((dia_ahora < dia) && (mes_ahora < mes) && (año_ahora < año))
                {
                    MessageBox.Show("Verificar fechas");
                }
                else if(archivo.ClienteYaPagoMes(idCliente_, mes_pagado))
                    {
                    MessageBox.Show("El mes de "+mes_pagado+" ya esta pago");
                    }
                else
                {
                    int id_pago = archivo.incertarPago(idCliente_, nombreCompleto, fecha_de_pago, monto, mes_pagado);
                    MessageBox.Show("Pago registrado");
                    this.Close();

                    //int idCliente,int idPago, String cliente, String fecha, int monto, string mes
                    Imprimir impresion = new Imprimir(idCliente_, id_pago, nombreCompleto, fecha_de_pago, monto, mes_pagado);
                    impresion.ImprimirTicket();

                }//cierra else
            }
            catch (Exception ex)
            { //MessageBox.Show("Error: Completar los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error al generar el PDF: {ex.Message}");

            }
        }

       
    }
}
