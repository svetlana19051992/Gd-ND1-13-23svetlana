// See https://aka.ms/new-console-template for more information
using lesson7_1;
AClass example = new AClass("Helena");
//AClass example2 = new AClass("");
AClass example3 = new AClass("Dmitriy");

try
{
    example.ShowNonEmptyName();
  //  example2.ShowNonEmptyName();
    example3.ShowNameEndingWithDot();
}

catch (EmptyNameException ex)
{
    Console.WriteLine($"ErrorEmpty:{ex.Message}");
}

catch (DoesNotEndWithADotException ex)
{
    Console.WriteLine($"ErrorPoint:{ex.Message}");
}

catch (Exception ex)
{
    Console.WriteLine($"Error:{ex.Message}");
}

finally
{ 
    Console.WriteLine($"Hello.");    
}
