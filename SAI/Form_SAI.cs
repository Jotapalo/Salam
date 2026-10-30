using SALAM.SRV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALAM.SAI
{
    public partial class Form_SAI : Form
    {
        Form_home formHome;
        public Form_SAI_OP_add_item form_SAI_OP_add_item;
        private SQLiteDataAdapter adapter;
        private DataTable dataTable;
        private List<DataGridViewRow> rows_color_changed = new List<DataGridViewRow>();

        public Form_SAI(Form_home parent)
        {
            formHome = parent;
            form_SAI_OP_add_item = new Form_SAI_OP_add_item(this);
            InitializeComponent();
            CargarDatos();
        }

        private void Form_SAI_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            formHome.Show();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (rows_color_changed.Count > 0)
            {
                var result = MessageBox.Show("Hay cambios sin guardar. ¿Desea guardarlos antes de buscar?",
                    "Cambios sin guardar", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    GuardarCambios();
                }
                else if (result == DialogResult.Cancel | result == DialogResult.No)
                {
                    return;
                }
            }
            string keyword = textBox_search.Text.Trim();
            CargarDatos(keyword);
        }

        private void CargarDatos()
        {
            CargarDatos(null);
        }

        private void CargarDatos(string keyword)
        {
            string connectionString = $"Data Source={PathManager.Database_inventory};Version=3;";
            var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string query;
            SQLiteCommand command;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                query = "SELECT * FROM inventory";
                command = new SQLiteCommand(query, connection);
            }
            else
            {
                query = @"
                SELECT * FROM inventory
                WHERE name LIKE @kw
                   OR category LIKE @kw
                   OR description LIKE @kw
                   OR tags LIKE @kw;";
                command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@kw", "%" + keyword + "%");
            }

            adapter = new SQLiteDataAdapter(command);
            var builder = new SQLiteCommandBuilder(adapter);

            dataTable = new DataTable();
            adapter.Fill(dataTable);

            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.AutoGenerateColumns = false;
        }


        // Para guardar los cambios hechos en el DataGridView:
        private void GuardarCambios()
        {
            if (adapter != null && dataTable != null)
            {
                adapter.Update(dataTable);
                Debug.WriteLine("Cambios guardados en la base de datos.");
            }
            else
            {
                Debug.WriteLine("No hay cambios para guardar o el adaptador no está inicializado.");
            }

            foreach (var row in rows_color_changed)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
            rows_color_changed.Clear();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var celda = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (celda.Value == null || string.IsNullOrWhiteSpace(celda.Value.ToString())) { return; }

            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            rows_color_changed.Add(dataGridView1.Rows[e.RowIndex]);
            //Debug.WriteLine($"Edición finalizada en fila {e.RowIndex}, columna {e.ColumnIndex}: Nuevo valor = '{celda.Value}'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form_SAI_OP_add_item != null)
            {
                form_SAI_OP_add_item.Show();
            }
            else
            {
                form_SAI_OP_add_item = new Form_SAI_OP_add_item(this);
            }
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_search_Click("", new EventArgs());
                e.Handled = true;
            }
        }
    }
}
