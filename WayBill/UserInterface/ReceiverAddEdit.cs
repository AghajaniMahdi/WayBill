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
    public partial class ReceiverAddEdit : Form
    {
        public ReceiverAddEdit()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا نام گیرنده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا نام خانوادگی گیرنده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا کد ملی گیرنده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا تلفن همراه گیرنده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (richTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا آدرس گیرنده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox5.Text.Trim().Length == 0l)
            {
                MessageBox.Show("لطفا کد پستی گیرنده را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
