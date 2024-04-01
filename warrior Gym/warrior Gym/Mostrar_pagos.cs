using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warrior_Gym
{
    public partial class Mostrar_pagos : Form
    {
        private Archivo archivos = new Archivo();
        List<Pagos> listPagos = new List<Pagos>();
        public Mostrar_pagos()
        {
            InitializeComponent();
            // Esto podría hacerse en el diseñador del formulario o en el código
            dataGridView_mostrar_pagos.AutoGenerateColumns = true;
            listPagos = archivos.ObtenerPagos();
            // Enlazar los datos al DataGridView
            dataGridView_mostrar_pagos.DataSource = listPagos;

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            int idCliente, monto,id_pago;
            string cliente, fecha, mes;
            DataGridViewRow filaSeleccionada = dataGridView_mostrar_pagos.SelectedRows[0];
            try
            {
                idCliente = Convert.ToInt32(filaSeleccionada.Cells["id_cliente"].Value);
                id_pago = Convert.ToInt32(filaSeleccionada.Cells["id_cliente"].Value);
                cliente = Convert.ToString(filaSeleccionada.Cells["cliente"].Value);
                fecha = Convert.ToString(filaSeleccionada.Cells["fecha"].Value);
                monto = (int)filaSeleccionada.Cells["monto"].Value;
                mes = Convert.ToString(filaSeleccionada.Cells["mes"].Value);

                //int idCliente,int idPago, String cliente, String fecha, int monto, string mes
                Imprimir impresion = new Imprimir(idCliente,id_pago,cliente,fecha,monto,mes);
                impresion.ImprimirTicket();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

        }
    }
}
