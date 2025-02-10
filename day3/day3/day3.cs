namespace day3
{
    abstract class Employee
    {
        public abstract double CalculateSalary(double hours);
    }

    // Concrete classes for different employee types
    class FullTimeEmployee : Employee
    {
        public override double CalculateSalary(double hours)
        {
            return hours * 50;
        }
    }

    class PartTimeEmployee : Employee
    {
        public override double CalculateSalary(double hours)
        {
            return hours * 30;
        }
    }

    class Intern : Employee
    {
        public override double CalculateSalary(double hours)
        {
            return hours * 10;
        }
    }
}