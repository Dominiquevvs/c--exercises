namespace c__exercises;

public partial class Employee;
class Program
{
    static void Main(string[] args)
    {
        // 1. Skapa objektet
        Employee currentEmployee = new Employee();

        // 2. Anropa metoden (Viktigt med radbrytning här!)
        decimal skatt = currentEmployee.IncomeTax();

        // 3. Skriv ut
        Console.WriteLine($"Inkomstskatten är: {skatt} kr");
        
        // Håller fönstret öppet så du hinner se resultatet
        Console.ReadLine();
    }
}

// Din Employee-klass kan ligga här under
public partial class Employee
{
    public decimal IncomeTax()
    {
        return 5000.50m;
    }
}