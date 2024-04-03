using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace warrior_Gym
{
    public partial class Agregar_Cliente : Form
    {
        Archivo archivo = new Archivo();//menejo de archivos
        public Agregar_Cliente()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)//Boton Guardar
        {
            String nombre, apellido, mail, rutina, notas, estado;
            int dias, id;
            long celular = 1;
            try
            {
                nombre = text_Nombre.Text;
                apellido = text_apellido.Text;

                // Utilizar int.TryParse para manejar la conversión
                if (long.TryParse(text_celular.Text, out celular) == false)
                {
                    // En caso de error, asignar un valor predeterminado (puede ser 0 u otro)
                    celular = 0;
                }

                
                mail = text_mail.Text;
                rutina = cB_rutina.Text;

                cBox_dias.SelectedItem = 0;
                // Utilizar int.TryParse para manejar la conversión
                if (int.TryParse(cBox_dias.Text, out dias) == false)
                {
                    // En caso de error, asignar un valor predeterminado (puede ser 0 u otro)
                    dias = 0;
                }
                

                notas = text_Notas.Text;
                id = generar_ID();

                estado = "ACTIVO";

                string NOMBRE = nombre.ToUpper();
                string APELLIDO = apellido.ToUpper();
                string mail_lower = mail.ToLower();

                if (archivo.ClienteYaEstaCargado(NOMBRE, APELLIDO,mail_lower,celular) == true)
                {
                    MessageBox.Show("El cliente: " + nombre + " " + apellido + " ya esta cargado");
                }
                else
                {
                    
                    Cliente nuevo_cliente = new Cliente(id, NOMBRE, APELLIDO, celular, mail_lower, rutina, dias, notas, estado);

                    archivo.AgregarCliente(nuevo_cliente);

                    this.Close();

                    MessageBox.Show("Cliente agregado");
                }//cierra else
            }
            catch (Exception ex) { MessageBox.Show("Error al ingresar Datos"+ex); }
        }
        public int generar_ID()
        {
            int id=0;

            return id;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, ignorar la entrada
                e.Handled = true;
            }
        }

        private void text_celular_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
