using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class AgregarPago : Form
    {
        private Archivo archivos = new Archivo();
        List<Cliente> listaClientes;
        public AgregarPago()
        {
            InitializeComponent();
            // Esto podría hacerse en el diseñador del formulario o en el código
            dataGrid_clientes.AutoGenerateColumns = true;
            listaClientes = archivos.ObtenerClientes();
            // Enlazar los datos al DataGridView
            dataGrid_clientes.DataSource = listaClientes;
        }
        int idCliente;
        String nombre, apellido;
        long celular;

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//btn_pagar
        {
            dataGrid_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//para que queden toda la fila seleccionada
            DataGridViewRow filaSeleccionada = dataGrid_clientes.SelectedRows[0];
            try
            {
                idCliente = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);
                nombre = Convert.ToString(filaSeleccionada.Cells["Nombre"].Value);
                apellido = Convert.ToString(filaSeleccionada.Cells["Apellido"].Value);
                celular = (long)filaSeleccionada.Cells["Celular"].Value;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }
            Pago pago = new Pago(idCliente,nombre,apellido,celular);
            pago.Visible = true;
            this.Close();
        }
    }
}
