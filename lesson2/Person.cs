public abstract class Person
{ 
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Adress { get; set; }
    public DateTime BirthDay { get; set; } = new DateTime();
    
    public int CalculateAge()
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