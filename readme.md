# converter.cs

Convert a number into Devnagari Words upto 19 digits.


## Limitation

Long/Double is not enough, use string numbers.


## Namespace

	using anytizer.converter.numbers.values;


## Usage

	NumberConverter nc = new NumberConverter();
	string value = nc.ToDevnagari(87654321);

You should expect: __आठ करोड छहत्तर लाख चौवन्न हजार तीन सय एक्काइस__.
