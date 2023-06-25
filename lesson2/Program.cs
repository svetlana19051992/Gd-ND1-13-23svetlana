// See https://aka.ms/new-console-template for more information

Employee emp = new Employee
 { 
    Name = "Svetlana",
    LastName = "Svetlanova",
    Adress = "Minsk",
    BirthDay = new DateTime(1990, 12, 3),
    Education = "high",
    Profession = "risk manager",
    Position = "manager"
    };

emp.SolveProblem();

Customer cust = new Customer 
{
    Name = "Svetlana",
    LastName = "Svetlanova",
    Adress = "Minsk",
    BirthDay = new DateTime(1990, 12, 3),
    Swift = "BPSBBY2X",
    Account = 301200
    }; 

cust.SolveProblem();

Console.ReadLine();