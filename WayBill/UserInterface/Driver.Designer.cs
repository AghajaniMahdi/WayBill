namespace WayBill.UserInterface
{
    partial class Driver
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch3 = new System.Windows.Forms.TextBox();
            this.comboBoxSearchType3 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.Driver_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_CellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_LicenseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_SmartCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_PlateNumber = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSourceData = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Goldenrod;
            this.flowLayoutPanel1.Controls.Add(this.labelSearch);
            this.flowLayoutPanel1.Controls.Add(this.textBoxSearch3);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxSearchType3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1099, 44);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // labelSearch
            // 
            this.labelSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(1029, 12);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(10, 12, 8, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(60, 27);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "جستجو";
            // 
            // textBoxSearch3
            // 
            this.textBoxSearch3.Location = new System.Drawing.Point(185, 12);
            this.textBoxSearch3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.textBoxSearch3.Name = "textBoxSearch3";
            this.textBoxSearch3.Size = new System.Drawing.Size(833, 22);
            this.textBoxSearch3.TabIndex = 0;
            this.textBoxSearch3.TextChanged += new System.EventHandler(this.textBoxSearch2_TextChanged);
            // 
            // comboBoxSearchType3
            // 
            this.comboBoxSearchType3.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxSearchType3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchType3.FormattingEnabled = true;
            this.comboBoxSearchType3.Items.AddRange(new object[] {
            "کد شتراک",
            "نام و نام خانوادگی",
            "کدملی",
            "شماره گواهینامه",
            "شماره کارت هوشمند"});
            this.comboBoxSearchType3.Location = new System.Drawing.Point(13, 12);
            this.comboBoxSearchType3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.comboBoxSearchType3.Name = "comboBoxSearchType3";
            this.comboBoxSearchType3.Size = new System.Drawing.Size(166, 26);
            this.comboBoxSearchType3.TabIndex = 3;
            this.comboBoxSearchType3.Text = "جستجو بر اساس";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Goldenrod;
            this.flowLayoutPanel2.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel2.Controls.Add(this.buttonEdit);
            this.flowLayoutPanel2.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 439);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1099, 44);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(8, 7);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(8, 7, 3, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 31);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(89, 7);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 31);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "ویرایش";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(170, 7);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 31);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "افزودن";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.AutoGenerateColumns = false;
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Driver_ID,
            this.Driver_FirstName,
            this.Driver_LastName,
            this.Driver_CellPhone,
            this.Driver_NationalCode,
            this.Driver_LicenseNumber,
            this.Driver_SmartCardNumber,
            this.Driver_PlateNumber});
            this.dataGridViewData.DataSource = this.bindingSourceData;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(1099, 395);
            this.dataGridViewData.TabIndex = 5;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            // 
            // Driver_ID
            // 
            this.Driver_ID.DataPropertyName = "Driver_ID";
            this.Driver_ID.HeaderText = "کد اشتراک";
            this.Driver_ID.MinimumWidth = 6;
            this.Driver_ID.Name = "Driver_ID";
            this.Driver_ID.ReadOnly = true;
            this.Driver_ID.Width = 90;
            // 
            // Driver_FirstName
            // 
            this.Driver_FirstName.DataPropertyName = "Driver_FirstName";
            this.Driver_FirstName.HeaderText = "نام";
            this.Driver_FirstName.MinimumWidth = 6;
            this.Driver_FirstName.Name = "Driver_FirstName";
            this.Driver_FirstName.ReadOnly = true;
            this.Driver_FirstName.Width = 110;
            // 
            // Driver_LastName
            // 
            this.Driver_LastName.DataPropertyName = "Driver_LastName";
            this.Driver_LastName.HeaderText = "نام خانوادگی";
            this.Driver_LastName.MinimumWidth = 6;
            this.Driver_LastName.Name = "Driver_LastName";
            this.Driver_LastName.ReadOnly = true;
            this.Driver_LastName.Width = 130;
            // 
            // Driver_CellPhone
            // 
            this.Driver_CellPhone.DataPropertyName = "Driver_CellPhone";
            this.Driver_CellPhone.HeaderText = "تلفن همراه";
            this.Driver_CellPhone.MinimumWidth = 6;
            this.Driver_CellPhone.Name = "Driver_CellPhone";
            this.Driver_CellPhone.ReadOnly = true;
            this.Driver_CellPhone.Width = 125;
            // 
            // Driver_NationalCode
            // 
            this.Driver_NationalCode.DataPropertyName = "Driver_NationalCode";
            this.Driver_NationalCode.HeaderText = "کد ملی";
            this.Driver_NationalCode.MinimumWidth = 6;
            this.Driver_NationalCode.Name = "Driver_NationalCode";
            this.Driver_NationalCode.ReadOnly = true;
            this.Driver_NationalCode.Width = 125;
            // 
            // Driver_LicenseNumber
            // 
            this.Driver_LicenseNumber.DataPropertyName = "Driver_LicenseNumber";
            this.Driver_LicenseNumber.HeaderText = "شماره گواهینامه";
            this.Driver_LicenseNumber.MinimumWidth = 6;
            this.Driver_LicenseNumber.Name = "Driver_LicenseNumber";
            this.Driver_LicenseNumber.ReadOnly = true;
            this.Driver_LicenseNumber.Width = 125;
            // 
            // Driver_SmartCardNumber
            // 
            this.Driver_SmartCardNumber.DataPropertyName = "Driver_SmartCardNumber";
            this.Driver_SmartCardNumber.HeaderText = "شماره کارت هوشمند";
            this.Driver_SmartCardNumber.MinimumWidth = 6;
            this.Driver_SmartCardNumber.Name = "Driver_SmartCardNumber";
            this.Driver_SmartCardNumber.ReadOnly = true;
            this.Driver_SmartCardNumber.Width = 135;
            // 
            // Driver_PlateNumber
            // 
            this.Driver_PlateNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Driver_PlateNumber.DataPropertyName = "Driver_PlateNumber";
            this.Driver_PlateNumber.HeaderText = "شماره پلاک";
            this.Driver_PlateNumber.MinimumWidth = 6;
            this.Driver_PlateNumber.Name = "Driver_PlateNumber";
            this.Driver_PlateNumber.ReadOnly = true;
            this.Driver_PlateNumber.Text = "مشاهدی شماره پلاک";
            this.Driver_PlateNumber.UseColumnTextForButtonValue = true;
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 483);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "Driver";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "رانندگان";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch3;
        internal System.Windows.Forms.ComboBox comboBoxSearchType3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.BindingSource bindingSourceData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_CellPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_LicenseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_SmartCardNumber;
        private System.Windows.Forms.DataGridViewButtonColumn Driver_PlateNumber;
    }
}