using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8_2
{
    public class WordReader
    {
        public static string GetWord(string filePath, int wordNumber)
        { 
            StringBuilder result = new StringBuilder();
            using (StreamReader reader = new StreamReader(filePath))
            {
                int count = wordNumber - 1;
                while(true)
                {
                    char c = (char)reader.Read();
                    if (c == 32)
                        count--;
                    else if (count == 0)
                        result.Append(c);
                    else if (count < 0)
                        break;
                }
                Console.WriteLine(result.ToString());  
            }
            return result.ToString();
        } 
    }
}