
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace warrior_Gym
{

    public class Archivo
    {
        private const string connectionString = "Data Source=C:\\PROGRAMACION\\Trabajos\\Warrior_Gym\\warrior Gym\\warrior Gym\\src\\Clientes.db;";
        private const string connectionString_pagos = "Data Source=C:\\PROGRAMACION\\Trabajos\\Warrior_Gym\\warrior Gym\\warrior Gym\\src\\Pagos.db;";
        
        public void CrearTabla()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(@"
                CREATE TABLE IF NOT EXISTS Cliente (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT,
                    Apellido TEXT,
                    Celular REAL,
                    Mail TEXT,
                    Rutina TEXT,
                    Dias INTEGER,
                    Notas TEXT,
                    Estado TEXT
                )", connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        public void AgregarCliente(Cliente cliente)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand insertCommand = new SQLiteCommand(@"
        INSERT INTO Cliente (Nombre, Apellido, Celular, Mail, Rutina, Dias, Notas, Estado)
        VALUES (@Nombre, @Apellido, @Celular, @Mail, @Rutina, @Dias, @Notas,@Estado)", connection))
                {
                    insertCommand.Parameters.AddWithValue("@Nombre", cliente.nombre);
                    insertCommand.Parameters.AddWithValue("@Apellido", cliente.apellido);
                    insertCommand.Parameters.AddWithValue("@Celular", cliente.celular);
                    insertCommand.Parameters.AddWithValue("@Mail", cliente.mail);
                    insertCommand.Parameters.AddWithValue("@Rutina", cliente.rutina);
                    insertCommand.Parameters.AddWithValue("@Dias", cliente.dias);
                    insertCommand.Parameters.AddWithValue("@Notas", cliente.notas);
                    insertCommand.Parameters.AddWithValue("@Estado", cliente.estado);

                    insertCommand.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM Cliente", connection))
                using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente(
                            Convert.ToInt32(reader["ID"]),
                            Convert.ToString(reader["Nombre"]),
                            Convert.ToString(reader["Apellido"]),
                            Convert.ToInt64(reader["Celular"]),
                            Convert.ToString(reader["Mail"]),
                            Convert.ToString(reader["Rutina"]),
                            Convert.ToInt32(reader["Dias"]),
                            Convert.ToString(reader["Notas"]),
                            Convert.ToString(reader["Estado"])
                        );

                        clientes.Add(cliente);
                    }
                }

                connection.Close();
            }

            return clientes;
        }

        public void ActualizarCliente(Cliente cliente)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand updateCommand = new SQLiteCommand(@"
            UPDATE Cliente
            SET Nombre = @Nombre,
                Apellido = @Apellido,
                Celular = @Celular,
                Mail = @Mail,
                Rutina = @Rutina,
                Dias = @Dias,
                Notas = @Notas,
                Estado = @Estado
            WHERE id = @IdCliente", connection))
                {
                    updateCommand.Parameters.AddWithValue("@Nombre", cliente.nombre);
                    updateCommand.Parameters.AddWithValue("@Apellido", cliente.apellido);
                    updateCommand.Parameters.AddWithValue("@Celular", cliente.celular);
                    updateCommand.Parameters.AddWithValue("@Mail", cliente.mail);
                    updateCommand.Parameters.AddWithValue("@Rutina", cliente.rutina);
                    updateCommand.Parameters.AddWithValue("@Dias", cliente.dias);
                    updateCommand.Parameters.AddWithValue("@Notas", cliente.notas);
                    updateCommand.Parameters.AddWithValue("@IdCliente", cliente.id);
                    updateCommand.Parameters.AddWithValue("@Estado", cliente.estado);

                    updateCommand.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        public void EliminarCliente(int idCliente)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand deleteCommand = new SQLiteCommand("DELETE FROM Cliente WHERE id = @Id", connection))
                {
                    deleteCommand.Parameters.AddWithValue("@Id", idCliente);

                    deleteCommand.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///PAGOS///
        
        public void CrearTabla_Pagos()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString_pagos))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(@"
                CREATE TABLE IF NOT EXISTS Pagos (
                    idPago INTEGER PRIMARY KEY AUTOINCREMENT,
                    IDCliente INTEGER,
                    Nombre TEXT,
                    FechaPago TEXT,
                    MesPagado TEXT,
                    MontoPagado INTEGER 
                )", connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            } 
        }

        public int incertarPago(int IdCliente,string nombre,String fecha_de_pago,int monto,string mes_pagado)
        {
            int idPago = -1;//valor por defecto en caso que no se encuentre el id de pago
            using (SQLiteConnection connection = new SQLiteConnection(connectionString_pagos))
            {
                connection.Open();
                using (SQLiteCommand insertCommand = new SQLiteCommand(@"
                    INSERT INTO Pagos (IDCliente,Nombre, FechaPago, MesPagado, MontoPagado)
                    VALUES (@IDCliente,@Nombre, @FechaPago, @MesPagado, @MontoPagado);
                    SELECT last_insert_rowid();", connection))
                {
                    // Agregar parámetros con valores
                    insertCommand.Parameters.AddWithValue("@IDCliente", IdCliente);
                    insertCommand.Parameters.AddWithValue("@Nombre", nombre);
                    insertCommand.Parameters.AddWithValue("@FechaPago", fecha_de_pago);
                    insertCommand.Parameters.AddWithValue("@MesPagado", mes_pagado);
                    insertCommand.Parameters.AddWithValue("@MontoPagado", monto);

                    // Ejecutar la consulta y obtener el ID del pago insertado
                    idPago = Convert.ToInt32(insertCommand.ExecuteScalar());
                }
            }
            return idPago;
        }

        public List<Pagos> ObtenerPagos()
        {
            List<Pagos> list_pago = new List<Pagos>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString_pagos))
            {
                connection.Open();

                using (SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM Pagos", connection))
                using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int clienteId = Convert.ToInt32(reader["IDCliente"]);

                        // Crear un objeto Pagos con el nombre del cliente
                        Pagos estePago = new Pagos(
                            Convert.ToInt32(reader["idPago"]),
                            clienteId,
                            Convert.ToString(reader["Nombre"]),
                            Convert.ToString(reader["FechaPago"]),
                            Convert.ToString(reader["MesPagado"]),
                            Convert.ToInt32(reader["MontoPagado"]) 
                        );
                        list_pago.Add(estePago);
                    }
                }

                connection.Close();
            }

            return list_pago;
        }

        public bool ClienteYaPagoMes(int idCliente, string mesPagado)
        {
            bool yaPago = false;//true -> mes pago, false -> mes con falta de pago

            using (SQLiteConnection connection = new SQLiteConnection(connectionString_pagos))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT COUNT(*) FROM Pagos WHERE IDCliente = @IDCliente AND MesPagado = @MesPagado", connection))
                {
                    command.Parameters.AddWithValue("@IDCliente", idCliente);
                    command.Parameters.AddWithValue("@MesPagado", mesPagado);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Si count es mayor que 0, significa que el cliente ya pagó ese mes
                    yaPago = count > 0;
                }

                connection.Close();
            }

            return yaPago;
        }

    }
}
