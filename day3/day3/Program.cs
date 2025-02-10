using day3;

class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
        PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
        Intern intern = new Intern();

        Console.WriteLine(fullTimeEmployee.CalculateSalary(50));
        Console.WriteLine(partTimeEmployee.CalculateSalary(50));
        Console.WriteLine(intern.CalculateSalary(50));
    }
}
