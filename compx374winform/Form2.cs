using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compx374winform
{
    public partial class Form2 : Form
    {
        Form1 mainForm;
        public Form2(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            textBoxStorageAccString.Text = Properties.Settings.Default["storageAccString"].ToString();
            textBoxSubKey.Text = Properties.Settings.Default["subscriptionKey"].ToString();
            textBoxRecogniserEndpoint.Text = Properties.Settings.Default["recogniserEndpoint"].ToString();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["storageAccString"] = textBoxStorageAccString.Text;
            Properties.Settings.Default["subscriptionKey"] = textBoxSubKey.Text;
            Properties.Settings.Default["recogniserEndpoint"] = textBoxRecogniserEndpoint.Text;
            Properties.Settings.Default.Save();
            mainForm.loadSettings();
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.apiKeysForm = null;
        }
    }
}
