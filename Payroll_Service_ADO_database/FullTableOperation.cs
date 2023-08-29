using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Service_ADO_database
{
    public class FullTableOperation
    {
        private SqlConnection con;
        //To Handle connection related activities    
        private void connection()
        {
            string connectionStr = "data source = (localdb)\\MSSQLLocalDB; initial catalog=payroll_service;integrated security = true ";
            con = new SqlConnection(connectionStr);
        }
        //To Add Employee details    
        public bool AddEmployee(FullTableModel obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("AddEmployee", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", obj.name);
                com.Parameters.AddWithValue("@salary", obj.salary);
                com.Parameters.AddWithValue("@start_date", obj.start_date);
                com.Parameters.AddWithValue("@Gender", obj.Gender);
                com.Parameters.AddWithValue("@Phone", obj.Gender);
                com.Parameters.AddWithValue("@Address", obj.Address);
                com.Parameters.AddWithValue("@Department", obj.Department);
                com.Parameters.AddWithValue("@Basic_pay", obj.Basic_pay);
                com.Parameters.AddWithValue("@Deductions", obj.Deductions);
                com.Parameters.AddWithValue("@Taxable_pay", obj.Taxable_pay);
                com.Parameters.AddWithValue("@Income_Tax", obj.Income_tax);
                com.Parameters.AddWithValue("@Net_pay", obj.Net_pay);
                con.Open();
                int i = com.ExecuteNonQuery(); //Execute and return the num of records added
                con.Close();
                if (i != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public bool UpdateEmployee(FullTableModel obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("UpdateEmployee", con);

                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", obj.id);
                com.Parameters.AddWithValue("@name", obj.name);
                com.Parameters.AddWithValue("@salary", obj.salary);
                com.Parameters.AddWithValue("@Phone", obj.Phone);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public List<FullTableModel> GetAllEmployeeDetails()
        {
            connection();
            List<FullTableModel> emplist = new List<FullTableModel>();
            SqlCommand com = new SqlCommand("GetAllEmployees", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                emplist.Add(
                    new FullTableModel
                    {
                        id = Convert.ToInt32(dr["id"]),
                        name = Convert.ToString(dr["name"]),
                        salary = Convert.ToString(dr["salary"]),
                        start_date = Convert.ToString(dr["start_date"]),
                        Gender = Convert.ToChar(dr["Gender"]),
                        Phone = Convert.ToString(dr["Phone"]),
                        Address = Convert.ToString(dr["Address"]),
                        Department = Convert.ToString(dr["Department"]),
                        Basic_pay = Convert.ToString(dr["Basic_pay"]),
                        Deductions = Convert.ToString(dr["Deductions"]),
                        Taxable_pay = Convert.ToString(dr["Taxable_pay"]),
                        Income_tax = Convert.ToString(dr["Income_tax"]),
                        Net_pay = Convert.ToString(dr["Net_pay"]),
                    }
                    );
            }
            return emplist;
            
        }
        public bool DeleteEmployee(int Id)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("DeleteEmployee", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", Id);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public FullTableModel AddEmployeeNOtbool(FullTableModel obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("AddEmployee", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", obj.name);
                com.Parameters.AddWithValue("@salary", obj.salary);
                com.Parameters.AddWithValue("@start_date", obj.start_date);
                com.Parameters.AddWithValue("@Gender", obj.Gender);
                com.Parameters.AddWithValue("@Phone", obj.Gender);
                com.Parameters.AddWithValue("@Address", obj.Address);
                com.Parameters.AddWithValue("@Department", obj.Department);
                com.Parameters.AddWithValue("@Basic_pay", obj.Basic_pay);
                com.Parameters.AddWithValue("@Deductions", obj.Deductions);
                com.Parameters.AddWithValue("@Taxable_pay", obj.Taxable_pay);
                com.Parameters.AddWithValue("@Income_Tax", obj.Income_tax);
                com.Parameters.AddWithValue("@Net_pay", obj.Net_pay);
                con.Open();
              //  string data =com.ExecuteScalar().ToString();
                string data1 = Convert.ToString(com.ExecuteScalar());
                obj.id = (int)com.ExecuteScalar();
                return obj;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void DisplayAllData()
        {
            try
            {
                // EmployeeOperation employeeDataAccess = new EmployeeOperation(); // Replace with your actual class name

                List<FullTableModel> employees = GetAllEmployeeDetails();

                foreach (FullTableModel data in employees)
                {
                    Console.WriteLine($"id: {data.id}");
                    Console.WriteLine($"name: {data.name}");
                    Console.WriteLine($"salary: {data.salary}");
                    Console.WriteLine($"start_date: {data.start_date}");
                    Console.WriteLine($"Gender: {data.Gender}");
                    Console.WriteLine($"Phone: {data.Phone}");
                    Console.WriteLine($"Address: {data.Address}");
                    Console.WriteLine($"Department: {data.Department}");
                    Console.WriteLine($"Basic_pay: {data.Basic_pay}");
                    Console.WriteLine($"Deductions: {data.Deductions}");
                    Console.WriteLine($"Taxable_pay: {data.Taxable_pay}");
                    Console.WriteLine($"Income_tax: {data.Income_tax}");
                    Console.WriteLine($"Net_pay: {data.Net_pay}");
                    Console.WriteLine("--------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
