using System.Text.RegularExpressions;

namespace anytizer.converter.numbers.values
{
    public class santizier
    {
        public string Sanitize(double number)
        {
            string n = number.ToString();
            n = Sanitize(n);

            return n;
        }

        public string Sanitize(string number)
        {
            string n = number.ToString();
            n = Regex.Replace(n, "\\..*?$", ""); // throw away .NNN
            n = Regex.Replace(n, "[^0-9]", "");

            return n;
        }
    }
}