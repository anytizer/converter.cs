using System.Text.RegularExpressions;

namespace anytizer.converter.numbers.values
{
    public class NumberConverter
    {
        public string ToDevnagari(string n)
        {
            santizier s = new santizier();
            n = s.Sanitize(n); // make sure

            Devnagari b = new Devnagari();
            b.fill(n);

            string value = b.get(new UnitsProvider());

            // replace multiple spaces in many locations
            value = Regex.Replace(value, "([ ]+)", " ");
            value = value.Trim();

            // special case of zero number
            // unit digit zero, whole
            // @todo Convert early
            if (value == "") value = "शुन्ना";

            return value;
        }

        // 80 bit, will probably have issues with long numbers
        // https://msdn.microsoft.com/en-us/library/9cx8xs15.aspx
        public string ToDevnagari(double number)
        {
            santizier s = new santizier();
            string nliteral = s.Sanitize(number);
            string nwords = this.ToDevnagari(nliteral);

            return nwords;
        }
    }
}
