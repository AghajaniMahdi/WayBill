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
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void FormMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuInsurance_Click(object sender, EventArgs e)
        {
            Insurance form = new Insurance();
            form.ShowDialog();
        }

        private void فرستندهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sender form = new Sender();
            form.ShowDialog();
        }

        private void گیرندهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receiver form = new Receiver();
            form.ShowDialog();
        }

        private void رانندهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver form = new Driver(); 
            form.ShowDialog();
        }
    }
}
