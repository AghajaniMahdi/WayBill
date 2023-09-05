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
    public partial class InsuranceAddEdit : Form
    {
        public InsuranceAddEdit()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا نام شرکت را وارد کنید","پیغام سیستم",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا نام بیمه گذار را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا شماره تلفن بیمه گذار را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (richTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا آدرس بیمه گذار را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا شماره قرار داد بیمه نامه را وارد کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
