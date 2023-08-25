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
        ///  

        Console.WriteLine("Payroll_service!");
        //Payroll_Service_Operation.CreateDatabase();
        Payroll_Service_Operation.CreateTable();


    }
}
