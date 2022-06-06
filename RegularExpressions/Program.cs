using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d"; // finds all numbers
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12345. And more numbers: 723. The end.";
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine($"{matches.Count} matches found.");
            foreach (Match item in matches)
            {
                // Console.WriteLine(item);
                GroupCollection group = item.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}.");
            }            
            
            // highlights all website links:
            // (http|https)://(www.)?tutorials.eu or
            // https?://(www.)?\w+.\w+

            // highlights all phone numbers:
            // (\d{4}|\+49\d{3}|0049\d{3})/\d{8} or 
            // (\+49)|0049|0?1(6|7)\d/\d{8}

            // email.regex.com - regular expressions for email addresses, 99.99%
            // .NET (general pattern match): ^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$ or
            // System.Net.Mail.MailAddress class
            // C#: ^(?(")(".+?(?<!\\)"@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$
            // General Email Regex (RFC 5322 Official Standard): (?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])


        }
    }
}
