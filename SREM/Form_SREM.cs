using Newtonsoft.Json.Linq;
using SALAM.SREM;
using SALAM.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALAM
{
    public partial class Form_SREM : Form
    {
        private FileSystemWatcher watcher;
        Form_home formHome;
        Form_SREM_OP_add formSREMOpAdd;
        public string ruta_registros_SREM;
        string schema_type = "json"; // Tipo de esquema para el registro SREM (puede ser "text" o "json")


        // Ruta del proyecto (sube dos niveles desde bin)
        public static string ProjectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

        public Form_SREM(Form_home parent)
        {
            InitializeComponent();
            InicializarListaArchivos();
            this.formHome = parent;
            ActualizarListaArchivos("ascendent");
        }

        private void InicializarListaArchivos()
        {
            ruta_registros_SREM = Path.Combine(ProjectPath, "registro_SREM");
            if (!Directory.Exists(ruta_registros_SREM))
                Directory.CreateDirectory(ruta_registros_SREM);

            watcher = new FileSystemWatcher(ruta_registros_SREM);
            watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;
            watcher.Filter = "*.*";
            watcher.Created += (s, e) => ActualizarListaArchivos();
            watcher.Deleted += (s, e) => ActualizarListaArchivos();
            watcher.Renamed += (s, e) => ActualizarListaArchivos();
            watcher.EnableRaisingEvents = true;

            ActualizarListaArchivos();
        }

        private void ActualizarListaArchivos(string filter = "")
        {
            if (listBox_itemsRecord.InvokeRequired)
            {
                listBox_itemsRecord.Invoke(new Action(() => ActualizarListaArchivos(filter)));
                return;
            }

            string carpeta = Path.Combine(ProjectPath, "registro_SREM");

            listBox_itemsRecord.Items.Clear();
            listBox_itemsRecord.FilePaths.Clear();

            var archivos = Directory.GetFiles(carpeta);

            // Diccionario para convertir nombre de mes a número
            var meses = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                { "enero", 1 }, { "febrero", 2 }, { "marzo", 3 }, { "abril", 4 },
                { "mayo", 5 }, { "junio", 6 }, { "julio", 7 }, { "agosto", 8 },
                { "septiembre", 9 }, { "octubre", 10 }, { "noviembre", 11 }, { "diciembre", 12 }
            };

            Func<string, (int year, int mes)> extraerFecha = archivo =>
            {
                string nombreArchivo = Path.GetFileNameWithoutExtension(archivo);
                // Buscar el último grupo de 4 dígitos como año
                int year = 0;
                int mes = 0;
                foreach (var mesNombre in meses.Keys)
                {
                    if (nombreArchivo.StartsWith(mesNombre, StringComparison.OrdinalIgnoreCase))
                    {
                        mes = meses[mesNombre];
                        string posibleAnio = nombreArchivo.Substring(mesNombre.Length);
                        int.TryParse(posibleAnio, out year);
                        break;
                    }
                }
                return (year, mes);
            };

            if (filter == "ascendent")
            {
                archivos = archivos
                    .OrderBy(a => extraerFecha(a).year)
                    .ThenBy(a => extraerFecha(a).mes)
                    .ToArray();
            }
            else if (filter == "descendent")
            {
                archivos = archivos
                    .OrderByDescending(a => extraerFecha(a).year)
                    .ThenByDescending(a => extraerFecha(a).mes)
                    .ToArray();
            }

            foreach (var archivo in archivos)
            {
                listBox_itemsRecord.Items.Add(Path.GetFileName(archivo));
                listBox_itemsRecord.FilePaths.Add(archivo);
            }
        }

        public void fileListBoxArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_itemsRecord.SelectedItem != null)
            {
                int indexArchivoSeleccionado = listBox_itemsRecord.SelectedIndex;
                string rutaArchivo = listBox_itemsRecord.FilePaths[indexArchivoSeleccionado];
                try
                {
                    string contenido = File.ReadAllText(rutaArchivo, Encoding.UTF8);
                    if (schema_type == "text")
                    {
                        transform_json_to_text(rutaArchivo);
                    }
                    else
                    {
                        if (contenido.Trim() == "")
                        {
                            textBox_fileContent.Text = "No hay registros.";
                            return;
                        }
                        textBox_fileContent.Text = contenido;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void transform_json_to_text(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo) || new FileInfo(rutaArchivo).Length == 0)
            {
                textBox_fileContent.Text = "No hay registros.";
                return;
            }

            try
            {
                string json_ctx = File.ReadAllText(rutaArchivo, Encoding.UTF8);
                JArray registros = JArray.Parse(json_ctx);

                StringBuilder sb = new StringBuilder();

                foreach (var registro in registros)
                {
                    // objeto padre
                    var item = registro["ITEM"];

                    // objeto DATA, header
                    var fecha = item?["DATA"]?["fecha"]?.ToString() ?? "Sin fecha";
                    sb.AppendLine($"FECHA: {fecha}");
                    sb.AppendLine(new string('-', 28));
                    sb.AppendLine("ITEMS:");

                    // objeto ITEMS, body
                    var items = item?["ITEMS"] as JArray;
                    if (items != null)
                    {
                        foreach (var it in items)
                        {
                            string nombre = it["nombre"]?.ToString() ?? "";
                            string costo = it["costo"]?.ToString() ?? "";
                            string cantidad = it["cantidad"]?.ToString() ?? "";
                            string proveedor = it["proveedor"]?.ToString() ?? "";
                            string descripcion = it["descripcion"]?.ToString() ?? "";

                            sb.AppendLine($"{nombre}, {costo}, {cantidad}, {proveedor}, {descripcion}");
                        }
                    }

                    sb.AppendLine(new string('-', 46));
                }

                textBox_fileContent.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                textBox_fileContent.Text = "Error al procesar el archivo: " + ex.Message;
            }
        }

        private void Form_SREM_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button_addRecord_Click(object sender, EventArgs e)
        {
            formSREMOpAdd = new Form_SREM_OP_add(this);
            formSREMOpAdd.Show();
        }

        private void button_alternate_schema_Click(object sender, EventArgs e)
        {
            if (schema_type == "json")
            {
                schema_type = "text";
                button_alternate_schema.Text = "Cambiar a JSON";
                textBox_fileContent.Clear();
            }
            else
            {
                schema_type = "json";
                button_alternate_schema.Text = "Cambiar a Texto";
                textBox_fileContent.Clear();
            }
            fileListBoxArchivos_SelectedIndexChanged("", new EventArgs());
        }

        private void label_filter_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_filters_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_filters.SelectedItem != null)
            {
                string selectedFilter = comboBox_filters.SelectedItem.ToString();
                if (selectedFilter == "ascendente")
                {
                    ActualizarListaArchivos("ascendent");
                }
                else if (selectedFilter == "descendente")
                {
                    // Implementar lógica para orden descendente si es necesario
                    ActualizarListaArchivos("descendent");
                }
                else
                {
                    ActualizarListaArchivos();
                }
            }
            else
            {
                ActualizarListaArchivos();
            }
        }

        private void comboBox_filters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // Abrir el archivo seleccionado a una nueva ventana Form_SREM_OP_edit.cs; TAREA A FUTURO
        // Usado para revertir cambios, al editar el registro tambien refleja el cambio en la base de datos inventory.db
        private void button_edit_Click(object sender, EventArgs e)
        {

        }

        // Implementar una ventana de exportacion Form_SREM_OP_export.cs de los registros SREM a un archivo JSON o TXT; TAREA A FUTURO
        // debe permitir seleccionar cuales registros exportar, permitir seleccionar el formato de exportacion (JSON o TXT) y la ruta de exportacion
        // en caso de ser texto, permitir exportar en un archivo unico que en el header contenga las fechas de los registros que contiene
        // en caso de ser JSON, exportar cada registro como un objeto JSON independiente en un array, o tambien permitiri exportarlo en un archivo en conjunto por orden de fecha
        private void button_export_Click(object sender, EventArgs e)
        {

        }
    }
}
