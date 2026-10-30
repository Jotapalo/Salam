using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SQLite;

namespace SALAM.SREM
{
    public partial class Form_SREM_OP_add : Form
    {
        Form_SREM formSREM;
        string nameFile;
        public Form_SREM_OP_add(Form_SREM parent)
        {
            InitializeComponent();
            formSREM = parent;
        }

        private void Check_files(object sender, EventArgs e)
        {

            if (comboBox_dateMonthSelector.Text == "" | comboBox_dateYearSelector.Text == "")
            {
                return;
            }

            nameFile = comboBox_dateMonthSelector.Text + comboBox_dateYearSelector.Text;
            List<string> listFiles = new List<string>();

            foreach (var item in formSREM.listBox_itemsRecord.Items)
            {
                string itemString = item.ToString();
                string formatedString = itemString.Substring(0, itemString.Length - 5);

                listFiles.Add(
                    formatedString
                    );
            }
            if (listFiles.Contains(nameFile))
            {
                label_infoFile.Text = "Already File: " + nameFile;
                label_infoFile.ForeColor = Color.Green;
            }
            else
            {
                label_infoFile.Text = "New File: " + nameFile;
                label_infoFile.ForeColor = Color.Orange;
            }
        }
        static string RemoveDiacritics(string text)
        {
            var normalized = text.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var c in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        private void Form_SREM_OP_add_Shown(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string month = date.ToString("MMMM", new CultureInfo("es-ES"));
            string year = date.ToString("yyyy", new CultureInfo("es-ES"));

            month = RemoveDiacritics(month);
            month = month.Replace(" ", "").ToLower();

            comboBox_dateMonthSelector.Text = month.ToString();
            comboBox_dateYearSelector.Text = year.ToString();
            Check_files(new ComboBox(), new EventArgs());
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            // Logica para validar los campos de texto
            bool isValid = true;
            foreach (TextBox casilla in new List<TextBox> { textBox_ITEM_name, textBox_ITEM_cost, textBox_ITEM_amount,
                textBox_ITEM_price })
            {
                if (casilla.Text == "")
                {
                    label_errorShow.Text = "Los campos (nombre, costo, cantidad, precio) son obligatorios.";
                    casilla.BackColor = Color.OrangeRed;
                    isValid = false;
                }
                else
                {
                    casilla.BackColor = SystemColors.Window;
                }
            }
            if (!isValid)
            {
                return;
            }
            else label_errorShow.Text = "";

            // Validar que el costo y la cantidad sean números
            try
            {
                int.Parse(textBox_ITEM_cost.Text);
                int.Parse(textBox_ITEM_amount.Text);
                int.Parse(textBox_ITEM_price.Text);
            }
            catch (FormatException)
            {
                label_errorShow.Text = "El costo, cantidad y/o precio deben ser números enteros.";
                textBox_ITEM_cost.BackColor = Color.OrangeRed;
                textBox_ITEM_amount.BackColor = Color.OrangeRed;
                textBox_ITEM_price.BackColor = Color.OrangeRed;
                return;
            }

            // Agregar item a la lista de items con los valores de los TextBox
            ListViewItem item = new ListViewItem(new[] { textBox_ITEM_name.Text.Trim(), textBox_ITEM_cost.Text.Trim(),
                textBox_ITEM_amount.Text.Trim(), textBox_ITEM_price.Text.Trim(),textBox_ITEM_provider.Text.Trim(),
                textBox_ITEM_description.Text.Trim(), textBox_ITEM_category.Text.Trim() });

            listView_items.Items.Add(item);

            // Limpiar los campos de texto
             foreach (TextBox casilla in new List<TextBox> { textBox_ITEM_name, textBox_ITEM_cost, textBox_ITEM_amount,
                textBox_ITEM_price ,textBox_ITEM_provider, textBox_ITEM_description, textBox_ITEM_category })
            {
                if (casilla == textBox_ITEM_provider && checkBox_provider.Checked ||
                    casilla == textBox_ITEM_description && checkBox_description.Checked ||
                    casilla == textBox_ITEM_category && checkBox_category.Checked)
                {
                    continue;
                }
                casilla.Text = "";
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_items.SelectedItems)
            {
                ListViewItem listItem = item;
                if (listItem != null)
                {
                    listView_items.Items.Remove(listItem);
                }
            }
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            string databasePath_inventory = PathManager.Database_inventory;

            if (listView_items.Items.Count == 0)
            {
                label_errorShow.Text = "No hay items para exportar.";
                return;
            }
            string file = Path.Combine(formSREM.ruta_registros_SREM, nameFile + ".json");
            JArray registros;
            if (File.Exists(file) && new FileInfo(file).Length > 0)
            {
                string json_ctx = File.ReadAllText(file);
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

            // crear header de registro con informacion relevante para su busqueda
            JObject dataObj = new JObject
            {
                ["fecha"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            };


            // crear body del registro con los items seleccionados
            JArray itemsArray = new JArray();
            foreach (ListViewItem item in listView_items.Items)
            {
                JObject itemObj = new JObject
                {
                    ["nombre"] = item.SubItems[0].Text,
                    ["costo"] = item.SubItems[1].Text,
                    ["cantidad"] = item.SubItems[2].Text,
                    ["proveedor"] = item.SubItems[3].Text,
                    ["descripcion"] = item.SubItems[4].Text
                };
                itemsArray.Add(itemObj);
            }


            // empaquetar el registro completo
            var itemObjFinal = new JObject
            {
                ["ITEM"] = new JObject
                {
                    ["DATA"] = dataObj,
                    ["ITEMS"] = itemsArray
                }
            };

            registros.Add(itemObjFinal);
            File.WriteAllText(file, registros.ToString(Formatting.Indented));
            formSREM.fileListBoxArchivos_SelectedIndexChanged("", new EventArgs());

            foreach (ListViewItem item in listView_items.Items)
            { 
                send_items_database(databasePath_inventory, item);
            }

            Close();
        }

        public void send_items_database(string path, ListViewItem item)
        {
            string connectionString = $"Data Source={path};Version=3;";


            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string name = item.SubItems[0].Text.Trim();
                    string cost = item.SubItems[1].Text.Trim();
                    string amount = item.SubItems[2].Text.Trim();
                    string price = item.SubItems[3].Text.Trim();
                    string provider = item.SubItems[4].Text.Trim();
                    string description = item.SubItems[5].Text.Trim();
                    string category = item.SubItems[6].Text.Trim();


                    string query = "INSERT INTO inventory (name, cost, price, provider, description, category, stock, tags)" +
                        " VALUES (@name, @cost, @price, @provider, @description, @category, @stock, @tags);";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        // Parámetros para prevenir inyecciones SQL
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@cost", double.Parse(cost) / int.Parse(amount));
                        command.Parameters.AddWithValue("@price", double.Parse(price));
                        command.Parameters.AddWithValue("@provider", provider);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@category", category);
                        command.Parameters.AddWithValue("@stock", int.Parse(amount));
                        command.Parameters.AddWithValue("@tags", "prueba");

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al leer la base de datos: " + ex.Message);
                return;
            }
        }

        private void textBox_ITEM_cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Logica para escritura rapida
            if (escrituraRapidaToolStripMenuItem.Checked && e.KeyChar == (char)Keys.Enter)
            {
                textBox_ITEM_cost.Text = (double.Parse(textBox_ITEM_cost.Text.Trim().Replace('.', ',')) * 1000).ToString();
                textBox_ITEM_amount.Focus();
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == '.') { e.Handled = false; return; }
                e.Handled = true;
            }
        }

        private void textBox_ITEM_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox_ITEM_price.Focus(); return;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_ITEM_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Logica para escritura rapida
            if (escrituraRapidaToolStripMenuItem.Checked && e.KeyChar == (char)Keys.Enter)
            {
                textBox_ITEM_price.Text = (double.Parse(textBox_ITEM_price.Text.Trim().Replace('.', ',')) * 1000).ToString();
                textBox_ITEM_provider.Focus();
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == '.') { e.Handled = false; return; }
                e.Handled = true;
            }
        }

        private void escrituraRapidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            escrituraRapidaToolStripMenuItem.Checked = !escrituraRapidaToolStripMenuItem.Checked;
        }
    }
}
