using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALAM.utils
{
    public class database_utils
    {
        public int initialize()
        {
            return 1;
        }

        public List<List<object>> ReadDataInDataBase(string table, string dataBasePath = "", string key = "", string value = "")
        {
            string connectionString = $"Data Source={dataBasePath};Version=3;";
            List<List<object>> data = new List<List<object>>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {table}";

                    if (key == "" || value == "")
                    {
                        query = $"SELECT * FROM {table}";
                    }
                    else
                    {
                        query = $"SELECT * FROM {table} WHERE {key} = '{value}'";
                    }
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                List<object> row = new List<object>();

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row.Add(reader.GetValue(i)); // Agrega cada valor de la fila a la lista
                                }

                                data.Add(row); // Agrega la fila completa a la lista principal
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer la base de datos: " + ex.Message);
            }

            return data;
        }
    }
}
