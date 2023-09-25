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
    public partial class DriverAddEdit : Form
    {
        public int intsenders = 0;

        public DriverAddEdit()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا نام راننده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا نام خانوادگی راننده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا تلفن همراه راننده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا کد ملی راننده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox5.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا شماره گواهینامه راننده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox6.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا شماره کارت هوشمند راننده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (richTextBox1.Text.Trim().Length < 2 || comboBox1.SelectedItem == null || richTextBox2.Text.Trim().Length < 3 || richTextBox3.Text.Trim().Length < 2)
            {
                MessageBox.Show("لطفا شماره پلاک را به درستی وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            //intsenders ++;
            //MessageBox.Show(intsenders.ToString());
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
