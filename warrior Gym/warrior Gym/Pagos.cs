using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warrior_Gym
{
    public class Pagos
    {
        public int id_cliente { get; set; }
        public string cliente { get; set; }
        public int id_pago { get; set; }
        public int monto { get; set; }
        public String fecha { get; set; }
        public String mes { get; set; }

        public Pagos(int id_pago, int id_cliente,string cliente, string fecha,string mes, int monto)
        {
            this.id_cliente = id_cliente;
            this.cliente = cliente;
            this.id_pago = id_pago;
            this.monto = monto;
            this.fecha = fecha;
            this.mes = mes;
        }
    }
}
