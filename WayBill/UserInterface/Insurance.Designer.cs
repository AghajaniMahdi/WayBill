namespace WayBill.UserInterface
{
    partial class Insurance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insurance));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.Insurance_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insurance_CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insurance_InsuredName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insurance_InsuredPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insurance_InsuredAddreess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insurance_PolicyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
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
            this.flowLayoutPanel1.Controls.Add(this.textBoxSearch);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxSearchType);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelSearch
            // 
            this.labelSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(830, 13);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(10, 13, 8, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(60, 30);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "جستجو";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(161, 13);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(658, 24);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Goldenrod;
            this.flowLayoutPanel2.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel2.Controls.Add(this.buttonEdit);
            this.flowLayoutPanel2.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 456);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(900, 50);
            this.flowLayoutPanel2.TabIndex = 1;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGridViewData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewData.AutoGenerateColumns = false;
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Insurance_ID,
            this.Insurance_CompanyName,
            this.Insurance_InsuredName,
            this.Insurance_InsuredPhoneNumber,
            this.Insurance_InsuredAddreess,
            this.Insurance_PolicyNumber});
            this.dataGridViewData.DataSource = this.bindingSourceData;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(900, 406);
            this.dataGridViewData.TabIndex = 2;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            // 
            // Insurance_ID
            // 
            this.Insurance_ID.DataPropertyName = "Insurance_ID";
            this.Insurance_ID.HeaderText = "کد دسته";
            this.Insurance_ID.MinimumWidth = 6;
            this.Insurance_ID.Name = "Insurance_ID";
            this.Insurance_ID.ReadOnly = true;
            this.Insurance_ID.Width = 90;
            // 
            // Insurance_CompanyName
            // 
            this.Insurance_CompanyName.DataPropertyName = "Insurance_CompanyName";
            this.Insurance_CompanyName.HeaderText = "نام شرکت";
            this.Insurance_CompanyName.MinimumWidth = 6;
            this.Insurance_CompanyName.Name = "Insurance_CompanyName";
            this.Insurance_CompanyName.ReadOnly = true;
            this.Insurance_CompanyName.Width = 125;
            // 
            // Insurance_InsuredName
            // 
            this.Insurance_InsuredName.DataPropertyName = "Insurance_InsuredName";
            this.Insurance_InsuredName.HeaderText = "نام بیمه گذار";
            this.Insurance_InsuredName.MinimumWidth = 6;
            this.Insurance_InsuredName.Name = "Insurance_InsuredName";
            this.Insurance_InsuredName.ReadOnly = true;
            this.Insurance_InsuredName.Width = 135;
            // 
            // Insurance_InsuredPhoneNumber
            // 
            this.Insurance_InsuredPhoneNumber.DataPropertyName = "Insurance_InsuredPhoneNumber";
            this.Insurance_InsuredPhoneNumber.HeaderText = "تلفن بیمه گذار";
            this.Insurance_InsuredPhoneNumber.MinimumWidth = 6;
            this.Insurance_InsuredPhoneNumber.Name = "Insurance_InsuredPhoneNumber";
            this.Insurance_InsuredPhoneNumber.ReadOnly = true;
            this.Insurance_InsuredPhoneNumber.Width = 125;
            // 
            // Insurance_InsuredAddreess
            // 
            this.Insurance_InsuredAddreess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Insurance_InsuredAddreess.DataPropertyName = "Insurance_InsuredAddreess";
            this.Insurance_InsuredAddreess.HeaderText = "آدرس بیمه گذار";
            this.Insurance_InsuredAddreess.MinimumWidth = 6;
            this.Insurance_InsuredAddreess.Name = "Insurance_InsuredAddreess";
            this.Insurance_InsuredAddreess.ReadOnly = true;
            // 
            // Insurance_PolicyNumber
            // 
            this.Insurance_PolicyNumber.DataPropertyName = "Insurance_PolicyNumber";
            this.Insurance_PolicyNumber.HeaderText = "شماره قرارداد";
            this.Insurance_PolicyNumber.MinimumWidth = 6;
            this.Insurance_PolicyNumber.Name = "Insurance_PolicyNumber";
            this.Insurance_PolicyNumber.ReadOnly = true;
            this.Insurance_PolicyNumber.Width = 120;
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxSearchType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "شماره قرارداد بیمه نامه",
            "نام شرکت",
            "نام بیمه گذار"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(12, 13);
            this.comboBoxSearchType.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(143, 26);
            this.comboBoxSearchType.TabIndex = 3;
            this.comboBoxSearchType.Text = "جستجو بر اساس";
            // 
            // Insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Insurance";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "بیمه";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.BindingSource bindingSourceData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insurance_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insurance_CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insurance_InsuredName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insurance_InsuredPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insurance_InsuredAddreess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insurance_PolicyNumber;
        internal System.Windows.Forms.ComboBox comboBoxSearchType;
    }
}