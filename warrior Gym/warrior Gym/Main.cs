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

            form_agregar_cliente.Visible = true;
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarCliente form_editarCliente = new EditarCliente();

            form_editarCliente.Visible = true;
        }

        private void registrarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPago form_agregar_pago = new AgregarPago();

            form_agregar_pago.Visible = true;   
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar_pagos mostrar_pagos = new Mostrar_pagos();
            mostrar_pagos.Visible = true;
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exportarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExpoertarTablas exportar = new ExpoertarTablas();
            exportar.ExportarClientesYPagos();
        }
    }
}
