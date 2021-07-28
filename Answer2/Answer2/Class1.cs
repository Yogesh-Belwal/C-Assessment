using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Answer2
{
    public static class Class1
    {
        public static string ToTitleCase(this string input)
        {
            var upperCase = input.ToUpper();
            var words = upperCase.Split(' ');
            var unchanged = new String[] {"ON", "IN", "AT", "OFF", "UP", "TO","OF", "AS", "BY","THE", "A",  "AN","AND", "BUT", "OR", "NOR","YET", "FOR", "SO"};

            for (int i = 0; i < words.Length; i++)
            {
                if (unchanged.Contains(words[i]))
                {
                    words[i] = words[i].ToLower();
                }
                else
                {
                    words[i] = words[i].ToPascalCase();
                }
            }
            return string.Join(" ", words);

        }
        public static string ToPascalCase(this string words)
        {
            return words.Substring(0, 1).ToUpper() + words.Substring(1).ToLower();
        }
    }
}
