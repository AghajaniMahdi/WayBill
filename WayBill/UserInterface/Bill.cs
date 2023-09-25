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
using WayBill.DataAccess;

namespace WayBill.UserInterface
{
    public partial class Bill : Form
    {
        LLBills llbills = new LLBills();
        LLSenders llsenders = new LLSenders();  

        public Bill()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            bindingSourceData.DataSource = llbills.Select();
        }

        private void textBoxSearch3_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch4.Text.Trim().Length == 0)
            {
                bindingSourceData.Filter = null;
            }
            if (comboBoxSearchType.SelectedItem == null)
            {
                MessageBox.Show("لطفا یک نوع جستجو را انتخاب نمایید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (comboBoxSearchType.SelectedIndex == 0)
            {

            }
            if (comboBoxSearchType.SelectedIndex == 1)
            {

            }
            if (comboBoxSearchType.SelectedIndex == 2)
            {

            }
            if (comboBoxSearchType.SelectedIndex == 3)
            {

            }
            if (comboBoxSearchType.SelectedIndex == 4)
            {

            }
            if (comboBoxSearchType.SelectedIndex == 5)
            {
                bindingSourceData.Filter = "WayBill_Origin like '" + textBoxSearch4.Text + "%'";
            }
            if (comboBoxSearchType.SelectedIndex == 6)
            {
                bindingSourceData.Filter = "WayBill_Destination like '" + textBoxSearch4.Text + "%'";
            }

        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SenderReceiverDisplay form = new SenderReceiverDisplay();

            DataRow row = ((DataRowView)dataGridViewData.CurrentRow.DataBoundItem).Row;
            int senderid = Convert.ToInt32(row["WayBill_SenderID"]);

            MessageBox.Show(senderid.ToString());


            DataTable table = llsenders.ConditionalSelect(senderid);
            
        }
    }

}
