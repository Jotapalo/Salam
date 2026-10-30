using SALAM.utils; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SALAM.SAI
{
    public partial class Form_SAI_OP_add_item : Form
    {
        Form_SAI formSAI;
        public Form_SAI_OP_add_item(Form_SAI parent)
        {
            formSAI = parent;
            InitializeComponent();
        }

        private void send_item_database()
        {
            Item_inventory item = new Item_inventory()
            {
                name = textBox_name.Text.Trim(),
                cost = double.Parse(textBox_cost.Text.Trim()),
                price = double.Parse(textBox_price.Text.Trim()),
                amount = int.Parse(textBox_amount.Text.Trim()),
                provider = textBox_provider.Text.Trim(),
                description = textBox_description.Text.Trim(),
                category = textBox_category.Text.Trim(),
                tags = textBox_tags.Text.Trim()
            };

            string connectionString = $"Data Source={PathManager.Database_inventory};Version=3;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO inventory (name, cost, price, provider, description, category, stock, tags)" +
                        " VALUES (@name, @cost, @price, @provider, @description, @category, @stock, @tags);";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        // Parámetros para prevenir inyecciones SQL
                        command.Parameters.AddWithValue("@name", item.name);
                        if (item.cost > 0) { command.Parameters.AddWithValue("@cost", item.cost / item.amount); }
                        else { command.Parameters.AddWithValue("@cost", 0); }
                        command.Parameters.AddWithValue("@price", item.price);
                        command.Parameters.AddWithValue("@provider", item.provider);
                        command.Parameters.AddWithValue("@description", item.description);
                        command.Parameters.AddWithValue("@category", item.category);
                        command.Parameters.AddWithValue("@stock", item.amount);
                        command.Parameters.AddWithValue("@tags", " ");

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            foreach (string textBoxInfo in new List<string> { textBox_name.Text, textBox_category.Text, textBox_price.Text, textBox_amount.Text})
            {
                if (string.IsNullOrWhiteSpace(textBoxInfo))
                {
                    MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            send_item_database();
            this.formSAI.form_SAI_OP_add_item = null;
            Dispose();
        }

        private void Form_SAI_OP_add_item_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.formSAI.form_SAI_OP_add_item = null;
            Dispose();
        }
    }
}
