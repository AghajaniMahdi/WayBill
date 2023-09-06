using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WayBill.DataAccess;
namespace WayBill.LogicLayer
{
    internal class LLDrivers
    {
        internal DataTable Select()
        {
            return SqlServerWorker.Select("Select * from Drivers");
        }

        internal bool Add(string firstname, string lastname, string cellphone, string nationalcode, string licensenumber, string smartcardnumber, string plate1, string plate2, string plate3, string plate4)
        {
            return SqlServerWorker.Execute($"Insert into Drivers (Driver_FirstName, Driver_LastName, Driver_CellPhone, Driver_NationalCode, Driver_LicenseNumber, Driver_SmartCardNumber, Driver_Plate1, Driver_Plate2, Driver_Plate3, Driver_Plate4)values(N'{firstname}', N'{lastname}', N'{cellphone}', N'{nationalcode}', N'{licensenumber}', N'{smartcardnumber}', N'{plate1}', N'{plate2}', N'{plate3}', N'{plate4}');");
        }

        internal bool Edit(int driverid, string firstname, string lastname, string cellphone, string nationalcode, string licensenumber, string smartcardnumber, string plate1, string plate2, string plate3, string plate4)
        {
            return SqlServerWorker.Execute($"Update Drivers set Driver_FirstName = N'{firstname}', Driver_LastName = N'{lastname}', Driver_CellPhone = N'{cellphone}', Driver_NationalCode = N'{nationalcode}', Driver_LicenseNumber = N'{licensenumber}', Driver_SmartCardNumber = N'{smartcardnumber}', Driver_Plate1 = N'{plate1}', Driver_Plate2 = N'{plate2}', Driver_Plate3 = N'{plate3}', Driver_Plate4 = N'{plate4}' where Driver_ID = {driverid};");

        }
        internal bool Delete(int driverid)
        {
            return SqlServerWorker.Execute("Delete Drivers where Driver_ID = " + driverid + ";");
        }
    }
}
