using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WayBill.DataAccess;
using WayBill.LogicLayer;
using WayBill.UserInterface;

namespace WayBill.UserInterface
{
    public partial class Report : Form
    {

        public Report()
        {
            InitializeComponent();
            timer1.Start();
        }
        public void Initialize(int a)
        {
            labelsenders.Text = a.ToString();
        }
        private void Report_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            labeltime.Text = datetime.ToString("HH:mm:ss");
        }
    }
}
