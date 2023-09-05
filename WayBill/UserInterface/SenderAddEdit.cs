using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WayBill.UserInterface
{
    public partial class SenderAddEdit : Form
    {
        public SenderAddEdit()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا نام فرستنده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا نام خانوادگی فرستنده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا کد ملی فرستنده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا تلفن همراه فرستنده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(richTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا آدرس فرستنده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox5.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا کد پستی فرستنده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SenderAddEdit_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
