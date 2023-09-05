using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WayBill.DataAccess;
using WayBill.LogicLayer;
namespace WayBill.UserInterface
{
    public partial class Sender : Form
    {
        LLSenders llsenders = new LLSenders();

        public Sender()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            bindingSourceData.DataSource = llsenders.Select();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim().Length == 0)
            {
                bindingSourceData.Filter = null;
            }
            if (comboBoxSearchType.SelectedItem == null)
            {
                MessageBox.Show("لطفا یک نوع جستجو را انتخاب کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxSearchType.SelectedIndex == 0)
            {
                bindingSourceData.Filter = "Sender_ID like N'" + Convert.ToInt32(textBoxSearch.Text) + "%'";
            }
            else if (comboBoxSearchType.SelectedIndex == 1)
            {
                bindingSourceData.Filter = "Sender_FirstName like '" + textBoxSearch.Text + "%' or Sender_LastName like '" + textBoxSearch.Text + "%'";
            }
            else if (comboBoxSearchType.SelectedIndex == 2)
            {
                bindingSourceData.Filter = "Sender_NationalCode like '" + textBoxSearch.Text + "%'";
            }
            else if (comboBoxSearchType.SelectedIndex == 3)
            {
                bindingSourceData.Filter = "Sender_PostalCode like '" + textBoxSearch.Text + "%'";
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
                int senderid = Convert.ToInt32(row["Sender_ID"]);

                if (llsenders.Delete(senderid))
                {
                    LoadData();
                    MessageBox.Show("سطر مورد نظر با موفقیت حذف شد", "پیغام سیستم");
                }

            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SenderAddEdit form = new SenderAddEdit();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (llsenders.Add(form.textBox1.Text, form.textBox2.Text, form.textBox3.Text, form.textBox4.Text, form.richTextBox.Text, form.textBox5.Text))
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

            SenderAddEdit form = new SenderAddEdit();
            DataRow row = ((DataRowView)dataGridViewData.CurrentRow.DataBoundItem).Row;

            form.textBox1.Text = row["Sender_FirstName"].ToString();
            form.textBox2.Text = row["Sender_LastName"].ToString();
            form.textBox3.Text = row["Sender_NationalCode"].ToString();
            form.textBox4.Text = row["Sender_CellPhone"].ToString();
            form.richTextBox.Text = row["Sender_Address"].ToString();
            form.textBox5.Text = row["Sender_PostalCode"].ToString();

            int senderid = Convert.ToInt32(row["Sender_ID"]);

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (llsenders.Edit(senderid, form.textBox1.Text, form.textBox2.Text, form.textBox3.Text, form.textBox4.Text, form.richTextBox.Text, form.textBox5.Text))
                {
                    LoadData();
                    MessageBox.Show("سطر مورد نظر با موفقیت ویرایش شد", "پیغام سیستم");
                }
            }
        }
    }
}
