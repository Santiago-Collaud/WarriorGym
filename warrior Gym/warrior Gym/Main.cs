using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            Archivo archivo = new Archivo();

            archivo.CrearTabla();//tabla de clientes
            archivo.CrearTabla_Pagos();//tabla pagos

        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Cliente form_agregar_cliente = new Agregar_Cliente();

            //form_agregar_cliente.Visible = true;

            form_agregar_cliente.Owner = this; // Establece el formulario principal como propietario del formulario secundario
            form_agregar_cliente.Show();
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarCliente form_editarCliente = new EditarCliente();

           // form_editarCliente.Visible = true;
            form_editarCliente.Owner = this; // Establece el formulario principal como propietario del formulario secundario
            form_editarCliente.Show();
        }

        private void registrarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPago form_agregar_pago = new AgregarPago();

            //form_agregar_pago.Visible = true;

            form_agregar_pago.Owner = this;
            form_agregar_pago.Show();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar_pagos mostrar_pagos = new Mostrar_pagos();
            //mostrar_pagos.Visible = true;

            mostrar_pagos.Owner = this;
            mostrar_pagos.Show();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exportarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExpoertarTablas exportar = new ExpoertarTablas();
            exportar.ExportarClientesYPagos();

        }

        private void enviarMailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mail mail_ = new mail();
            //mail_.Visible = true;

            mail_.Owner = this;
            mail_.Show();
        }

        private void estaditicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas estaditicas = new Estadisticas();
            //estaditicas.Visible = true;

            estaditicas.Owner = this;
            estaditicas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)//CONFIGURACION
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Owner = this;
            configuracion.Show();
        }
    }
}
