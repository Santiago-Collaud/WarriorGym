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
    public partial class Estadisticas : Form
    {
        Archivo archivo = new Archivo();

        List<Cliente> listaClientes = new List<Cliente>();
        List<Pagos> listaPagos = new List<Pagos>();
        public Estadisticas()
        {
            InitializeComponent();    
        }

        private void button_Buscar_estado_Click(object sender, EventArgs e)
        {
            String estado = comboBox_Estado.Text;
            listaClientes= archivo.ObtenerClientesPorEstado(estado);

            dataGridView_Estado.AutoGenerateColumns = true;
            dataGridView_Estado.DataSource = listaClientes;
        }
        String mes;
        private void button_Buscar_mes_Click(object sender, EventArgs e)
        {
            mes = comboBox_Mes.Text;

            listaPagos = archivo.ObtenerPagosPorMes(mes);

            dataGridView_Meses.AutoGenerateColumns = true;
            dataGridView_Meses.DataSource = listaPagos;

            int montoMes = 0;
            foreach (var pago in listaPagos)
            {
                montoMes += pago.monto;
            }


            label_pagos_mes.Text = Convert.ToString(montoMes);
        }

        private void button_imprimir_Click(object sender, EventArgs e)
        {
            Imprimir imprimir = new Imprimir(listaPagos,mes);
            imprimir.ImprimirTicketTabla();
        }
    }
}
