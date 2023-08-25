using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Service_ADO_database
{
    //UC-1
    public class Payroll_Service_Operation
    {
        public static void CreateDatabase()
        {
            SqlConnection connection = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog=master;integrated security = true ");
            try
            {
                string query = "Create Database Payroll_Service_ADO";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                object value = command.ExecuteNonQuery();
                Console.WriteLine("DataBase Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no database created ");
            }
            finally
            {
                connection.Close();
            }
        }
        
    }
}
