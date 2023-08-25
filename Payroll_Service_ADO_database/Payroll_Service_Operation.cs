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
        public static SqlConnection connection = new SqlConnection("data source= (localdb)\\MSSQLLocalDB; initial catalog=Payroll_Service_ADO; integrated security=true");

        //UC2 create table
        public static void CreateTable()
        {
            try
            {
                string query = "Create table employee_payroll(\r\nid int primary key identity(1,1),\r\nname varchar(30),\r\nsalary varchar(30),\r\nstart_date date);";
                SqlCommand cmd = new SqlCommand(query, connection);
                // CommandType type = CommandType.Text;
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table  Created Suucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Date Not Updated");
            }
            finally
            {
                connection.Close();
            }
        }

        //UC3- Insert
        public static void InsertDatebase()
        {
            try
            {
                string query = "Insert into employee_payroll values('a','1000','2018-01-01');";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Date Inserted Suucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong"+ ex.GetType);
            }
            finally
            {
                connection.Close();
            }
        }

    }
    
}
