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
using WayBill.DataAccess;

namespace WayBill.UserInterface
{

    public partial class Insurance : Form
    {
        LLInsurances llinsurances = new LLInsurances();

        public Insurance()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            bindingSourceData.DataSource = llinsurances.Select();
        }
        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.CurrentRow == null)
            {
                MessageBox.Show("لصفا یک سطر را انتخاب کنید", "پیغام سیستم");
                return;
            }
            DialogResult dlg = MessageBox.Show("آیا از حذف این سطر اطمینان دارید", "پیغام سیستم", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                return;
            }

            DataRow row = ((DataRowView)dataGridViewData.CurrentRow.DataBoundItem).Row;
            int intinsurance_ID = Convert.ToInt32(row["Insurance_ID"]);

            if (llinsurances.Delete(intinsurance_ID))
            {
                LoadData();
                MessageBox.Show("سطر مورد نظر با موفقیت حذف شد", "پیغام سیستم");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim().Length == 0)
            {
                bindingSourceData.Filter = null;
            }
            if (comboBoxSearchType.SelectedItem == null)
            {
                MessageBox.Show("لطفا یک نوع فیلتر را انتخاب کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxSearchType.SelectedIndex == 0)
            {
                bindingSourceData.Filter = "Insurance_PolicyNumber like '" + textBoxSearch.Text + "%'";
            }
            else if (comboBoxSearchType.SelectedIndex == 1)
            {
                bindingSourceData.Filter = "Insurance_CompanyName like '" + textBoxSearch.Text + "%'";
            }
            else if (comboBoxSearchType.SelectedIndex == 2)
            {
                bindingSourceData.Filter = "Insurance_InsuredName like '" + textBoxSearch.Text + "%'";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            InsuranceAddEdit formm = new InsuranceAddEdit();
            if (formm.ShowDialog() == DialogResult.OK)
            {
                if (llinsurances.Add(formm.textBox1.Text, formm.textBox2.Text, formm.textBox3.Text, formm.richTextBox.Text, formm.textBox4.Text))
                {
                    LoadData();
                    MessageBox.Show("سطر مورد نظر با موفقیت اظافه شد", "پیغام سیستم");
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            InsuranceAddEdit formm = new InsuranceAddEdit();
            DataRow row = ((DataRowView)dataGridViewData.CurrentRow.DataBoundItem).Row;

            int intinsuranceid = Convert.ToInt32(row["Insurance_ID"]);
            formm.textBox1.Text = row["Insurance_CompanyName"].ToString();
            formm.textBox2.Text = row["Insurance_InsuredName"].ToString();
            formm.textBox3.Text = row["Insurance_InsuredPhoneNumber"].ToString();
            formm.richTextBox.Text = row["Insurance_InsuredAddreess"].ToString();
            formm.textBox4.Text = row["Insurance_PolicyNumber"].ToString();

            if (formm.ShowDialog() == DialogResult.OK)
            {
                if (llinsurances.Edit(intinsuranceid, formm.textBox1.Text, formm.textBox2.Text, formm.textBox3.Text, formm.richTextBox.Text, formm.textBox4.Text))
                {
                    LoadData();
                    MessageBox.Show("سطر مورد نظر با موفقیت ویرایش شد", "پیغام سیستم");
                }

            }
        }
    }
}
