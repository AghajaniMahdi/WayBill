using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WayBill.LogicLayer;
using WayBill.UserInterface;

namespace WayBill.UserInterface
{
    public partial class Driver : Form
    {
        LLDrivers lldriver = new LLDrivers();

        public Driver()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            bindingSourceData.DataSource = lldriver.Select();
        }

        private void textBoxSearch2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch3.Text.Trim().Length == 0)
            {
                bindingSourceData.Filter = null;
            }
            if (comboBoxSearchType3.SelectedItem == null)
            {
                MessageBox.Show("لطفا یک نوع جستجو را انتخاب کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxSearchType3.SelectedIndex == 0)
            {
                bindingSourceData.Filter = "Driver_ID like N'" + Convert.ToInt32(textBoxSearch3.Text) + "%'";
            }
            else if (comboBoxSearchType3.SelectedIndex == 1)
            {
                bindingSourceData.Filter = "Driver_FirstName like '" + textBoxSearch3.Text + "%' or Driver_LastName like '" + textBoxSearch3.Text + "%'";
            }
            else if (comboBoxSearchType3.SelectedIndex == 2)
            {
                bindingSourceData.Filter = "Driver_NationalCode like '" + textBoxSearch3.Text + "%'";
            }
            else if (comboBoxSearchType3.SelectedIndex == 3)
            {
                bindingSourceData.Filter = "Driver_LicenseNumber like '" + textBoxSearch3.Text + "%'";
            }
            else if (comboBoxSearchType3.SelectedIndex == 4)
            {
                bindingSourceData.Filter = "Driver_SmartCardNumber like '" + textBoxSearch3.Text + "%'";
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.CurrentRow == null)
            {
                MessageBox.Show("لطفا یک سطر را انتخاب کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dlgresult = MessageBox.Show("آبا از حذف این سطر اطمینان دارید", "پیغام سیستم", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgresult == DialogResult.Yes)
            {
                DataRow row = ((DataRowView)dataGridViewData.CurrentRow.DataBoundItem).Row;
                int driverid = Convert.ToInt32(row["Driver_ID"]);

                if (lldriver.Delete(driverid))
                {
                    LoadData();
                    MessageBox.Show("سطر مورد نظر با موفقیت حذف شد", "پیغام سیستم");
                }

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DriverAddEdit form = new DriverAddEdit();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (lldriver.Add(form.textBox1.Text, form.textBox2.Text, form.textBox3.Text, form.textBox4.Text, form.textBox5.Text, form.textBox6.Text, form.richTextBox1.Text, form.comboBox1.Text, form.richTextBox2.Text, form.richTextBox3.Text))
                {
                    LoadData();
                    MessageBox.Show("سطر مورد نظر با موفقیت اضافه شد", "پیغام سیستم");
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.CurrentRow == null)
            {
                MessageBox.Show("لطفا یک سطر را انتخاب کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DriverAddEdit form = new DriverAddEdit();
            DataRow row = ((DataRowView)dataGridViewData.CurrentRow.DataBoundItem).Row;

            form.textBox1.Text = row["Driver_FirstName"].ToString();
            form.textBox2.Text = row["Driver_LastName"].ToString();
            form.textBox3.Text = row["Driver_CellPhone"].ToString();
            form.textBox4.Text = row["Driver_NationalCode"].ToString();
            form.textBox5.Text = row["Driver_LicenseNumber"].ToString();
            form.textBox6.Text = row["Driver_SmartCardNumber"].ToString();
            form.richTextBox1.Text = row["Driver_Plate1"].ToString();
            form.comboBox1.Text = row["Driver_Plate2"].ToString();
            form.richTextBox2.Text = row["Driver_Plate3"].ToString();
            form.richTextBox3.Text = row["Driver_Plate4"].ToString();
            int receiverid = Convert.ToInt32(row["Driver_ID"]);


            if (form.ShowDialog() == DialogResult.OK)
            {
                if (lldriver.Edit(receiverid, form.textBox1.Text, form.textBox2.Text, form.textBox3.Text, form.textBox4.Text, form.textBox5.Text, form.textBox6.Text, form.richTextBox1.Text,form.comboBox1.Text, form.richTextBox2.Text, form.richTextBox3.Text))
                {
                    LoadData();
                    MessageBox.Show("سطر مورد نظر با موفقیت ویرایش شد", "پیغام سیستم");
                }
            }
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PlateDisplay form = new PlateDisplay();

            DataRow row = ((DataRowView)dataGridViewData.CurrentRow.DataBoundItem).Row;

            form.richTextBox1.Text = row["Driver_Plate1"].ToString();
            form.comboBox1.Text = row["Driver_Plate2"].ToString();
            form.richTextBox2.Text = row["Driver_Plate3"].ToString();
            form.richTextBox3.Text = row["Driver_Plate4"].ToString();

            form.ShowDialog();
        }
    }
}
