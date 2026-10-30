using SALAM.SREM;
using SALAM.SAI;
using SALAM.SRV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SALAM
{
    public partial class Form_home : Form
    {
        Form_SREM form_SREM;
        public Form_SAI form_SAI;
        Form_SRV form_SRV;
        public Form_home()
        {
            InitializeComponent();
            form_SREM = new Form_SREM(this);
            form_SAI = new Form_SAI(this);
            form_SRV = new Form_SRV(this);
        }

        private void Form_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }

        // Actualizar los colores de los botones dependiendo de las ventanas abiertas
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            form_SAI.VisibleChanged += (s, ev) =>
            {
                button_inventoryTool.BackColor = form_SAI.Visible ? Color.LightGreen : SystemColors.Control;
            };

            form_SREM.VisibleChanged += (s, ev) =>
            {
                button_registerInputTool.BackColor = form_SREM.Visible ? Color.LightGreen : SystemColors.Control;
            };

            form_SRV.VisibleChanged += (s, ev) =>
            {
                button_registerOutputTool.BackColor = form_SREM.Visible ? Color.LightGreen : SystemColors.Control;
            };

            button_registerInputTool.BackColor = form_SREM.Visible ? Color.LightGreen : SystemColors.Control;
            button_inventoryTool.BackColor = form_SAI.Visible ? Color.LightGreen : SystemColors.Control;
        }

        private void button_registerInputTool_Click(object sender, EventArgs e)
        {
            form_SREM.Show();
            Debug.WriteLine("Register Input Tool button clicked. Form_SREM visibility: " + form_SREM.Visible);
        }

        private void button_inventoryTool_Click(object sender, EventArgs e)
        {
            form_SAI.Show();
            Debug.WriteLine("Inventory Tool button clicked. Form_SAI visibility: " + form_SAI.Visible);
        }

        private void Form_home_Load(object sender, EventArgs e)
        {
            // Obtener la ruta del archivo actual (el ejecutable)
            string currentFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            label_basePathInfo.Text = System.IO.Path.GetDirectoryName(currentFilePath);
        }

        private void button_registerOutputTool_Click(object sender, EventArgs e)
        {
            form_SRV.Show();
        }
    }
}
