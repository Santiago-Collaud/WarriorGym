using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warrior_Gym
{
    public class Cliente
    {
        public int id{ get; set; }
        public String nombre {get; set;}
        public String apellido { get; set; }     
        public long celular  { get; set; }
        public String mail { get; set; }
        public String rutina { get; set; }
        public int dias { get; set;}
        public String notas { get; set;}

        public String estado { get; set; }
       

        public Cliente(int id,string nombre, string apellido, long celular, string mail, string rutina, int dias, string notas,string Estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.mail = mail;
            this.rutina = rutina;
            this.dias = dias;
            this.notas = notas;
            this.estado = Estado;
        }
    }
}
