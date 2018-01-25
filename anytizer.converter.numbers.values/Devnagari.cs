namespace anytizer.converter.numbers.values
{
    public class Devnagari
    {
        public string padhma { get; set; }
        public string shankha { get; set; }
        public string neel { get; set; }
        public string kharb { get; set; }
        public string arb { get; set; }
        public string karod { get; set; }
        public string lakhs { get; set; }
        public string thousands { get; set; }
        public string hundreds { get; set; }
        public string tens { get; set; }
        public string units { get; set; } // not required
                                          // 12 34 56 78 90 98 765

        public void fill(string n)
        {
            int length = n.Length;
            // if(length == 19) // errro, too long
            if (length >= 19) { padhma = n.Substring(length - 19, 2); }
            if (length == 18) { padhma = n.Substring(length - 18, 1); }
            if (length >= 17) { shankha = n.Substring(length - 17, 2); }
            if (length == 16) { shankha = n.Substring(length - 16, 1); }
            if (length >= 15) { neel = n.Substring(length - 15, 2); }
            if (length == 14) { neel = n.Substring(length - 14, 1); }
            if (length >= 13) { kharb = n.Substring(length - 13, 2); }
            if (length == 12) { kharb = n.Substring(length - 12, 1); }
            if (length >= 11) { arb = n.Substring(length - 11, 2); }
            if (length == 10) { arb = n.Substring(length - 10, 1); }
            if (length >= 9) { karod = n.Substring(length - 9, 2); }
            if (length == 8) { karod = n.Substring(length - 8, 1); }
            if (length >= 7) { lakhs = n.Substring(length - 7, 2); }
            if (length == 6) { lakhs = n.Substring(length - 6, 1); }
            if (length >= 5) { thousands = n.Substring(length - 5, 2); };
            if (length == 4) { thousands = n.Substring(length - 4, 1); }
            if (length >= 3) { hundreds = n.Substring(length - 3, 1); }
            //if (length == 2) { tens = n.Substring(length - 2, 2); }
            if (length > 1) { tens = n.Substring(length - 2, 2); }
            if (length == 1) { tens = n.Substring(length - 1, 1); }
            if (length == 0) { tens = "00"; }
        }

        public string get(UnitsProvider up)
        {
            string output = "";
            output += " " + up.read(padhma, 18);
            output += " " + up.read(shankha, 16);
            output += " " + up.read(neel, 14);
            output += " " + up.read(kharb, 12);
            output += " " + up.read(arb, 10);
            output += " " + up.read(karod, 8);
            output += " " + up.read(lakhs, 6);
            output += " " + up.read(thousands, 4);
            output += " " + up.read(hundreds, 3);
            output += " " + up.read(tens, 2);
            // when unit or tens, do not write last measurement

            return output;
        }
    }
}
