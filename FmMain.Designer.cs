namespace CodeGenerator
{
    partial class FmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.cbTablesName = new System.Windows.Forms.ComboBox();
            this.chbIsExist = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSingleTableName = new System.Windows.Forms.TextBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.chbDelete = new System.Windows.Forms.CheckBox();
            this.chbGetAll = new System.Windows.Forms.CheckBox();
            this.chbAddUpdate = new System.Windows.Forms.CheckBox();
            this.chbFind = new System.Windows.Forms.CheckBox();
            this.rtbDataAccess = new System.Windows.Forms.RichTextBox();
            this.rtbBusiness = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCopyDataAccessLayerCode = new System.Windows.Forms.Button();
            this.btnCopyBusinessLayerCode = new System.Windows.Forms.Button();
            this.rbDynamicSQL = new System.Windows.Forms.RadioButton();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbSP = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbCreateSPInDB = new System.Windows.Forms.GroupBox();
            this.rbDoNotCreateSPInDB = new System.Windows.Forms.RadioButton();
            this.rbCreateSPInDB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbCreateSPInDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table Name :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(403, 292);
            this.dataGridView1.TabIndex = 4;
            // 
            // cbDatabases
            // 
            this.cbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(189, 19);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(121, 21);
            this.cbDatabases.Sorted = true;
            this.cbDatabases.TabIndex = 5;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.cbDatabases_SelectedIndexChanged);
            this.cbDatabases.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateComboBoxes);
            // 
            // cbTablesName
            // 
            this.cbTablesName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTablesName.FormattingEnabled = true;
            this.cbTablesName.Location = new System.Drawing.Point(166, 64);
            this.cbTablesName.Name = "cbTablesName";
            this.cbTablesName.Size = new System.Drawing.Size(121, 21);
            this.cbTablesName.Sorted = true;
            this.cbTablesName.TabIndex = 6;
            this.cbTablesName.SelectedIndexChanged += new System.EventHandler(this.cbTablesName_SelectedIndexChanged);
            this.cbTablesName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateComboBoxes);
            // 
            // chbIsExist
            // 
            this.chbIsExist.AutoSize = true;
            this.chbIsExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIsExist.Location = new System.Drawing.Point(19, 441);
            this.chbIsExist.Name = "chbIsExist";
            this.chbIsExist.Size = new System.Drawing.Size(75, 24);
            this.chbIsExist.TabIndex = 9;
            this.chbIsExist.Text = "IsExist";
            this.chbIsExist.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Single Table Name :";
            // 
            // tbSingleTableName
            // 
            this.tbSingleTableName.Location = new System.Drawing.Point(218, 106);
            this.tbSingleTableName.Name = "tbSingleTableName";
            this.tbSingleTableName.Size = new System.Drawing.Size(137, 20);
            this.tbSingleTableName.TabIndex = 11;
            this.tbSingleTableName.Validating += new System.ComponentModel.CancelEventHandler(this.tbSingleTableName_Validating);
            // 
            // btGenerate
            // 
            this.btGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerate.Location = new System.Drawing.Point(699, 619);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(369, 58);
            this.btGenerate.TabIndex = 12;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // chbDelete
            // 
            this.chbDelete.AutoSize = true;
            this.chbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDelete.Location = new System.Drawing.Point(303, 441);
            this.chbDelete.Name = "chbDelete";
            this.chbDelete.Size = new System.Drawing.Size(75, 24);
            this.chbDelete.TabIndex = 13;
            this.chbDelete.Text = "Delete";
            this.chbDelete.UseVisualStyleBackColor = true;
            // 
            // chbGetAll
            // 
            this.chbGetAll.AutoSize = true;
            this.chbGetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGetAll.Location = new System.Drawing.Point(157, 464);
            this.chbGetAll.Name = "chbGetAll";
            this.chbGetAll.Size = new System.Drawing.Size(72, 24);
            this.chbGetAll.TabIndex = 14;
            this.chbGetAll.Text = "GetAll";
            this.chbGetAll.UseVisualStyleBackColor = true;
            // 
            // chbAddUpdate
            // 
            this.chbAddUpdate.AutoSize = true;
            this.chbAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAddUpdate.Location = new System.Drawing.Point(303, 486);
            this.chbAddUpdate.Name = "chbAddUpdate";
            this.chbAddUpdate.Size = new System.Drawing.Size(114, 24);
            this.chbAddUpdate.TabIndex = 15;
            this.chbAddUpdate.Text = "Add,Update";
            this.chbAddUpdate.UseVisualStyleBackColor = true;
            // 
            // chbFind
            // 
            this.chbFind.AutoSize = true;
            this.chbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFind.Location = new System.Drawing.Point(19, 486);
            this.chbFind.Name = "chbFind";
            this.chbFind.Size = new System.Drawing.Size(59, 24);
            this.chbFind.TabIndex = 16;
            this.chbFind.Text = "Find";
            this.chbFind.UseVisualStyleBackColor = true;
            // 
            // rtbDataAccess
            // 
            this.rtbDataAccess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbDataAccess.Location = new System.Drawing.Point(457, 138);
            this.rtbDataAccess.Name = "rtbDataAccess";
            this.rtbDataAccess.ReadOnly = true;
            this.rtbDataAccess.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbDataAccess.Size = new System.Drawing.Size(440, 385);
            this.rtbDataAccess.TabIndex = 17;
            this.rtbDataAccess.Text = "";
            // 
            // rtbBusiness
            // 
            this.rtbBusiness.Location = new System.Drawing.Point(906, 138);
            this.rtbBusiness.Name = "rtbBusiness";
            this.rtbBusiness.ReadOnly = true;
            this.rtbBusiness.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbBusiness.Size = new System.Drawing.Size(440, 385);
            this.rtbBusiness.TabIndex = 18;
            this.rtbBusiness.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data Access Layer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(901, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Business Layer :";
            // 
            // btnCopyDataAccessLayerCode
            // 
            this.btnCopyDataAccessLayerCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyDataAccessLayerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyDataAccessLayerCode.Location = new System.Drawing.Point(455, 546);
            this.btnCopyDataAccessLayerCode.Name = "btnCopyDataAccessLayerCode";
            this.btnCopyDataAccessLayerCode.Size = new System.Drawing.Size(422, 37);
            this.btnCopyDataAccessLayerCode.TabIndex = 21;
            this.btnCopyDataAccessLayerCode.Text = "Copy";
            this.btnCopyDataAccessLayerCode.UseVisualStyleBackColor = true;
            this.btnCopyDataAccessLayerCode.Click += new System.EventHandler(this.btnCopyDataAccessLayerCode_Click);
            // 
            // btnCopyBusinessLayerCode
            // 
            this.btnCopyBusinessLayerCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyBusinessLayerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyBusinessLayerCode.Location = new System.Drawing.Point(904, 546);
            this.btnCopyBusinessLayerCode.Name = "btnCopyBusinessLayerCode";
            this.btnCopyBusinessLayerCode.Size = new System.Drawing.Size(422, 37);
            this.btnCopyBusinessLayerCode.TabIndex = 22;
            this.btnCopyBusinessLayerCode.Text = "Copy";
            this.btnCopyBusinessLayerCode.UseVisualStyleBackColor = true;
            this.btnCopyBusinessLayerCode.Click += new System.EventHandler(this.btnCopyBusinessLayerCode_Click);
            // 
            // rbDynamicSQL
            // 
            this.rbDynamicSQL.AutoSize = true;
            this.rbDynamicSQL.Location = new System.Drawing.Point(21, 44);
            this.rbDynamicSQL.Name = "rbDynamicSQL";
            this.rbDynamicSQL.Size = new System.Drawing.Size(120, 24);
            this.rbDynamicSQL.TabIndex = 23;
            this.rbDynamicSQL.TabStop = true;
            this.rbDynamicSQL.Text = "DynamicSQL";
            this.rbDynamicSQL.UseVisualStyleBackColor = true;
            this.rbDynamicSQL.CheckedChanged += new System.EventHandler(this.rbDynamicSQL_CheckedChanged);
            // 
            // gbType
            // 
            this.gbType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbType.Controls.Add(this.rbSP);
            this.gbType.Controls.Add(this.rbDynamicSQL);
            this.gbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbType.Location = new System.Drawing.Point(12, 522);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(403, 100);
            this.gbType.TabIndex = 24;
            this.gbType.TabStop = false;
            this.gbType.Text = "Code Type";
            // 
            // rbSP
            // 
            this.rbSP.AutoSize = true;
            this.rbSP.Location = new System.Drawing.Point(223, 44);
            this.rbSP.Name = "rbSP";
            this.rbSP.Size = new System.Drawing.Size(152, 24);
            this.rbSP.TabIndex = 24;
            this.rbSP.TabStop = true;
            this.rbSP.Text = "Stored Procedure";
            this.rbSP.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbCreateSPInDB
            // 
            this.gbCreateSPInDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbCreateSPInDB.Controls.Add(this.rbDoNotCreateSPInDB);
            this.gbCreateSPInDB.Controls.Add(this.rbCreateSPInDB);
            this.gbCreateSPInDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCreateSPInDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCreateSPInDB.Location = new System.Drawing.Point(12, 638);
            this.gbCreateSPInDB.Name = "gbCreateSPInDB";
            this.gbCreateSPInDB.Size = new System.Drawing.Size(403, 54);
            this.gbCreateSPInDB.TabIndex = 25;
            this.gbCreateSPInDB.TabStop = false;
            this.gbCreateSPInDB.Text = "Create SP in the DB";
            // 
            // rbDoNotCreateSPInDB
            // 
            this.rbDoNotCreateSPInDB.AutoSize = true;
            this.rbDoNotCreateSPInDB.Location = new System.Drawing.Point(220, 25);
            this.rbDoNotCreateSPInDB.Name = "rbDoNotCreateSPInDB";
            this.rbDoNotCreateSPInDB.Size = new System.Drawing.Size(47, 24);
            this.rbDoNotCreateSPInDB.TabIndex = 26;
            this.rbDoNotCreateSPInDB.TabStop = true;
            this.rbDoNotCreateSPInDB.Text = "No";
            this.rbDoNotCreateSPInDB.UseVisualStyleBackColor = true;
            // 
            // rbCreateSPInDB
            // 
            this.rbCreateSPInDB.AutoSize = true;
            this.rbCreateSPInDB.Location = new System.Drawing.Point(18, 25);
            this.rbCreateSPInDB.Name = "rbCreateSPInDB";
            this.rbCreateSPInDB.Size = new System.Drawing.Size(55, 24);
            this.rbCreateSPInDB.TabIndex = 25;
            this.rbCreateSPInDB.TabStop = true;
            this.rbCreateSPInDB.Text = "Yes";
            this.rbCreateSPInDB.UseVisualStyleBackColor = true;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.gbCreateSPInDB);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.btnCopyBusinessLayerCode);
            this.Controls.Add(this.btnCopyDataAccessLayerCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbBusiness);
            this.Controls.Add(this.rtbDataAccess);
            this.Controls.Add(this.chbFind);
            this.Controls.Add(this.chbAddUpdate);
            this.Controls.Add(this.chbGetAll);
            this.Controls.Add(this.chbDelete);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.tbSingleTableName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbIsExist);
            this.Controls.Add(this.cbTablesName);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbCreateSPInDB.ResumeLayout(false);
            this.gbCreateSPInDB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.ComboBox cbTablesName;
        private System.Windows.Forms.CheckBox chbIsExist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSingleTableName;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.CheckBox chbDelete;
        private System.Windows.Forms.CheckBox chbGetAll;
        private System.Windows.Forms.CheckBox chbAddUpdate;
        private System.Windows.Forms.CheckBox chbFind;
        private System.Windows.Forms.RichTextBox rtbDataAccess;
        private System.Windows.Forms.RichTextBox rtbBusiness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCopyDataAccessLayerCode;
        private System.Windows.Forms.Button btnCopyBusinessLayerCode;
        private System.Windows.Forms.RadioButton rbDynamicSQL;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbSP;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbCreateSPInDB;
        private System.Windows.Forms.RadioButton rbDoNotCreateSPInDB;
        private System.Windows.Forms.RadioButton rbCreateSPInDB;
    }
}

