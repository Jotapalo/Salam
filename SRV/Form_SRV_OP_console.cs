using System;
using System.IO;
using System.Windows.Forms;
using static SALAM.SRV.Form_SRV;
using System.Data.SQLite;
using System.Diagnostics;

namespace SALAM.SRV
{
    public partial class Form_SRV_OP_console : Form
    {
        static readonly StringWriter writer = new StringWriter();
        static readonly Timer timer = new Timer();
        private static Form_SRV mainForm;
        public static string consolePrefix = ">> ";

        public static string dbPath;
        public static string record_txtPath;
        public static string record_jsonPath;

        public Form_SRV_OP_console(Form_SRV parent)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            InitializeComponent();
            mainForm = parent;
            ConfigurarConsola();
            load_roots(); // Cargar las rutas de los archivos de configuración
        }

        public static void load_roots()
        {
            // Cargar las rutas de los archivos de registros y base de datos
            dbPath = Form_SRV.dbPath;
            record_txtPath = Form_SRV.record_txtPath;
            record_jsonPath = Form_SRV.record_jsonPath;
        }

        public class ConsoleManager
        {
            public static string ConsoleListener = "console";

            public static void Exec(TextBox textBoxConsolaInput, Form_SRV_OP_console parent, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {

                    string comando = textBoxConsolaInput.Text.Trim();

                    string simboloUsuario = "#/ ";
                    parent.richTextBoxConsola.AppendText(simboloUsuario + comando + Environment.NewLine);


                    if (!string.IsNullOrEmpty(comando))
                    {
                        if (ConsoleListener == "console")
                        {
                            EjecutarComandoConsola(comando, textBoxConsolaInput);
                        }

                        textBoxConsolaInput.Clear();
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }


            private static void EjecutarComandoConsola(string comando, TextBox textBoxConsolaInput)
            {
                if (comando.ToLower().Contains("reg_user"))
                {
                    if (comando.Split().Length < 2)
                    {
                        Console.WriteLine("Uso: reg_user <nombre_usuario>");
                        return;
                    }
                    Usuario.SetName(comando.Substring("reg_user ".Length).Trim());
                }


                else if (comando.ToLower() == "fecha")
                {
                    Console.WriteLine("La fecha actual es: " + DateTime.Now.ToString());
                }


                else if (comando.ToLower().Contains("cambiar_prefijo"))
                {
                    string[] comando_trunc = comando.Split(' ');
                    if (comando_trunc.Length < 2)
                    {
                        Console.WriteLine("Uso: cambiar_prefijo <nuevo_prefijo>");
                        return;
                    }
                    consolePrefix = comando.Substring(16).Trim();
                }

                else if (comando.ToLower().Contains("add_item"))
                {
                    if (comando.ToLower().Trim() == "add_item")
                    {
                        Console.WriteLine("Uso: add_item <nombre>, <precio>, <id>");
                        return;
                    }
                    string data = comando.Substring(8);
                    string[] comando_trunc2 = data.Split(',');

                    if (dataBaseManager.InsertDataInDataBase("Inventory", "",comando_trunc2[0].Trim(), int.Parse(comando_trunc2[1].Trim()), comando_trunc2[2].Trim()))
                    {
                        Console.WriteLine($"DATABASE >> Item: [{comando_trunc2[0].Trim()} : ${comando_trunc2[1].Trim()} : {comando_trunc2[2].Trim()}] agregado a la base de datos.");
                        mainForm.ConfigurarPredicciones_nombre();
                    }
                    else
                    {
                        Console.WriteLine("Error al agregar el item a la base de datos.");
                    }
                }

                else if (comando.ToLower() == "help")
                {
                    Console.WriteLine("Comandos disponibles:");
                    Console.WriteLine("  reg_user <nombre usuario>          - Inicia el registro de usuario.");
                    Console.WriteLine("  fecha                              - Muestra la fecha y hora actual.");
                    Console.WriteLine("  cambiar_prefijo <pref>             - Cambia el prefijo de la consola.");
                    Console.WriteLine("  add_item <nombre>, <precio>, <id>  - Agrega un nuevo ítem a la base de datos.");
                    Console.WriteLine("  help                               - Muestra este mensaje de ayuda.");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Comando no reconocido: " + comando);
                }

            }
        }
        private void richTextBoxConsola_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxConsolaInput.Focus();
            textBoxConsolaInput.Text += e.KeyChar.ToString();
            textBoxConsolaInput.SelectionStart = textBoxConsolaInput.Text.Length;
            e.Handled = true;
        }

        private void textBoxConsolaInput_KeyDown(object sender, KeyEventArgs e)
        {
            ConsoleManager.Exec(textBoxConsolaInput, this, e);
        }

        private void ConfigurarConsola()
        {
            // Redirigir la salida de la consola

            Console.SetOut(writer);
            timer.Interval = 100; // Actualizar cada 100 ms
            timer.Tick += (s, e) =>
            {
                string output = writer.ToString();
                if (!string.IsNullOrEmpty(output))
                {
                    // Añadir el prefijo a cada línea
                    string[] lineas = output.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    foreach (var linea in lineas)
                    {
                        if (!string.IsNullOrEmpty(linea))
                        {
                            richTextBoxConsola.AppendText(consolePrefix + linea + Environment.NewLine);
                            richTextBoxConsola.SelectionStart = richTextBoxConsola.Text.Length;
                            richTextBoxConsola.ScrollToCaret();
                        }
                    }
                    writer.GetStringBuilder().Clear();
                }
            };
            timer.Start();

            Console.WriteLine("Consola inicializada. Escribe help para informacion sobre los comandos.");
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            richTextBoxConsola.Clear();
            e.Cancel = true;
            Console.WriteLine("Consola inicializada. Escribe help para informacion sobre los comandos.");
        }
        
    }

    
}
