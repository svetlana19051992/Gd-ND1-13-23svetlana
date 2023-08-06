using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8_1
{
    public class ConsoleInteractions : ITextInteractions
    {
        public string RequestInput(string prompt)
        {
            Console.WriteLine(prompt);
            string reqInput = Console.ReadLine();
            return string.IsNullOrEmpty(reqInput) ? null : reqInput;
        }

    }
}

interface ITextInteractions
{
    string RequestInput(string prompt);
}