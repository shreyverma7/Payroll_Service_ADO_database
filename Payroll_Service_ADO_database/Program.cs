using Payroll_Service_ADO_database;

internal class Program
{
    private static void Main(string[] args)
    {
        EmployeeOperation Operation = new EmployeeOperation();
        bool flag = true;
        while (flag)
        {
        MainMenu:
            Console.WriteLine("\n\nADO.net");
            Console.WriteLine("1.Person SampleDatabase (ankit) \n2.PayRoll_service Table \n3.Employee Table (self) \n4.Full Table Employee \n5.Exit");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("\nWelcome to Person Sample Table\n");
                    //Console.WriteLine("(localdb)\\MSSQLLocalDB");
                    // PersonOperation operation = new PersonOperation();
                    Console.WriteLine("1.Create Database \n2.Create Table \n3.Read From Database \n4.Update database \n5.Delete database\n6.Main Menu");
                    int inputofSample = Convert.ToInt32(Console.ReadLine());
                    switch (inputofSample)
                    {
                        case 1:
                            PersonOperation.CreateDatabase();
                            break;
                        case 2:
                            PersonOperation.CreateTable();
                            break;
                        case 3:
                            PersonOperation.ReadFromDatabase();
                            break;
                        case 4:
                            PersonOperation.updateDatebase();
                            break;
                        case 5:
                            PersonOperation.DeleteDatebase();
                            break;
                        case 6:
                            Console.WriteLine("exiting....\n");
                            goto MainMenu;
                    }
                    break;
                case 2:
                    Console.WriteLine("\nWelcome to Payroll service Table\n");
                    Console.WriteLine("1.Create Database \n2.Create Table \n3.Read From Database \n4.Insert into database \n5.Retrive data between date" +
                        "\n6.Add coloumn \n7.update data into new coloum\n8.Manual query\n9.Main Menu");
                    int inputofPayroll = Convert.ToInt32(Console.ReadLine());
                    switch (inputofPayroll)
                    {
                        case 1:
                            Payroll_Service_Operation.CreateDatabase();
                            break;
                        case 2:
                            Payroll_Service_Operation.CreateTable();
                            break;
                        case 3:
                            Payroll_Service_Operation.ReadFromDatabase();
                            break;
                        case 4:
                            Payroll_Service_Operation.InsertDatebase();
                            break;
                        case 5:
                            Payroll_Service_Operation.RetriveBetweenDatebase();
                            break;
                        case 6:
                            string query = "Alter table employee_payroll\r\nAdd Gender Char(1);";
                            Payroll_Service_Operation.Queryexecte(query);
                            break;

                        case 7:
                            string query1 = "update employee_payroll set Gender = 'M' where id in (1,4);\r\nupdate employee_payroll set Gender = 'F' where id between 2 and 3;";
                            Payroll_Service_Operation.Queryexecte(query1);
                            break;
                        case 8:
                            Console.WriteLine("Type query");
                            string queryFromtext = Console.ReadLine();
                            Payroll_Service_Operation.Queryexecte(queryFromtext);
                            Console.WriteLine("query exexuted");
                            break;
                        case 9:
                            Console.WriteLine("exiting....\n");
                            goto MainMenu;
                    }
                    break;
                case 3:
                    Console.WriteLine("\nWelcome to Employee ado.net Table\n");
                    Console.WriteLine("1.Add Employee \n2.Update Employee \n3.Delete Employee \n4.Display All \n5.Main Menu");
                    int inputofEmp = Convert.ToInt32(Console.ReadLine());
                   
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
                    switch (inputofEmp)
                    {
                        case 1:
                            Operation.exuctedorNot(Operation.AddEmployee(employee));
                            break;
                        case 2:
                            Operation.exuctedorNot(Operation.UpdateEmployee(employee1));
                            break;
                        case 3:
                            Operation.exuctedorNot(Operation.DeleteEmployee(5));
                            break;
                        case 4:
                            Operation.DisplayAllData();
                            break;
                        case 5:
                            Console.WriteLine("exiting....\n");
                            goto MainMenu;
                    }
                    break;
                case 4:
                    Console.WriteLine("Full Table Employee\n");
                    FullTableOperation tableOperation = new FullTableOperation();
                    FullTableModel data = new FullTableModel()
                    {
                        name = "shrey",
                        salary = "12211",
                        start_date = "2014-12-12",
                        Gender = 'M',
                        Phone = "1234321",
                        Address = "Central",
                        Department = "IT",
                        Basic_pay = "1222",
                        Deductions = "234",
                        Taxable_pay = "234",
                        Income_tax = "234",
                        Net_pay = "234",

                    };
                    FullTableModel data1 = new FullTableModel()
                    {
                        id = 4,
                        name = "shrey",
                        salary = "12211",
                        Phone = "1234321",
                    };
                    Console.WriteLine("1.Create Database \n2.Create Table \n3.Read From Database \n4.Update database \n5.Delete database\n6.Main Menu");
                    int inputofFull = Convert.ToInt32(Console.ReadLine());
                    switch (inputofFull)
                    {
                        case 1:
                            Operation.exuctedorNot(tableOperation.AddEmployee(data));
                            break;
                        case 2:
                            Operation.exuctedorNot(tableOperation.UpdateEmployee(data1));
                            break;
                        case 3:
                            tableOperation.DisplayAllData();
                            break;
                        case 4:
                            Operation.exuctedorNot(tableOperation.DeleteEmployee(6));
                            break;
                        case 5:
                            //tableOperation.AddEmployeeNOtbool(data2);
                            //FullTableModel answer = tableOperation.AddEmployeeNOtbool(data);
                           // Console.WriteLine(answer.id + "-----" + answer.name);
                            break;
                        case 6:
                            Console.WriteLine("exiting....\n");
                            goto MainMenu;
                    }

                    break;


            }
        }



















       


        

       
        
        
        
       



    }

}

