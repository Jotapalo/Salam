using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Data.SQLite;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace SALAM.SRV
{

    public partial class Form_SRV : Form
    {
        Form_home formHome;
        public static string dbPath;
        public static string record_txtPath;
        public static string record_jsonPath;
        public static string consolePrefix = ">> ";

        public static database_util dataBaseManager;
        readonly Form_SRV_OP_database ventanaDB;
        readonly Form_SRV_OP_console ventanaConsola;
        readonly Form_settings ventanaConfiguraciones;


        public Form_SRV(Form_home formHome)
        {

            InitializeComponent();
            this.formHome = formHome;
            FormClosing += new FormClosingEventHandler(Form_SRV_FormClosing);
            
            load_roots();
            dataBaseManager = new database_util(dbPath);

            ConfigurarPredicciones_nombre();

            ventanaDB = new Form_SRV_OP_database(this);
            ventanaConsola = new Form_SRV_OP_console(this);
            ventanaConfiguraciones = new Form_settings(this);

            Enabled = true;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            textBoxNombre.Focus();

            actualizrUserInfo();
        }

        public static void load_roots()
        {
            // Cargar las rutas de los archivos de registros y base de datos
            // ACTUALIZADO
            dbPath = PathManager.Database_inventory;
            record_txtPath = PathManager.RegistroTxt;
            record_jsonPath = PathManager.RegistroJson;
        }

        public void ConfigurarPredicciones_nombre()
        {
            // ACTUALIZADO
            List<string> listNameConcurrences = new List<string>();
            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
            List<List<object>> dataInfo = dataBaseManager.ReadDataInDataBase("inventory");


            foreach (var row in dataInfo)
            {
                listNameConcurrences.Add(row[1].ToString());
            }

            autoCompleteData.AddRange(listNameConcurrences.ToArray());

            // Configurar las propiedades de autocompletado
            textBoxNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxNombre.AutoCompleteCustomSource = autoCompleteData;
        }

        private bool AgregarItem()
        {
            // ACTUALIZADO
            int numerador = listView_listaItems.Items.Count + 1;
            string nombre = textBoxNombre.Text;
            string unds = textBoxUnidades.Text;
            string precio = textBoxPrecio.Text;
            string id = textBoxCategoria.Text;

            if ((nombre == "" || unds == "" || precio == "" || id == ""))
            {
                MessageBox.Show("Todos los campos deben estar completos.");
                return false;
            }

            string subtotal = (int.Parse(unds) * float.Parse(precio)).ToString();

            // POSIBLE EXCEPCION

            foreach (ListViewItem item in listView_listaItems.Items)
            {
                if (item.SubItems[1].Text.ToLower() == nombre.ToLower())
                {
                    Console.WriteLine("Se actualizo el item");
                    item.SubItems[2].Text = unds.ToString();
                    item.SubItems[3].Text = precio.ToString();
                    item.SubItems[5].Text = subtotal.ToString();
                    return true;
                }
            }

            try
            {
                int.Parse(unds);
                float.Parse(precio);
            }
            catch (FormatException)
            {
                MessageBox.Show("Los valores tienen que ser numericos en los campos 'Unidades' y 'Precio'");
                return false;
            }

            {
                ListViewItem item1 = new ListViewItem(new[] { numerador.ToString(), nombre, unds, precio, id, subtotal });

                listView_listaItems.Items.Add(item1);
                return true;
            }

        }

        private void ReorganizarNumeradores()
        {
            // ACTUALIZADO
            // Reenumerar los identificadores
            for (int i = 0; i < listView_listaItems.Items.Count; i++)
            {
                listView_listaItems.Items[i].SubItems[0].Text = (i + 1).ToString(); // Asignar nuevo ID
            }
        }

        private void LimpiarLista()
        {
            // ACTUALIZADO
            // Limpiar las entradas...
            textBoxNombre.Text = "";
            textBoxUnidades.Text = "";
            textBoxPrecio.Text = "";
            textBoxCategoria.Text = "";
        }

        private void BorrarItemsSeleccionados()
        {
            // ACTUALIZADO
            if (listView_listaItems.SelectedItems.Count > 0)
            {
                // Eliminar el ítem seleccionado
                foreach (ListViewItem item in listView_listaItems.SelectedItems)
                {
                    listView_listaItems.Items.Remove(item);
                }
                ReorganizarNumeradores();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un ítem para borrar.");
            }
        }

        private void BorrarTodo()
        {
            // ACTUALIZADO
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar los items seleccionados?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem item in listView_listaItems.Items)
                {
                    listView_listaItems.Items.Remove(item);
                }
            }
        }

        private void ActualizarPrecioTotal()
        {
            // ACTUALIZADO
            float value = 0f;
            foreach (ListViewItem item in listView_listaItems.Items)
            {
                value += float.Parse(item.SubItems[5].Text);
            }
            Console.WriteLine($"El total es: {value}");
            labelCostoTotalNumerico.Text = value.ToString("C", new CultureInfo("es-CO"));
        }

        private void CrearRegistro()
        {
            // ACTUALIZADO
            DateTime fechaHoraActual = DateTime.Now;
            string tiempo = fechaHoraActual.ToString("dd/MM/yyyy HH:mm:ss");

            string items = "";
            float costoTotal = 0f;

            // Construir item a item para agregar 
            foreach (ListViewItem item in listView_listaItems.Items)
            {
                string nombre = item.SubItems[1].Text; // NOMBRE
                string unidades = item.SubItems[2].Text; // UNIDADES
                string precio = Formatear_pesos(item.SubItems[3].Text); // PRECIO
                string subTotal = Formatear_pesos(
                    item.SubItems[5].Text
                    );

                costoTotal += float.Parse(subTotal);
                items += $"{nombre,-30}{unidades,-6}{precio,-12}{subTotal,-14}\r\n";
            }

            string textoRegistro = $"{tiempo}\r\nVendedor en caja: {Usuario.name}\r\n\r\n";
            string linea = new string('-', 60);

            textoRegistro += linea + "\r\n";
            textoRegistro += $"{"Nombre",-30}{"Unds",-6}{"Costo unit.",-12}{"Subtotal",-11}\r\n";
            textoRegistro += linea + "\r\n\r\n";
            textoRegistro += items;
            textoRegistro += "\r\n" + linea;
            textoRegistro += $"\r\n{"Costo total:",-48}{Formatear_pesos(costoTotal)}\r\n";
            textoRegistro += linea + "\r\n";

            // Agregar al textBox
            textBoxGraficadorRegistro.Text = textoRegistro;
        }

        private void CrearRegistroJson(string nombre_vendedor, DateTime dateTime, System.Windows.Forms.ListView lista)
        {
            // ACTUALIZADO
            // 1. Leer el contenido actual del archivo (o crear una lista vacía si no existe o está vacío)
            JArray registros;
            if (File.Exists(record_jsonPath) && new FileInfo(record_jsonPath).Length > 0)
            {
                string json_ctx = File.ReadAllText(record_jsonPath);
                try
                {
                    registros = JArray.Parse(json_ctx);
                }
                catch
                {
                    // Si el archivo no es un array, lo inicializamos vacío
                    registros = new JArray();
                }
            }
            else
            {
                registros = new JArray();
            }

            // 2. Crear el nuevo objeto ITEM
            var dataObj = new JObject
            {
                ["nombre_vendedor"] = nombre_vendedor,
                ["fecha"] = dateTime.ToString("dd/MM/yyyy HH:mm:ss")
            };

            var itemsList = new JArray();
            foreach (ListViewItem item in lista.Items)
            {
                itemsList.Add(new JObject
                {
                    ["nombre"] = item.SubItems[1].Text,
                    ["unidades"] = item.SubItems[2].Text,
                    ["precio"] = item.SubItems[3].Text,
                    ["subtotal"] = item.SubItems[5].Text
                });
            }

            var itemObj = new JObject
            {
                ["ITEM"] = new JObject
                {
                    ["DATA"] = dataObj,
                    ["ITEMS"] = itemsList
                }
            };

            // 3. Agregar el nuevo ITEM al array y guardar
            registros.Add(itemObj);
            File.WriteAllText(record_jsonPath, registros.ToString(Formatting.Indented));
        }


        private void CrearRegistroRecibo(string texto)
        {
            // ACTUALIZADO
            try
            {
                string textoR = texto + "\n\n\n\n";
                using (StreamWriter writer = new StreamWriter(record_txtPath, true))
                {
                    writer.WriteLine(textoR);
                }
                Console.WriteLine("Se ha creado un nuevo registro.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al crear el archivo: {ex.Message}");
            }
        }

        private string Formatear_pesos(float precio)
        {
            // ACTUALIZADO
            return string.Format(new CultureInfo("es-ES"), "{0:N0}", precio);
        }
        
        private string Formatear_pesos(string precio)
        {
            // ACTUALIZADO
            return string.Format(new CultureInfo("es-ES"), "{0:N0}", float.Parse(precio));
        }

        private bool Fill_spaces()
        {
            // ACTUALIZADO
            string Nombre = textBoxNombre.Text;
            List<List<object>> data = dataBaseManager.ReadDataInDataBase("inventory", key: "name", value: Nombre);

            if (data.Count == 0)
            {
                MessageBox.Show("No se encontró el producto en la base de datos.");
                return false;
            }
            textBoxPrecio.Text = data[0][3].ToString();
            textBoxCategoria.Text = data[0][6].ToString();
            return true;
        }

        public void mod_stock_by_name(string nombre, int count_to_substract)
        {
            int nuevoStock;

            string connectionString = $"Data Source={dbPath};Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                // Seleccionar la fila
                string selectQuery = "SELECT * FROM inventory WHERE name = @name";
                using (var selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@name", nombre);
                    using (var reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int stock = Convert.ToInt32(reader["stock"]);
                            nuevoStock = stock - count_to_substract;
                            reader.Close();
                            string updateQuery = "UPDATE inventory SET stock = @stock WHERE name = @name";
                            using (var updateCommand = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@stock", nuevoStock);
                                updateCommand.Parameters.AddWithValue("@name", nombre);
                                updateCommand.ExecuteNonQuery();
                                Debug.WriteLine("Succes!");
                            }
                        }
                    }
                }
            }
        }

        private void EnviarCambiosInventarioBaseDatos()
        {
            foreach (ListViewItem item in listView_listaItems.Items)
            {
                string nombre = item.SubItems[1].Text;
                int unidades = int.Parse(item.SubItems[2].Text);
                mod_stock_by_name(nombre, unidades);
            }
        }

        // Eventos de los botones
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Esto cancela la entrada de la tecla
            }

            if (e.KeyChar == 'f' || e.KeyChar == 'F')
            {
                if (textBoxUnidades.Text == "")
                {
                    textBoxUnidades.Text = "1";
                }
                buttonAdd.Focus();
                if (Fill_spaces())
                {
                    Console.WriteLine("DATABASE >> Se relleno con exito");
                }
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Esto cancela la entrada de la tecla
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AgregarItem())
            {
                LimpiarLista();
                ActualizarPrecioTotal();
                textBoxNombre.Focus();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarLista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BorrarItemsSeleccionados();
            ActualizarPrecioTotal();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BorrarTodo();
            ActualizarPrecioTotal();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CrearRegistro();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CrearRegistroJson(Usuario.name, DateTime.Now, listView_listaItems);
            CrearRegistro();
            CrearRegistroRecibo(textBoxGraficadorRegistro.Text);
            EnviarCambiosInventarioBaseDatos();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Fill_spaces();
        }

        private void buttonDataBase_Click(object sender, EventArgs e)
        {
            //ventanaDB.Show(); en desuso
            formHome.form_SAI.Show();
        }

        private void labelIndicadorNombreUsuario_Click(object sender, EventArgs e)
        {
            actualizrUserInfo();
        }

        public void actualizrUserInfo()
        {
            labelIndicadorNombreUsuario.Text = Usuario.name + "; " + Usuario.rol;
        }

        private async void pictureBoxConsola_Click(object sender, EventArgs e)
        {
            ventanaConsola.Show();
            Color ultimo_color_fondo = pictureBoxConsola.BackColor;
            pictureBoxConsola.BorderStyle = BorderStyle.FixedSingle;

            pictureBoxConsola.BackColor = Color.LightGray;
            await Task.Delay(100);
            pictureBoxConsola.BackColor = ultimo_color_fondo;
            pictureBoxConsola.BorderStyle = BorderStyle.Fixed3D;
        }

        private async void pictureBoxConf_Click(object sender, EventArgs e)
        {
            ventanaConfiguraciones.Show();
            Color ultimo_color_fondo = pictureBoxConf.BackColor;
            pictureBoxConf.BorderStyle = BorderStyle.FixedSingle;

            pictureBoxConf.BackColor = Color.LightGray;
            await Task.Delay(100);
            pictureBoxConf.BackColor = ultimo_color_fondo;
            pictureBoxConf.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Form_SRV_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}



