using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WayBill.DataAccess;
namespace WayBill.LogicLayer
{
    internal class LLSenders
    {
        internal DataTable Select ()
        {
            return SqlServerWorker.Select("Select * from Senders;");
        }

        //Insert
        internal bool Add(string firstname, string lastname, string nationalcode, string cellphone, string address, string postalcode)
        {
            return SqlServerWorker.Execute($"Insert into Senders(Sender_FirstName, Sender_LastName, Sender_NationalCode, Sender_CellPhone, Sender_Address, Sender_PostalCode)values(N'{firstname}', N'{lastname}', N'{nationalcode}', N'{cellphone}', N'{address}', N'{postalcode}');");
        }

        //Update
        internal bool Edit(int id, string firstname, string lastname, string nationalcode, string cellphone, string address, string postalcode)
        {
            return SqlServerWorker.Execute($"Update Senders set Sender_FirstName = N'{firstname}', Sender_LastName = N'{lastname}', Sender_NationalCode = N'{nationalcode}', Sender_CellPhone = N'{cellphone}', Sender_Address = N'{address}', Sender_PostalCode = N'{postalcode}' where Sender_ID = {id};");
        }

        //Delete
        internal bool Delete(int sender_id)
        {
            return SqlServerWorker.Execute($"Delete Senders where Sender_ID = " + sender_id + ";");

        }
    }
}
