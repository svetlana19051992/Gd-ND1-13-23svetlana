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