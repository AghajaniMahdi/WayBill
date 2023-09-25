namespace WayBill.UserInterface
{
    partial class Sender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sender));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewDataSender = new System.Windows.Forms.DataGridView();
            this.Sender_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender_NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender_CellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender_PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceData = new System.Windows.Forms.BindingSource(this.components);
            this.label69 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataSender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Goldenrod;
            this.flowLayoutPanel1.Controls.Add(this.labelSearch);
            this.flowLayoutPanel1.Controls.Add(this.textBoxSearch);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxSearchType);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1162, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelSearch
            // 
            this.labelSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(1092, 13);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(10, 13, 8, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(60, 30);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "جستجو";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(184, 13);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(897, 22);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxSearchType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "کد شتراک",
            "نام و نام خانوادگی",
            "کدملی",
            "کد پستی"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(12, 13);
            this.comboBoxSearchType.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(166, 26);
            this.comboBoxSearchType.TabIndex = 3;
            this.comboBoxSearchType.Text = "جستجو بر اساس";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Goldenrod;
            this.flowLayoutPanel2.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel2.Controls.Add(this.buttonEdit);
            this.flowLayoutPanel2.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 493);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1162, 50);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(8, 8);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(8, 8, 3, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 35);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(89, 8);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 35);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "ویرایش";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(170, 8);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 35);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "افزودن";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewDataSender
            // 
            this.dataGridViewDataSender.AllowUserToAddRows = false;
            this.dataGridViewDataSender.AllowUserToDeleteRows = false;
            this.dataGridViewDataSender.AutoGenerateColumns = false;
            this.dataGridViewDataSender.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDataSender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataSender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sender_ID,
            this.Sender_FirstName,
            this.Sender_LastName,
            this.Sender_NationalCode,
            this.Sender_CellPhone,
            this.Sender_Address,
            this.Sender_PostalCode});
            this.dataGridViewDataSender.DataSource = this.bindingSourceData;
            this.dataGridViewDataSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDataSender.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDataSender.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewDataSender.Name = "dataGridViewDataSender";
            this.dataGridViewDataSender.ReadOnly = true;
            this.dataGridViewDataSender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewDataSender.RowHeadersWidth = 51;
            this.dataGridViewDataSender.RowTemplate.Height = 24;
            this.dataGridViewDataSender.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDataSender.Size = new System.Drawing.Size(1162, 443);
            this.dataGridViewDataSender.TabIndex = 3;
            // 
            // Sender_ID
            // 
            this.Sender_ID.DataPropertyName = "Sender_ID";
            this.Sender_ID.HeaderText = "کد اشتراک";
            this.Sender_ID.MinimumWidth = 6;
            this.Sender_ID.Name = "Sender_ID";
            this.Sender_ID.ReadOnly = true;
            this.Sender_ID.Width = 90;
            // 
            // Sender_FirstName
            // 
            this.Sender_FirstName.DataPropertyName = "Sender_FirstName";
            this.Sender_FirstName.HeaderText = "نام";
            this.Sender_FirstName.MinimumWidth = 6;
            this.Sender_FirstName.Name = "Sender_FirstName";
            this.Sender_FirstName.ReadOnly = true;
            this.Sender_FirstName.Width = 110;
            // 
            // Sender_LastName
            // 
            this.Sender_LastName.DataPropertyName = "Sender_LastName";
            this.Sender_LastName.HeaderText = "نام خانوادگی";
            this.Sender_LastName.MinimumWidth = 6;
            this.Sender_LastName.Name = "Sender_LastName";
            this.Sender_LastName.ReadOnly = true;
            this.Sender_LastName.Width = 130;
            // 
            // Sender_NationalCode
            // 
            this.Sender_NationalCode.DataPropertyName = "Sender_NationalCode";
            this.Sender_NationalCode.HeaderText = "کد ملی";
            this.Sender_NationalCode.MinimumWidth = 6;
            this.Sender_NationalCode.Name = "Sender_NationalCode";
            this.Sender_NationalCode.ReadOnly = true;
            this.Sender_NationalCode.Width = 125;
            // 
            // Sender_CellPhone
            // 
            this.Sender_CellPhone.DataPropertyName = "Sender_CellPhone";
            this.Sender_CellPhone.HeaderText = "تلفن همراه";
            this.Sender_CellPhone.MinimumWidth = 6;
            this.Sender_CellPhone.Name = "Sender_CellPhone";
            this.Sender_CellPhone.ReadOnly = true;
            this.Sender_CellPhone.Width = 125;
            // 
            // Sender_Address
            // 
            this.Sender_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sender_Address.DataPropertyName = "Sender_Address";
            this.Sender_Address.HeaderText = "آدرس";
            this.Sender_Address.MinimumWidth = 6;
            this.Sender_Address.Name = "Sender_Address";
            this.Sender_Address.ReadOnly = true;
            // 
            // Sender_PostalCode
            // 
            this.Sender_PostalCode.DataPropertyName = "Sender_PostalCode";
            this.Sender_PostalCode.HeaderText = "کدپستی";
            this.Sender_PostalCode.MinimumWidth = 6;
            this.Sender_PostalCode.Name = "Sender_PostalCode";
            this.Sender_PostalCode.ReadOnly = true;
            this.Sender_PostalCode.Width = 125;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(12, 451);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(44, 16);
            this.label69.TabIndex = 4;
            this.label69.Text = "label1";
            // 
            // Sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 543);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.dataGridViewDataSender);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1019, 550);
            this.Name = "Sender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرستنده";
            this.Load += new System.EventHandler(this.Sender_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataSender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        internal System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource bindingSourceData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender_NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender_CellPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender_PostalCode;
        private System.Windows.Forms.Label label69;
        public System.Windows.Forms.DataGridView dataGridViewDataSender;
    }
}