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

namespace CodeGenerator
{
    public partial class FmConnectionStringSettings : Form
    {
        public FmConnectionStringSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbIsServerLocaly_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbIsServerLocaly.SelectedItem.ToString() == "Yes")
            {
                lbServerIP.Enabled = false;
                tbServerIP.Enabled = false;
            }
            else
            {
                lbServerIP.Enabled = true;
                tbServerIP.Enabled = true;
            }
        }

        private void FmConnectionStringSettings_Load(object sender, EventArgs e)
        {
            cbIsServerLocaly.SelectedIndex = 0;
        }

        private void ValidateTextBoxes(object sender,CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;

            if(string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "The value cann't be blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, null);
            }
        }

        private void tbServerIP_Validating(object sender, CancelEventArgs e)
        {
            if(cbIsServerLocaly.SelectedItem.ToString() == "No")
            {
                if (string.IsNullOrWhiteSpace(tbServerIP.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbServerIP, "The value cann't be blank");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbServerIP, null);
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbServerIP, null);
            }
        }

        public delegate void dgClear();
        public dgClear Clear;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            string ServerIP = ".";
            string NewConnectionString = "";

            if(cbIsServerLocaly.SelectedItem.ToString() == "No")
                ServerIP = tbServerIP.Text;

            NewConnectionString = "Server=" + ServerIP + ";" +
                                  "User Id=" + tbUserID.Text + ";" +
                                  "Password=" + tbPassword.Text + ";";

            using(StreamWriter streamWriter  = new StreamWriter("ConnectionSettings.txt"))
            {
                streamWriter.WriteLine(NewConnectionString);
            }

            Clear.Invoke();

            MessageBox.Show("New connection string saved Successfully", "Saved", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }
    }
}
