using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALAM.SRV
{
    public partial class Form_settings : Form
    {
        readonly private Form_SRV MainForm;
        private string last_records_path;
        private string last_option_records_path;

        public Form_settings(Form_SRV Parent)
        {
            InitializeComponent();
            MainForm = Parent;
            this.VisibleChanged += Form_settings_VisibleChanged;

        }
        private void Form_settings_Load(object sender, EventArgs e) { }

        private void Form_settings_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form_settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
