using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGenerator_BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CodeGenerator
{
    public partial class FmMain : Form
    {
        string ServerIP = string.Empty;
        string UserID = string.Empty;
        string Password = string.Empty;

        DataTable dtTableInfo = new DataTable();
        clsGetDBInfo getDBInfo { get; set; }
        clsCodeGenerator CodeGenerator { get; set; }
        bool IsCreateSPInDBEnabled
        {
            get
            {
                return rbSP.Checked ? rbCreateSPInDB.Checked : false;
            }
        }

        public FmMain()
        {
            InitializeComponent();
        }
        
        private void FmMain_Load(object sender, EventArgs e)
        {
            DataTable DBsName = clsGetDBInfo.GetDatabasesName();
            
            if(DBsName != null)
            foreach(DataRow row in DBsName.Rows)
            {
                cbDatabases.Items.Add(row["name"]);
            }
            
            rbDynamicSQL.Checked = true;
            rbDoNotCreateSPInDB.Checked = true;
        }

        private void cbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable TablesName = clsGetDBInfo.GetDatabaseTablesName(cbDatabases.Text);

            cbTablesName.Items.Clear();

            if(TablesName != null)   
            foreach(DataRow row in TablesName.Rows)
            {
                cbTablesName.Items.Add(row["TABLE_NAME"]);
            }
        }

        private void cbTablesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtTableInfo = clsGetDBInfo.GetTableInfo(cbDatabases.Text, cbTablesName.Text);

            if(dtTableInfo != null)
            {
                tbSingleTableName.Text = cbTablesName.Text.Substring(0,
                cbTablesName.Text.Length - 1);
                dataGridView1.DataSource = dtTableInfo;
            }
        }

        private void rbDynamicSQL_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDynamicSQL.Checked)
            {
                gbCreateSPInDB.Enabled = false;
            }
            else
            {
                gbCreateSPInDB.Enabled = true;
            }
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            rtbDataAccess.Clear();
            rtbBusiness.Clear();

            CodeGenerator = new clsCodeGenerator(cbDatabases.Text, cbTablesName.Text,
                tbSingleTableName.Text, rbDynamicSQL.Checked, IsCreateSPInDBEnabled);
            
            if(chbAddUpdate.Checked)
            {
                rtbDataAccess.Text += CodeGenerator.DataAccessLayer.GetAddNewSyntax();
                rtbDataAccess.Text += CodeGenerator.DataAccessLayer.GetUpdateSyntax();
                rtbBusiness.Text += CodeGenerator.BusinessLayer.GetAddNewUpdateSyntax();
            }
            if(chbFind.Checked)
            {
                rtbDataAccess.Text += CodeGenerator.DataAccessLayer.GetFindSyntax();
                rtbBusiness.Text += CodeGenerator.BusinessLayer.GetFindSyntax();
            }
            if(chbDelete.Checked)
            {
                rtbDataAccess.Text += CodeGenerator.DataAccessLayer.GetDeleteSyntax();
                rtbBusiness.Text += CodeGenerator.BusinessLayer.GetDeleteSyntax();
            }
            if(chbIsExist.Checked)
            {
                rtbDataAccess.Text += CodeGenerator.DataAccessLayer.GetIsExistSyntax();
                rtbBusiness.Text += CodeGenerator.BusinessLayer.GetIsExistSyntax();
            }
            if(chbGetAll.Checked)
            {
                rtbDataAccess.Text += CodeGenerator.DataAccessLayer.Get_GetAllSyntax();
                rtbBusiness.Text += CodeGenerator.BusinessLayer.Get_GetAllSyntax();
            }
        }

        private void btnCopyDataAccessLayerCode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbDataAccess.Text))
                return;

            Clipboard.SetText(rtbDataAccess.Text);

            MessageBox.Show("DataAccess layer code has been copied successfully.","Copied Successfully",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ValidateComboBoxes(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;

            if(string.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider1.SetError(comboBox, "Field shouldn't be empty");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(comboBox, null);
                e.Cancel = false;
            }
        }

        private void tbSingleTableName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSingleTableName.Text))
            {
                errorProvider1.SetError(tbSingleTableName, "Field shouldn't be empty");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbSingleTableName, null);
                e.Cancel = false;
            }
        }

        private void btnCopyBusinessLayerCode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbBusiness.Text))
                return;
            
            Clipboard.SetText(rtbBusiness.Text);

            MessageBox.Show("Business layer code has been copied successfully.", "Copied Successfully",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Clear()
        {
            cbDatabases.Items.Clear();
            cbTablesName.Items.Clear();
            tbSingleTableName.Clear();

            dataGridView1.DataSource = null;

            rtbBusiness.Text = string.Empty;
            rtbDataAccess.Text = string.Empty;

            chbAddUpdate.Checked = false;
            chbDelete.Checked = false;
            chbFind.Checked = false;
            chbGetAll.Checked = false;
            chbIsExist.Checked = false;

            rbDynamicSQL.Checked = true;

            DataTable DBsName = clsGetDBInfo.GetDatabasesName();

            if (DBsName != null)
                foreach (DataRow row in DBsName.Rows)
                {
                    cbDatabases.Items.Add(row["name"]);
                }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FmConnectionStringSettings connectionStringSettings = new FmConnectionStringSettings();
            connectionStringSettings.Clear = Clear;
            connectionStringSettings.ShowDialog();
        }
    }

}
