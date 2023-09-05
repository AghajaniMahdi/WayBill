using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WayBill.DataAccess;
namespace WayBill.LogicLayer
{
    internal class LLReceiver
    {
        internal DataTable Select()
        {
            return SqlServerWorker.Select("Select * from Receivers;");
        }

        //Insert
        internal bool Add(string firstname, string lastname, string nationalcode, string cellphone, string address, string postalcode)
        {
            return SqlServerWorker.Execute($"Insert into Receivers(Receiver_FirstName, Receiver_LastName, Receiver_NationalCode, Receiver_CellPhone, Receiver_Address, Receiver_PostalCode)values(N'{firstname}', N'{lastname}', N'{nationalcode}', N'{cellphone}', N'{address}', N'{postalcode}');");
        }

        //Update
        internal bool Edit(int id, string firstname, string lastname, string nationalcode, string cellphone, string address, string postalcode)
        {
            return SqlServerWorker.Execute($"Update Receivers set Receiver_FirstName = N'{firstname}', Receiver_LastName = N'{lastname}', Receiver_NationalCode = N'{nationalcode}', Receiver_CellPhone = N'{cellphone}', Receiver_Address = N'{address}', Receiver_PostalCode = N'{postalcode}' where Receiver_ID = {id};");
        }

        //Delete
        internal bool Delete(int receiverid)
        {
            return SqlServerWorker.Execute($"Delete Receivers where Receiver_ID = " + receiverid + ";");

        }
    }
}
