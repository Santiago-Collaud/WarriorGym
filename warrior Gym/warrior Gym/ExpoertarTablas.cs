using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using ClosedXML.Excel;
using System.Windows.Forms; // Agrega este using para utilizar OpenFileDialog

namespace warrior_Gym
{
    internal class ExpoertarTablas
    {
        private string connectionStringClientes = "Data Source=C:\\PROGRAMACION\\Trabajos\\Warrior_Gym\\warrior Gym\\warrior Gym\\src\\Clientes.db;";
        private string connectionStringPagos = "Data Source=C:\\PROGRAMACION\\Trabajos\\Warrior_Gym\\warrior Gym\\warrior Gym\\src\\Pagos.db;";

        public void ExportarClientesYPagos()
        {
            // Crea un nuevo cuadro de diálogo para seleccionar la ubicación de destino
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar archivo de Excel";
            saveFileDialog.FileName = "ClientesYPagos.xlsx"; // Nombre predeterminado del archivo

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta de destino seleccionada por el usuario
                string rutaArchivo = saveFileDialog.FileName;

                // Crea un nuevo archivo de Excel en la ruta especificada
                using (var workbook = new XLWorkbook())
                {
                    // Agrega una nueva hoja de trabajo al archivo de Excel
                    var clientesWorksheet = workbook.Worksheets.Add("Clientes");
                    var pagosWorksheet = workbook.Worksheets.Add("Pagos");

                    // Exporta los datos de la tabla Cliente a la hoja de trabajo "Clientes"
                    ExportarTablaACsv("SELECT * FROM Cliente", clientesWorksheet, connectionStringClientes);

                    // Exporta los datos de la tabla Pagos a la hoja de trabajo "Pagos"
                    ExportarTablaACsv("SELECT * FROM Pagos", pagosWorksheet, connectionStringPagos);

                    // Guarda el archivo de Excel en la ubicación seleccionada por el usuario
                    workbook.SaveAs(rutaArchivo);
                }
                MessageBox.Show("Tablas Exportadas");
            }
            
        }

        private void ExportarTablaACsv(string query, IXLWorksheet worksheet, string connectionString)
        {
            // Abre una conexión a la base de datos
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Crea un comando SQLite para ejecutar la consulta
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Obtiene el esquema de la tabla
                        DataTable schemaTable = reader.GetSchemaTable();

                        // Añade los nombres de las columnas a la primera fila de la hoja de trabajo
                        int colIndex = 1;
                        foreach (DataRow row in schemaTable.Rows)
                        {
                            string columnName = Convert.ToString(row["ColumnName"]);
                            worksheet.Cell(1, colIndex).Value = columnName;
                            colIndex++;
                        }

                        // Añade los datos de la tabla a las filas de la hoja de trabajo
                        int rowIndex = 2;
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                // Comprobamos si el valor no es nulo antes de convertirlo
                                if (!reader.IsDBNull(i))
                                {
                                    worksheet.Cell(rowIndex, i + 1).Value = Convert.ToString(reader[i]);
                                }
                                else
                                {
                                    // Si el valor es nulo, podemos manejarlo de la manera que consideremos adecuada
                                    worksheet.Cell(rowIndex, i + 1).Value = string.Empty; // O podemos asignar otro valor predeterminado
                                }
                            }
                            rowIndex++;
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}