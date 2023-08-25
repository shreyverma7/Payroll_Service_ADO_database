using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Payroll_Service_ADO_database;

namespace Payroll_Service_ADO_database
{
    public class PersonOperation
    {
        public static void CreateDatabase()
        {
            SqlConnection con = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog=master;integrated security = true ");
            try
            {
                string query = "Create Database PersonDetails";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("DataBase Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no database created ");
            }
            finally
            {
                con.Close();
            }
        }

        public static SqlConnection con = new SqlConnection("data source= (localdb)\\MSSQLLocalDB; initial catalog=PersonDetails; integrated security=true");

        public static bool ReadFromDatabase()
        {
            try
            {
                using (con)
                {
                    Person model = new Person();
                    string query = "Select * from person";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("--------Data--------");
                        while (reader.Read())
                        {
                            model.Id = Convert.ToInt32(reader["id"]);
                            model.Name = Convert.ToString(reader["name"]);
                            model.Salary = Convert.ToInt32(reader["salary"]);
                            model.Address = Convert.ToString(reader["address"]);
                            model.Phone = Convert.ToString(reader["phonenumber"]);

                            Console.WriteLine("Id : {0}\n Name: {1}\n Salary: {2}\n Address: {3}\n Phone: {4}", model.Id, model.Name, model.Salary, model.Address, model.Phone);
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Something went wrong" + ex);
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public static void updateDatebase()
        {
            try
            {
                string query = "update Person set phonenumber = '11111111' where id =1";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Date updated Suucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Date Not Updated");
            }
            finally
            {
                con.Close();
            }
        }
        public static void DeleteDatebase()
        {
            try
            {
                string query = "Delete from Person where id=2";
                SqlCommand cmd = new SqlCommand(query, con);
               // CommandType type = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Date Deleted Suucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Date Not Updated");
            }
            finally
            {
                con.Close();
            }
        }
        public static void CreateTable()
        {
            try
            {
                string query = "create table Demo(\r\nid int primary key identity(1,1),\r\nname varchar(max),\r\nsalary bigint,\r\naddress varchar(max),\r\nphonenumber varchar(10)\r\n);";
                SqlCommand cmd = new SqlCommand(query, con);
                // CommandType type = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table  Created Suucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Date Not Updated");
            }
            finally
            {
                con.Close();
            }
        }
    }
}


