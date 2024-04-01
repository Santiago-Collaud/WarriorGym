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
    public partial class EditarCliente : Form
    {
        private Archivo archivos = new Archivo();
        List<Cliente> listaClientes;
        public EditarCliente()
        {
            InitializeComponent();
            actualizarTabla();
        }

        public void actualizarTabla()
        {
            // Esto podría hacerse en el diseñador del formulario o en el código
            dataGridView_clientes.AutoGenerateColumns = true;
            listaClientes = archivos.ObtenerClientes();
            // Enlazar los datos al DataGridView
            dataGridView_clientes.DataSource = listaClientes;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int idCliente, dias;
        string nombre, apellido,mail,rutina,notas,estado;
        long celular;

        private void dataGridView_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }
        
        private void btn_editar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView_clientes.SelectedRows[0];
            try
            {
                    //int idCliente, string nombre, string apellido,int celular,
                    //string mail,string rutina,int dias,string notas

                    idCliente = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);
                    nombre = Convert.ToString(filaSeleccionada.Cells["Nombre"].Value);
                    apellido = Convert.ToString(filaSeleccionada.Cells["Apellido"].Value);
                    celular = (long)filaSeleccionada.Cells["Celular"].Value;
                    mail = Convert.ToString(filaSeleccionada.Cells["Mail"].Value);
                    rutina = Convert.ToString(filaSeleccionada.Cells["Rutina"].Value);
                    dias = (int)(filaSeleccionada.Cells["Dias"].Value);
                    notas= Convert.ToString(filaSeleccionada.Cells["Notas"].Value);
                    estado= Convert.ToString(filaSeleccionada.Cells["Estado"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }
            Editar_dato_cliente editar = new Editar_dato_cliente(idCliente, nombre, apellido, celular, mail, rutina, dias, notas,estado);
            editar.Visible = true;
           

        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView_clientes.SelectedRows[0];
            try
            {
                //int idCliente, string nombre, string apellido,int celular,
                //string mail,string rutina,int dias,string notas

                idCliente = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);
      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

            DialogResult resultado = MessageBox.Show("¿Borrar Cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Código a ejecutar si el usuario hace clic en "Sí"
                archivos.EliminarCliente(idCliente);

                listaClientes = archivos.ObtenerClientes();
                // Enlazar los datos al DataGridView
                dataGridView_clientes.DataSource = listaClientes;
            }
        }
    }
}
