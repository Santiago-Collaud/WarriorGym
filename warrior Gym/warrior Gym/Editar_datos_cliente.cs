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
    public partial class Editar_dato_cliente : Form
    {
        EditarCliente editar = new EditarCliente();
        public Editar_dato_cliente()
        {
            InitializeComponent();
           
        }
        public Editar_dato_cliente(int idCliente, string nombre, string apellido,long celular,string mail,string rutina,int dias,string notas,string Estado)
        {
            InitializeComponent();

            text_ID.Text = idCliente.ToString();
            text_nombre.Text = nombre;
            text_apellido.Text = apellido;
            text_mail.Text = mail;
            text_celular.Text = celular.ToString();
            comboBox_dias.SelectedIndex = dias-1;

            int indice = comboBox_rutina.FindStringExact(rutina);
            comboBox_rutina.SelectedIndex = indice;
            
            textBox_notas.Text= notas;

            int indice_estado = comboBox_estado.FindStringExact(Estado);
            comboBox_estado.SelectedIndex = indice_estado;

        }

        private void button2_Click(object sender, EventArgs e)//btn_cancelar
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int ID=int.Parse(text_ID.Text);
            string nombre=text_nombre.Text;
            string apellido=text_apellido.Text;
            string mail=text_mail.Text; 
            long celular=long.Parse(text_celular.Text);
            int dias=comboBox_dias.SelectedIndex+1;
            string rutina=comboBox_rutina.Text;
            string notas=textBox_notas.Text;
            string estado = comboBox_estado.Text;

            Cliente cliente = new Cliente(ID, nombre, apellido, celular, mail, rutina, dias, notas,estado);

            Archivo archivo = new Archivo();
            archivo.ActualizarCliente(cliente);

            
            editar.actualizarTabla();

            this.Close();   
        }

        private void textBox_notas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
