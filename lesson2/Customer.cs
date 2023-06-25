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