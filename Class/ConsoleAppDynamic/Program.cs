using ConsoleAppDynamic;

public class Program
{
    public static void Main(string[] args)
    {
        Employee emp1 = new Employee("Sam", "Pondicherry", 45);
        Employee emp2 = new Employee("Seema", "Chennai", 35);
        Employee emp3 = new Employee("Lisa", "Delhi", 5);
        EmployeeList employee = new EmployeeList();
        employee.AddEmp(emp1);
        employee.AddEmp(emp2);
        employee.AddEmp(emp3);

        employee.DisplayAll();
        Console.ReadLine();


    }
}
