using SALAM.SRV;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALAM
{
    public partial class Form_login : Form
    {
        public Form_home form_home;
        public Form_login()
        {
            InitializeComponent();
            form_home = new Form_home();

            // codigo para automatizar el inicio de sesion, SOLO PRUEBAS
            textBox_userName.Text = "jp";
            textBox_userPassword.Text = "123";
            Load += async (s, e) =>
            {
                await Task.Delay(100);
                Login();
            };
        }

        private void Form_login_Resize(object sender, EventArgs e)
        {
            groupBox_userName.Left = (this.ClientSize.Width - groupBox_userName.Width) / 2;
            groupBox_userPassword.Left = (this.ClientSize.Width - groupBox_userPassword.Width) / 2;
            pictureBox_imageProgram.Left = (this.ClientSize.Width - pictureBox_imageProgram.Width) / 2;
            button_login.Left = (this.ClientSize.Width - button_login.Width) / 2;
        }

        public void Login()
        {
            string userName = textBox_userName.Text.Trim();
            string userPassword = textBox_userPassword.Text.Trim();


            database_utils Util_database = new database_utils();
            List<List<object>> data = Util_database.ReadDataInDataBase("users", PathManager.Database_users, "name", userName);

            if (data.Count == 0)
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (data[0][2].ToString() != userPassword)
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            form_home.Show();
            //Debug.WriteLine("Data: " + data[0][1]);
            Usuario.SetName(userName);
            Hide();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
