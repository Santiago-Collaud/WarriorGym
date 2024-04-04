using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace warrior_Gym
{
    public partial class mail : Form
    {
        private string myEmail = "";
        private string MyPassword = "";
        private string MyAlias = "";
        private string mailDestino = "";
        private string[] myAdjuntos;
        private MailMessage mCorreo;

        string rutaArchivo = "C:/PROGRAMACION/Trabajos/Warrior_Gym/warrior Gym/warrior Gym/src/Mail.txt";

        Archivo archivo=new Archivo();
        List<Cliente> listaClientes;
        public mail()
        {
            InitializeComponent();
            // Esto podría hacerse en el diseñador del formulario o en el código
            dataGridView_ClientesParaMail.AutoGenerateColumns = true;
            listaClientes = archivo.ObtenerClientes();
            // Enlazar los datos al DataGridView
            dataGridView_ClientesParaMail.DataSource = listaClientes;

            leerTXT();
        }

        public void leerTXT()
        {
            try
            {
                // Abre el archivo para lectura
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    // Lee las lineas
                    myEmail = sr.ReadLine();
                    MyPassword = sr.ReadLine();
                    MyAlias= sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }
        public string mailCliente()
        {
            string mail="";
            dataGridView_ClientesParaMail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridView_ClientesParaMail.SelectedRows.Count > 0)
            {
                // Obtén la primera fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView_ClientesParaMail.SelectedRows[0];

                try
                {
                    // Intenta obtener el valor de la celda "Mail" de la fila seleccionada
                    mail = Convert.ToString(filaSeleccionada.Cells["Mail"].Value);
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir al obtener el valor de la celda
                    MessageBox.Show("Error al obtener el correo electrónico del cliente: " + ex.Message);
                }
            }
            else
            {
                // Muestra un mensaje si no hay ninguna fila seleccionada
                MessageBox.Show("No se ha seleccionado ningún cliente.");
            }

            return mail;
        }

        private void CrearCuerpoCorreo()
        {
            try
            {
                mCorreo = new MailMessage();
                mCorreo.From = new MailAddress(myEmail, MyAlias, System.Text.Encoding.UTF8);
                mCorreo.To.Add(mailCliente());
                mCorreo.Subject = textBox_asunto.Text.Trim();
                mCorreo.Body = textBox_mensaje.Text.Trim();
                mCorreo.IsBodyHtml = true;
                mCorreo.Priority = MailPriority.High;

                // Adjuntos
                for (int i = 0; i < myAdjuntos.Length; i++)
                {
                    mCorreo.Attachments.Add(new Attachment(myAdjuntos[i]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verificar datos");
            }
        }

        private void Enviar()
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Port = 25;
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential(myEmail, MyPassword);
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) { return true; };
                smtp.EnableSsl = true;
                smtp.Send(mCorreo);
                MessageBox.Show("Enviado");
                lblFiles.Text = "";
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

        private void AdjuntarArchivos()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Adjuntar archivos al correo";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                myAdjuntos = ofd.FileNames;
            }

            // Construye una cadena con los nombres de archivo seleccionados
            string names = string.Join("\n", myAdjuntos);

            // Muestra la cadena de nombres de archivo en la etiqueta
            lblFiles.Text = names;

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir", "Salir", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_adjuntar_Click(object sender, EventArgs e)
        {
            AdjuntarArchivos();
        }

        private void button_Enviar_Click(object sender, EventArgs e)
        {
            CrearCuerpoCorreo();
            Enviar();
        }
    }
}
