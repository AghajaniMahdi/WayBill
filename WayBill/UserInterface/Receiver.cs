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

namespace WayBill.UserInterface
{
    public partial class Receiver : Form
    {
        LLReceiver llreceivers = new LLReceiver();

        public Receiver()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            bindingSourceData.DataSource = llreceivers.Select();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch2.Text.Trim().Length == 0)
            {
                bindingSourceData.Filter = null;
            }
            if (comboBoxSearchType2.SelectedItem == null)
            {
                MessageBox.Show("لطفا یک نوع جستجو را انتخاب کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxSearchType2.SelectedIndex == 0)
            {
                bindingSourceData.Filter = "Receiver_ID like N'" + Convert.ToInt32(textBoxSearch2.Text) + "%'";
            }
            else if (comboBoxSearchType2.SelectedIndex == 1)
            {
                bindingSourceData.Filter = "Receiver_FirstName like '" + textBoxSearch2.Text + "%' or Receiver_LastName like '" + textBoxSearch2.Text + "%'";
            }
            else if (comboBoxSearchType2.SelectedIndex == 2)
            {
                bindingSourceData.Filter = "Receiver_NationalCode like '" + textBoxSearch2.Text + "%'";
            }
            else if (comboBoxSearchType2.SelectedIndex == 3)
            {
                bindingSourceData.Filter = "Receiver_PostalCode like '" + textBoxSearch2.Text + "%'";
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
                int receiverid = Convert.ToInt32(row["Receiver_ID"]);

                if (llreceivers.Delete(receiverid))
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
                if (llreceivers.Add(form.textBox1.Text, form.textBox2.Text, form.textBox3.Text, form.textBox4.Text, form.richTextBox.Text, form.textBox5.Text))
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

            ReceiverAddEdit form = new ReceiverAddEdit();
            DataRow row = ((DataRowView)dataGridViewData.CurrentRow.DataBoundItem).Row;

            form.textBox1.Text = row["Receiver_FirstName"].ToString();
            form.textBox2.Text = row["Receiver_LastName"].ToString();
            form.textBox3.Text = row["Receiver_NationalCode"].ToString();
            form.textBox4.Text = row["Receiver_CellPhone"].ToString();
            form.richTextBox.Text = row["Receiver_Address"].ToString();
            form.textBox5.Text = row["Receiver_PostalCode"].ToString();

            int receiverid = Convert.ToInt32(row["Receiver_ID"]);

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (llreceivers.Edit(receiverid, form.textBox1.Text, form.textBox2.Text, form.textBox3.Text, form.textBox4.Text, form.richTextBox.Text, form.textBox5.Text))
                {
                    LoadData();
                    MessageBox.Show("سطر مورد نظر با موفقیت ویرایش شد", "پیغام سیستم");
                }
            }
        }
    }
}
