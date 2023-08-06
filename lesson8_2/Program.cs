namespace lesson8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextGenerator.GenerateText(@"..\.gitignore", 500);
              string word = WordReader.GetWord(@"..\.gitignore", 5);         
        }
    }
}