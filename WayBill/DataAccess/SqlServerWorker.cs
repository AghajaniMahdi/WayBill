using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayBill.DataAccess
{
    internal class SqlServerWorker
    {
        internal static string STR_CONNECTION_STRING = "Server=.;DataBase=WayBill;Trusted_Connection=True";

        internal static DataTable Select(string strCmdText)
        {
            try
            {

                SqlConnection connection = new SqlConnection(STR_CONNECTION_STRING);
                connection.Open();
                SqlCommand command = new SqlCommand(strCmdText, connection);
                SqlDataReader sdr = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(sdr);
                sdr.Close();
                connection.Close();
                return table;

            }
            catch
            {
                return null;
            }

        }

        internal static bool Execute(string strCmdText)
        {
            try
            {

                SqlConnection connection = new SqlConnection(STR_CONNECTION_STRING);
                connection.Open();
                SqlCommand command = new SqlCommand(strCmdText, connection);
                int intAffectedRows = command.ExecuteNonQuery();
                connection.Close();
                return intAffectedRows == 1;
            }

            catch
            {
                return false;
            }

        }
    }
}
