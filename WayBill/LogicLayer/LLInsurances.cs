using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBill.DataAccess;


namespace WayBill.LogicLayer
{
    internal class LLInsurances
    {   
        //Select
        internal DataTable Select()
        {
            return SqlServerWorker.Select("Select * from Insurances;");            
        }

        //Insert
        internal bool Add(string companyname, string insuredname, string insuredphonenumber, string insuredaddress, string policynumber)
        {
            return SqlServerWorker.Execute($"Insert into Insurances(Insurance_CompanyName, Insurance_InsuredName, Insurance_InsuredPhoneNumber, Insurance_InsuredAddreess, Insurance_PolicyNumber)values(N'{companyname}', N'{insuredname}', N'{insuredphonenumber}', N'{insuredaddress}', N'{policynumber}');");
        }

        //Update
        internal bool Edit(int id, string companyname, string insuredname, string insuredphonenumber, string insuredaddress, string policynumber)
        {
            return SqlServerWorker.Execute($"Update Insurances set Insurance_CompanyName = N'{companyname}', Insurance_InsuredName = N'{insuredname}', Insurance_InsuredPhoneNumber = N'{insuredphonenumber}', Insurance_InsuredAddreess = N'{insuredaddress}', Insurance_PolicyNumber = N'{policynumber}' where Insurance_ID = {id};");
        }

        //Delete
        internal bool Delete(int insurance_ID)
        {
            return SqlServerWorker.Execute("Delete Insurances where Insurance_ID = " + insurance_ID + ";");
        }

    }
}
