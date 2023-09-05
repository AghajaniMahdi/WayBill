namespace WayBill.UserInterface
{
    partial class Receiver
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
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.comboBoxSearchType2 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.Receiver_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver_NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver_CellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver_PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.flowLayoutPanel1.Controls.Add(this.textBoxSearch2);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxSearchType2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1162, 50);
            this.flowLayoutPanel1.TabIndex = 2;
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
            // textBoxSearch2
            // 
            this.textBoxSearch2.Location = new System.Drawing.Point(184, 13);
            this.textBoxSearch2.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(897, 22);
            this.textBoxSearch2.TabIndex = 0;
            this.textBoxSearch2.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxSearchType2
            // 
            this.comboBoxSearchType2.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxSearchType2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchType2.FormattingEnabled = true;
            this.comboBoxSearchType2.Items.AddRange(new object[] {
            "کد شتراک",
            "نام و نام خانوادگی",
            "کدملی",
            "کد پستی"});
            this.comboBoxSearchType2.Location = new System.Drawing.Point(12, 13);
            this.comboBoxSearchType2.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.comboBoxSearchType2.Name = "comboBoxSearchType2";
            this.comboBoxSearchType2.Size = new System.Drawing.Size(166, 26);
            this.comboBoxSearchType2.TabIndex = 3;
            this.comboBoxSearchType2.Text = "جستجو بر اساس";
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
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1162, 50);
            this.flowLayoutPanel2.TabIndex = 3;
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
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.AutoGenerateColumns = false;
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Receiver_ID,
            this.Receiver_FirstName,
            this.Receiver_LastName,
            this.Receiver_NationalCode,
            this.Receiver_CellPhone,
            this.Receiver_Address,
            this.Receiver_PostalCode});
            this.dataGridViewData.DataSource = this.bindingSourceData;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(1162, 443);
            this.dataGridViewData.TabIndex = 4;
            // 
            // Receiver_ID
            // 
            this.Receiver_ID.DataPropertyName = "Receiver_ID";
            this.Receiver_ID.HeaderText = "کد اشتراک";
            this.Receiver_ID.MinimumWidth = 6;
            this.Receiver_ID.Name = "Receiver_ID";
            this.Receiver_ID.ReadOnly = true;
            this.Receiver_ID.Width = 90;
            // 
            // Receiver_FirstName
            // 
            this.Receiver_FirstName.DataPropertyName = "Receiver_FirstName";
            this.Receiver_FirstName.HeaderText = "نام";
            this.Receiver_FirstName.MinimumWidth = 6;
            this.Receiver_FirstName.Name = "Receiver_FirstName";
            this.Receiver_FirstName.ReadOnly = true;
            this.Receiver_FirstName.Width = 110;
            // 
            // Receiver_LastName
            // 
            this.Receiver_LastName.DataPropertyName = "Receiver_LastName";
            this.Receiver_LastName.HeaderText = "نام خانوادگی";
            this.Receiver_LastName.MinimumWidth = 6;
            this.Receiver_LastName.Name = "Receiver_LastName";
            this.Receiver_LastName.ReadOnly = true;
            this.Receiver_LastName.Width = 130;
            // 
            // Receiver_NationalCode
            // 
            this.Receiver_NationalCode.DataPropertyName = "Receiver_NationalCode";
            this.Receiver_NationalCode.HeaderText = "کد ملی";
            this.Receiver_NationalCode.MinimumWidth = 6;
            this.Receiver_NationalCode.Name = "Receiver_NationalCode";
            this.Receiver_NationalCode.ReadOnly = true;
            this.Receiver_NationalCode.Width = 125;
            // 
            // Receiver_CellPhone
            // 
            this.Receiver_CellPhone.DataPropertyName = "Receiver_CellPhone";
            this.Receiver_CellPhone.HeaderText = "تلفن همراه";
            this.Receiver_CellPhone.MinimumWidth = 6;
            this.Receiver_CellPhone.Name = "Receiver_CellPhone";
            this.Receiver_CellPhone.ReadOnly = true;
            this.Receiver_CellPhone.Width = 125;
            // 
            // Receiver_Address
            // 
            this.Receiver_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Receiver_Address.DataPropertyName = "Receiver_Address";
            this.Receiver_Address.HeaderText = "آدرس";
            this.Receiver_Address.MinimumWidth = 6;
            this.Receiver_Address.Name = "Receiver_Address";
            this.Receiver_Address.ReadOnly = true;
            // 
            // Receiver_PostalCode
            // 
            this.Receiver_PostalCode.DataPropertyName = "Receiver_PostalCode";
            this.Receiver_PostalCode.HeaderText = "کدپستی";
            this.Receiver_PostalCode.MinimumWidth = 6;
            this.Receiver_PostalCode.Name = "Receiver_PostalCode";
            this.Receiver_PostalCode.ReadOnly = true;
            this.Receiver_PostalCode.Width = 125;
            // 
            // Receiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 543);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1180, 590);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1180, 590);
            this.Name = "Receiver";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "دریافت کننده";
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
        private System.Windows.Forms.TextBox textBoxSearch2;
        internal System.Windows.Forms.ComboBox comboBoxSearchType2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver_NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver_CellPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver_PostalCode;
        private System.Windows.Forms.BindingSource bindingSourceData;
    }
}