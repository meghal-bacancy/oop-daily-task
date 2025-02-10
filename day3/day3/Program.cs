using day3;

class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
        PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
        Intern intern = new Intern();

        Console.WriteLine($"full time employee salary: {fullTimeEmployee.CalculateSalary(50)}");
        Console.WriteLine($"part time employee salary: {partTimeEmployee.CalculateSalary(50)}");
        Console.WriteLine($"intern salary: {intern.CalculateSalary(50)}");
    }
}
