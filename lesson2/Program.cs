// See https://aka.ms/new-console-template for more information

Employee emp = new Employee { Name = "Svetlana", LastName = "Svetlanova", Adress = "Minsk", BirthDay = new DateTime(1990, 12, 3), Education = "high", Profession = "risk manager", Position = "manager"};
emp.SolveProblem();
Customer cust = new Customer { Name = "Svetlana", LastName = "Svetlanova", Adress = "Minsk", BirthDay = new DateTime(1990, 12, 3), Swift = "BPSBBY2X", Account = 301200 }; 
cust.SolveProblem();
Console.ReadLine();
public abstract class Person
{ 
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Adress { get; set; }
    public DateTime BirthDay { get; set; } = new DateTime();
    public int AgeCalculation()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - BirthDay.Year;
        if (BirthDay.AddYears(age) > today)
        {
            age--;
        }
        return age;
    }
    public virtual void Print()
    {
        int age = AgeCalculation();
        Console.WriteLine($"Person: {Name} {LastName}, adress: {Adress}, age: {age}");
    }
    public abstract void SolveProblem();
}

public class Employee : Person
{
    public string Education { get; set; }
    public string Profession { get; set; }
    public string Position { get; set; }
    public override void SolveProblem()
    {
        int age = AgeCalculation();
        Console.WriteLine($"Person: {Name} {LastName}, adress: {Adress}, age: {age}");
        Console.WriteLine($"Education: {Education}, profession: {Profession}, position: {Position}");
    }
}

public class Customer : Person
{
    public string Swift { get; set; }
    public int Account { get; set; }
    public override void SolveProblem()
    {
        int age = AgeCalculation();
        Console.WriteLine($"Person: {Name} {LastName}, adress: {Adress}, age: {age}");
        Console.WriteLine($"Swift: {Swift}, account: {Account}");
    }
}
