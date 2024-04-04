using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;


namespace warrior_Gym
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Configurar mail
        {
            string rutaArchivo = "C:/PROGRAMACION/Trabajos/Warrior_Gym/warrior Gym/warrior Gym/src/Mail.txt";
            Process.Start(rutaArchivo);
        }

        private void button_BackUp_Click(object sender, EventArgs e)
        {
            string directorioOrigen = "C:\\PROGRAMACION\\Trabajos\\Warrior_Gym\\warrior Gym\\warrior Gym\\src\\";

            // Configurar propiedades del SaveFileDialog
            saveFileDialog1.Title = "Guardar archivo comprimido";
            saveFileDialog1.Filter = "Archivos ZIP (*.zip)|*.zip|Todos los archivos (*.*)|*.*";

            // Mostrar el diálogo para seleccionar la ubicación del archivo ZIP final
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string archivoDestino = saveFileDialog1.FileName;

                try
                {
                    // Crear el archivo ZIP
                    ZipFile.CreateFromDirectory(directorioOrigen, archivoDestino);

                    MessageBox.Show("Archivo comprimido creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al comprimir archivos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}
