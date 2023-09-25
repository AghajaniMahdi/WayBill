using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBill.DataAccess;

namespace WayBill.LogicLayer
{
    internal class LLBills
    {
        internal DataTable Select()
        {
            return SqlServerWorker.Select("Select * from WayBills");
        }

        
        //internal bool Add()
        //{
            //return SqlServerWorker.Execute();
        //}
        //internal bool Edit()
        //{
            //return SqlServerWorker.Execute();
        //}
        internal bool Delete(int id)
        {
            return SqlServerWorker.Execute("Delete WayBills where WayBill_ID = " + id + ";");
        }
    }

}
