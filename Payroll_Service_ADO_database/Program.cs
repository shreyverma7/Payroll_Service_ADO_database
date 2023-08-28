using Payroll_Service_ADO_database;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("(localdb)\\MSSQLLocalDB");
        //PersonOperation.updateDatebase();
        //PersonOperation.DeleteDatebase();
        // PersonOperation operation = new PersonOperation();
        //PersonOperation.CreateDatabase();
        //PersonOperation.ReadFromDatabase();
        // PersonOperation.CreateTable();



        ///  Payroll_Service_Operation payroll_Service_Operation = new Payroll_Service_Operation();
        //Console.WriteLine("Payroll_service!");
        //Payroll_Service_Operation.CreateDatabase();
        //Payroll_Service_Operation.CreateTable();
        // Payroll_Service_Operation.InsertDatebase();
        // Payroll_Service_Operation.ReadFromDatabase();
        // Payroll_Service_Operation.RetriveBetweenDatebase();
        // string query = "Alter table employee_payroll\r\nAdd Gender Char(1);";
        //string query1 = "update employee_payroll set Gender = 'M' where id in (1,4);\r\nupdate employee_payroll set Gender = 'F' where id between 2 and 3;";
        //Payroll_Service_Operation.Queryexecte(query1);

        Console.WriteLine("Employee Table");

        Employee employee = new Employee()
        {
            Name = "a",
            City = "b",
            Address = "c"

        };

        Employee employee1 = new Employee()
        {
            EmpId = 3,
            Name = "updatedName",
            City = "UpdatedCity",
            Address = "UpdatedAddress"
           
        };
        EmployeeOperation Operation = new EmployeeOperation();
        //Operation.AddEmployee(employee);
        // Operation.exuctedorNot(Operation.AddEmployee(employee));
        //Operation.exuctedorNot(Operation.UpdateEmployee(employee1));
        // Operation.exuctedorNot(Operation.DeleteEmployee(5));
        Operation.DisplayAllData();

    }

}

