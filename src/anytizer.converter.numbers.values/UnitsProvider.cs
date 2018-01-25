using System.Collections.Generic;
using System.Linq;

namespace anytizer.converter.numbers.values
{
    public class UnitsProvider
    {
        Dictionary<string, string> units = new Dictionary<string, string>(); // numbers
        Dictionary<string, string> tenths = new Dictionary<string, string>(); // numbers
        Dictionary<int, string> u = new Dictionary<int, string>(); // measurements

        public UnitsProvider()
        {
            units.Add("0", "शुन्ना");
            units.Add("1", "एक");
            units.Add("2", "दुइ");
            units.Add("3", "तीन");
            units.Add("4", "चार");
            units.Add("5", "पाँच");
            units.Add("6", "छ");
            units.Add("7", "सात");
            units.Add("8", "आठ");
            units.Add("9", "नौ");

            // perhaps not required
            tenths.Add("0", "शुन्ना");
            tenths.Add("1", "एक");
            tenths.Add("2", "दुइ");
            tenths.Add("3", "तीन");
            tenths.Add("4", "चार");
            tenths.Add("5", "पाँच");
            tenths.Add("6", "छ");
            tenths.Add("7", "सात");
            tenths.Add("8", "आठ");
            tenths.Add("9", "नौ");

            tenths.Add("00", "शुन्ना");
            tenths.Add("01", "एक");
            tenths.Add("02", "दुइ");
            tenths.Add("03", "तीन");
            tenths.Add("04", "चार");
            tenths.Add("05", "पाँच");
            tenths.Add("06", "छ");
            tenths.Add("07", "सात");
            tenths.Add("08", "आठ");
            tenths.Add("09", "नौ");

            tenths.Add("10", "दश");
            tenths.Add("11", "एघार");
            tenths.Add("12", "बाह्र");
            tenths.Add("13", "तेह्र");
            tenths.Add("14", "चौध");
            tenths.Add("15", "पन्ध्र");
            tenths.Add("16", "सोह्र");
            tenths.Add("17", "सत्र");
            tenths.Add("18", "अठार");
            tenths.Add("19", "उन्नाइस");

            tenths.Add("20", "बीस");
            tenths.Add("21", "एक्काइस");
            tenths.Add("22", "बाइस");
            tenths.Add("23", "तेइस");
            tenths.Add("24", "चौबिस");
            tenths.Add("25", "पच्चीस");
            tenths.Add("26", "छब्बीस");
            tenths.Add("27", "सत्ताईस");
            tenths.Add("28", "अठ्ठाइस");
            tenths.Add("29", "उनन्तिस");

            tenths.Add("30", "तीस");
            tenths.Add("31", "एकतीस");
            tenths.Add("32", "बत्तीस");
            tenths.Add("33", "तेत्तीस");
            tenths.Add("34", "चौंतीस");
            tenths.Add("35", "पैंतीस");
            tenths.Add("36", "छत्तीस");
            tenths.Add("37", "सैंतीस");
            tenths.Add("38", "अठ्तीस");
            tenths.Add("39", "उनन्चालीस");

            tenths.Add("40", "चालीस");
            tenths.Add("41", "एकचालीस");
            tenths.Add("42", "बयालीस");
            tenths.Add("43", "त्रिचालीस");
            tenths.Add("44", "चवालीस");
            tenths.Add("45", "पैंतालिस");
            tenths.Add("46", "छयालीस");
            tenths.Add("47", "सतचालीस");
            tenths.Add("48", "अठ्चालीस");
            tenths.Add("49", "उनान्पचास");

            tenths.Add("50", "पचास");
            tenths.Add("51", "एकाउन्न");
            tenths.Add("52", "बाउन्न");
            tenths.Add("53", "त्रिपन्न");
            tenths.Add("54", "चौवन्न");
            tenths.Add("55", "पचपन्न");
            tenths.Add("56", "छपन्न");
            tenths.Add("57", "सन्ताउन्न");
            tenths.Add("58", "अन्ठाउन्न");
            tenths.Add("59", "उनान्साठी");

            tenths.Add("60", "साठी");
            tenths.Add("61", "एकसठ्ठी");
            tenths.Add("62", "बैसठ्ठी");
            tenths.Add("63", "त्रिसठ्ठी");
            tenths.Add("64", "चौंसठ्ठी");
            tenths.Add("65", "पैंसठ्ठी");
            tenths.Add("66", "छसठ्ठी");
            tenths.Add("67", "सतसठ्ठी");
            tenths.Add("68", "अठसठ्ठी");
            tenths.Add("69", "उनान्सत्तरी");
            tenths.Add("70", "सत्तरी");

            tenths.Add("71", "एकहत्तर");
            tenths.Add("72", "बहत्तर");
            tenths.Add("73", "त्रिहत्तर");
            tenths.Add("74", "चौहत्तर");
            tenths.Add("75", "पचहत्तर");
            tenths.Add("76", "छहत्तर");
            tenths.Add("77", "सतहत्तर");
            tenths.Add("78", "अठहत्तर");
            tenths.Add("79", "उनासी");

            tenths.Add("80", "असी");
            tenths.Add("81", "एकासी");
            tenths.Add("82", "बयासी");
            tenths.Add("83", "त्रियासी");
            tenths.Add("84", "चौरासी");
            tenths.Add("85", "पचासी");
            tenths.Add("86", "छयासी");
            tenths.Add("87", "सतासी");
            tenths.Add("88", "अठासी");
            tenths.Add("89", "उनान्नब्बे");

            tenths.Add("90", "नब्बे");
            tenths.Add("91", "एकाननब्बे");
            tenths.Add("92", "बयानब्बे");
            tenths.Add("93", "त्रियानब्बे");
            tenths.Add("94", "चौरानब्बे");
            tenths.Add("95", "पन्चान्नब्बे");
            tenths.Add("96", "छयानब्बे");
            tenths.Add("97", "सन्तानब्बे");
            tenths.Add("98", "अन्ठानब्बे");
            tenths.Add("99", "उनान्सय");
            // "सय"

            //// min digits (unit digits)
            //u.Add("100", "सय");
            //u.Add("1000", "हजार");
            //u.Add("100000", "लाख");
            //u.Add("10000000", "करोड");
            //u.Add("1000000000", "अर्ब");
            //u.Add("100000000000", "खर्ब");
            //u.Add("10000000000000", "नील");
            //u.Add("1000000000000000", "शंख");
            //u.Add("100000000000000000", "पद्म");

            // no need to end with measured value
            u.Add(0, ""); // "शुन्ना");
            u.Add(1, ""); //  "एक");
            u.Add(2, ""); //  "दश");
            u.Add(3, "सय");
            u.Add(4, "हजार");
            u.Add(5, "हजार");
            u.Add(6, "लाख");
            u.Add(7, "लाख");
            u.Add(8, "करोड");
            u.Add(9, "करोड");
            u.Add(10, "अर्ब");
            u.Add(11, "अर्ब");
            u.Add(12, "खर्ब");
            u.Add(13, "खर्ब");
            u.Add(14, "नील");
            u.Add(15, "नील");
            u.Add(16, "शंख");
            u.Add(17, "शंख");
            u.Add(18, "पद्म");
            u.Add(19, "पद्म");
        }

        public string read(string value, int digitsIndex)
        {
            string output = "";

            /**
             * No need to include zeroes in between.
             */
            if (persisting(value))
            {
                string valueText = tenths.FirstOrDefault(x=>x.Key == value).Value;
                if (value != "")
                {
                    output += string.Format("{0} {1}", valueText, u.FirstOrDefault(x => x.Key == digitsIndex).Value);
                }
            }

            return output;
        }

        private bool persisting(string value)
        {
            // @todo When whole digit is just 0, return zero
            // if zero is in between the number, no need
            return value != "" && value != "0" && value != "00" && null!=value;
        }
    }
}
