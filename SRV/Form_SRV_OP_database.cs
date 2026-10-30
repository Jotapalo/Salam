using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SALAM.SRV
{
    public partial class Form_SRV_OP_database : Form
    {
        readonly private Form_SRV mainForm;
        public Form_SRV_OP_database(Form_SRV formPrincipal)
        {
            InitializeComponent();
            mainForm = formPrincipal;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Shown += Form2_Shown; // Suscribe el evento
        }

        private void Form2_Shown(object sender, EventArgs e)
        { 
            Load_items();
            ConfigurarPredicciones_busqueda(textBoxSearch);
        }
        public void Load_items(List<List<object>> filter = null)
        {
            List<List<object>> DataInfo;

            if (filter != null)
            {
                DataInfo = filter;
            }
            else
            {
                DataInfo = Form_SRV.dataBaseManager.ReadDataInDataBase("Inventory");
            }
            listView1.Items.Clear();

            foreach (List<object> item in DataInfo)
            {
                ListViewItem itemAdd = new ListViewItem(new[] {
                    item[0].ToString(),
                    item[1].ToString(),
                    item[2].ToString(),
                    item[3].ToString()
                });

                listView1.Items.Add(itemAdd);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            mainForm.Show();
        }

        private void ConfigurarPredicciones_busqueda(System.Windows.Forms.TextBox textBox1)
        {
            List<string> listNameConcurrences = new List<string>();
            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
            List<List<object>> dataInfo = Form_SRV.dataBaseManager.ReadDataInDataBase("Inventory");


            foreach (var row in dataInfo)
            {
                listNameConcurrences.Add(row[3].ToString());
            }

            autoCompleteData.AddRange(listNameConcurrences.ToArray());

            // Configurar las propiedades de autocompletado
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = autoCompleteData;
        }

        private void buttonBusquedaPorCategoria_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<List<object>> dataInfo = Form_SRV.dataBaseManager.ReadDataInDataBase("Inventory", key: "identificador", value: textBoxSearch.Text);
            Load_items(dataInfo);
        }
    }
}
