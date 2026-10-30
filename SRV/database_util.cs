using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALAM.SRV
{
    public class database_util
    {
        public static string dbPath;
        public database_util(string db_Path)
        {
            dbPath = db_Path;
        }

        public static void InitializeDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();

                    string createTableQuery = @"
        CREATE TABLE IF NOT EXISTS Inventory (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            nombre TEXT NOT NULL,
            precio REAL NOT NULL,
            identificador TEXT NOT NULL
        );";

                    using (var command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al inicializar la base de datos: " + ex.Message);
            }
        }


        // funcion en deshuso...
        public byte[] ReadImageUser(string key, string value, string db, string table = "users", string name = "img")
        {
            using (var connection = new SQLiteConnection($"Data Source={db};Version=3;"))
            {
                connection.Open();
                var selectQuery = new SQLiteCommand($"SELECT {name} FROM {table} WHERE {key} = @value", connection);
                selectQuery.Parameters.AddWithValue("@value", value);

                using (var reader = selectQuery.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            byte[] imageData = (byte[])reader[0];
                            //File.WriteAllBytes(RutaManager.RutaProyecto+"\\clone\\img_user.jpg", imageData);
                            return imageData;
                        }
                    }
                }
            }
            return null;
        }

        public List<List<object>> ReadDataInDataBase(string table, string dataBasePath = "", string key = "", string value = "")
        {
            if (string.IsNullOrEmpty(dataBasePath))
            {
                dataBasePath = dbPath; // Usa la ruta por defecto si no se proporciona
            }
            string connectionString = $"Data Source={dataBasePath};Version=3;";
            List<List<object>> data = new List<List<object>>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {table}"; // Cambia 'Inventory' si tu tabla tiene otro nombre

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
        public bool InsertDataInDataBase(string table, string dataBasePath, string nombre, int precio, string id)
        {
            if (string.IsNullOrEmpty(dataBasePath))
            {
                dataBasePath = dbPath; // Usa la ruta por defecto si no se proporciona
            }
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();
                    string insertQuery = $"INSERT INTO {table} (nombre, precio, identificador) VALUES (@Nombre, @Precio, @ID);";

                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@ID", id);
                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("Datos insertados exitosamente.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar datos: " + ex.Message);
                return false;
            }
        }
    }
}
