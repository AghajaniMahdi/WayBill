namespace WayBill.UserInterface
{
    partial class Bill
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch4 = new System.Windows.Forms.TextBox();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.WayBill_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WayBill_SenderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderInformation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.WayBill_ReceiverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverInformation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.WayBill_DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverInformation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CargoInformation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.WayBill_Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WayBill_Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WayBill_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WayBill_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WayBill_MDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WayBill_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceData = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Goldenrod;
            this.flowLayoutPanel2.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel2.Controls.Add(this.buttonEdit);
            this.flowLayoutPanel2.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 503);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1288, 63);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(89, 10);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(7, 10, 3, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(71, 43);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "ویرایش";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(166, 10);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(71, 43);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "افزودن";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(8, 10);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(8, 10, 3, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(71, 43);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Goldenrod;
            this.flowLayoutPanel1.Controls.Add(this.labelSearch);
            this.flowLayoutPanel1.Controls.Add(this.textBoxSearch4);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxSearchType);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1288, 58);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // labelSearch
            // 
            this.labelSearch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(1208, 21);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(10, 21, 8, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(70, 30);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "جستجو";
            // 
            // textBoxSearch4
            // 
            this.textBoxSearch4.Location = new System.Drawing.Point(195, 19);
            this.textBoxSearch4.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
            this.textBoxSearch4.Name = "textBoxSearch4";
            this.textBoxSearch4.Size = new System.Drawing.Size(1002, 26);
            this.textBoxSearch4.TabIndex = 0;
            this.textBoxSearch4.TextChanged += new System.EventHandler(this.textBoxSearch3_TextChanged);
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxSearchType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "کد بارنامه",
            "کد فرستنده",
            "کد گیرنده",
            "کدراننده",
            "مبدا",
            "مقصد"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(23, 20);
            this.comboBoxSearchType.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(166, 26);
            this.comboBoxSearchType.TabIndex = 3;
            this.comboBoxSearchType.Text = "جستجو بر اساس";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.AutoGenerateColumns = false;
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WayBill_ID,
            this.WayBill_SenderID,
            this.SenderInformation,
            this.WayBill_ReceiverID,
            this.ReceiverInformation,
            this.WayBill_DriverID,
            this.DriverInformation,
            this.CargoInformation,
            this.WayBill_Origin,
            this.WayBill_Destination,
            this.WayBill_Date,
            this.WayBill_Time,
            this.WayBill_MDT,
            this.WayBill_Description});
            this.dataGridViewData.DataSource = this.bindingSourceData;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 58);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(1288, 445);
            this.dataGridViewData.TabIndex = 7;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            // 
            // WayBill_ID
            // 
            this.WayBill_ID.DataPropertyName = "WayBill_ID";
            this.WayBill_ID.HeaderText = "کد بارنامه";
            this.WayBill_ID.MinimumWidth = 6;
            this.WayBill_ID.Name = "WayBill_ID";
            this.WayBill_ID.ReadOnly = true;
            // 
            // WayBill_SenderID
            // 
            this.WayBill_SenderID.DataPropertyName = "WayBill_SenderID";
            this.WayBill_SenderID.HeaderText = "کد اشتراک فرستنده";
            this.WayBill_SenderID.MinimumWidth = 6;
            this.WayBill_SenderID.Name = "WayBill_SenderID";
            this.WayBill_SenderID.ReadOnly = true;
            this.WayBill_SenderID.Width = 140;
            // 
            // SenderInformation
            // 
            this.SenderInformation.HeaderText = "مشاهده اطلاعات فرستنده";
            this.SenderInformation.MinimumWidth = 6;
            this.SenderInformation.Name = "SenderInformation";
            this.SenderInformation.ReadOnly = true;
            this.SenderInformation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SenderInformation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SenderInformation.Text = "مشاهده";
            this.SenderInformation.ToolTipText = "مشاهده اطلاعات";
            this.SenderInformation.UseColumnTextForButtonValue = true;
            this.SenderInformation.Width = 75;
            // 
            // WayBill_ReceiverID
            // 
            this.WayBill_ReceiverID.DataPropertyName = "WayBill_ReceiverID";
            this.WayBill_ReceiverID.HeaderText = "کد اشتراک گیرنده";
            this.WayBill_ReceiverID.MinimumWidth = 6;
            this.WayBill_ReceiverID.Name = "WayBill_ReceiverID";
            this.WayBill_ReceiverID.ReadOnly = true;
            this.WayBill_ReceiverID.Width = 125;
            // 
            // ReceiverInformation
            // 
            this.ReceiverInformation.HeaderText = "مشاهده اطلاعات گیرنده";
            this.ReceiverInformation.MinimumWidth = 6;
            this.ReceiverInformation.Name = "ReceiverInformation";
            this.ReceiverInformation.ReadOnly = true;
            this.ReceiverInformation.Text = "مشاهده";
            this.ReceiverInformation.ToolTipText = "مشاهده اطلاعات";
            this.ReceiverInformation.UseColumnTextForButtonValue = true;
            this.ReceiverInformation.Width = 75;
            // 
            // WayBill_DriverID
            // 
            this.WayBill_DriverID.DataPropertyName = "WayBill_DriverID";
            this.WayBill_DriverID.HeaderText = "کد اشتراک راننده";
            this.WayBill_DriverID.MinimumWidth = 6;
            this.WayBill_DriverID.Name = "WayBill_DriverID";
            this.WayBill_DriverID.ReadOnly = true;
            this.WayBill_DriverID.Width = 125;
            // 
            // DriverInformation
            // 
            this.DriverInformation.HeaderText = "مشاهده اطلاعات راننده";
            this.DriverInformation.MinimumWidth = 6;
            this.DriverInformation.Name = "DriverInformation";
            this.DriverInformation.ReadOnly = true;
            this.DriverInformation.Text = "مشاهده";
            this.DriverInformation.ToolTipText = "مشاهده اطلاعات";
            this.DriverInformation.UseColumnTextForButtonValue = true;
            this.DriverInformation.Width = 75;
            // 
            // CargoInformation
            // 
            this.CargoInformation.HeaderText = "مشاهده اطلاعات بار";
            this.CargoInformation.MinimumWidth = 6;
            this.CargoInformation.Name = "CargoInformation";
            this.CargoInformation.ReadOnly = true;
            this.CargoInformation.Text = "مشاهده";
            this.CargoInformation.ToolTipText = "مشاهده اطلاعات";
            this.CargoInformation.UseColumnTextForButtonValue = true;
            this.CargoInformation.Width = 75;
            // 
            // WayBill_Origin
            // 
            this.WayBill_Origin.DataPropertyName = "WayBill_Origin";
            this.WayBill_Origin.HeaderText = "مبدا";
            this.WayBill_Origin.MinimumWidth = 6;
            this.WayBill_Origin.Name = "WayBill_Origin";
            this.WayBill_Origin.ReadOnly = true;
            this.WayBill_Origin.Width = 125;
            // 
            // WayBill_Destination
            // 
            this.WayBill_Destination.DataPropertyName = "WayBill_Destination";
            this.WayBill_Destination.HeaderText = "مقصد";
            this.WayBill_Destination.MinimumWidth = 6;
            this.WayBill_Destination.Name = "WayBill_Destination";
            this.WayBill_Destination.ReadOnly = true;
            this.WayBill_Destination.Width = 125;
            // 
            // WayBill_Date
            // 
            this.WayBill_Date.DataPropertyName = "WayBill_Date";
            this.WayBill_Date.HeaderText = "تاریخ بارنامه";
            this.WayBill_Date.MinimumWidth = 6;
            this.WayBill_Date.Name = "WayBill_Date";
            this.WayBill_Date.ReadOnly = true;
            this.WayBill_Date.Width = 125;
            // 
            // WayBill_Time
            // 
            this.WayBill_Time.DataPropertyName = "WayBill_Time";
            this.WayBill_Time.HeaderText = "ساعت بارنامه";
            this.WayBill_Time.MinimumWidth = 6;
            this.WayBill_Time.Name = "WayBill_Time";
            this.WayBill_Time.ReadOnly = true;
            this.WayBill_Time.Width = 125;
            // 
            // WayBill_MDT
            // 
            this.WayBill_MDT.DataPropertyName = "WayBill_MDT";
            this.WayBill_MDT.HeaderText = "حداکثر تاریخ تحویل";
            this.WayBill_MDT.MinimumWidth = 6;
            this.WayBill_MDT.Name = "WayBill_MDT";
            this.WayBill_MDT.ReadOnly = true;
            this.WayBill_MDT.Width = 125;
            // 
            // WayBill_Description
            // 
            this.WayBill_Description.DataPropertyName = "WayBill_Description";
            this.WayBill_Description.HeaderText = "توضیحات";
            this.WayBill_Description.MinimumWidth = 6;
            this.WayBill_Description.Name = "WayBill_Description";
            this.WayBill_Description.ReadOnly = true;
            this.WayBill_Description.Width = 125;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 566);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Bill";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "بارنامه ها ";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch4;
        internal System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.BindingSource bindingSourceData;
        private System.Windows.Forms.DataGridViewTextBoxColumn WayBill_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WayBill_SenderID;
        private System.Windows.Forms.DataGridViewButtonColumn SenderInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn WayBill_ReceiverID;
        private System.Windows.Forms.DataGridViewButtonColumn ReceiverInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn WayBill_DriverID;
        private System.Windows.Forms.DataGridViewButtonColumn DriverInformation;
        private System.Windows.Forms.DataGridViewButtonColumn CargoInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn WayBill_Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn WayBill_Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn WayBill_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn WayBill_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn WayBill_MDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WayBill_Description;
    }
}