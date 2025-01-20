// smelly
class SmellyTaxCalculator {
	static SOCIAL_FEE = 2600;
	calculateTax(income, individualEntrepreneurCategory) {
		switch (individualEntrepreneurCategory) {
			case 1:
				return SmellyTaxCalculator.SOCIAL_FEE * 3;
			case 2:
				return SmellyTaxCalculator.SOCIAL_FEE + (income * 0.05);
			case 3:
				return income * 0.05;
			default:
				throw new Error(`There is no individual entrepreneur category ${individualEntrepreneurCategory}`);
		}
	}
}

// const ieCategory = promptUser("Enter your category (1, 2, 3)");
//
// const calculator = new SmellyTaxCalculator();
// calculator.calculateTax(1000, ieCategory);


// not so smelly
class TaxCalculator {
	static SOCIAL_FEE = 2600;
	calculateTax(income) {
		throw new Error("There is no implementation for this individual entrepreneur category");
	}
}

class IE1TaxCalculator extends TaxCalculator {
	static CATEGORY = 1;
	calculateTax(income) {
		return TaxCalculator.SOCIAL_FEE * 3;
	}
}

class IE2TaxCalculator extends TaxCalculator {
	static CATEGORY = 2;
	calculateTax(income) {
		return SmellyTaxCalculator.SOCIAL_FEE + (income * 0.05);
	}
}


class IE3TaxCalculator extends TaxCalculator {
	static CATEGORY = 3;
	calculateTax(income) {
		return income * 0.05;
	}
}




// BUT: we still need the switch statement
const ieCategory = promptUser("Enter your category (1, 2, 3)");

const calculator = new SmellyTaxCalculator();
calculator.calculateTax(1000, ieCategory);

class IECalculatorFactory {
	createCalculator(ieCategory) {
		switch (ieCategory) {
			case IE1TaxCalculator.CATEGORY:
				return new IE1TaxCalculator();
			case IE2TaxCalculator.CATEGORY:
				return new IE2TaxCalculator();
			case IE3TaxCalculator.CATEGORY:
				return new IE3TaxCalculator();
			default:
				throw new Error(`There is no individual entrepreneur category ${individualEntrepreneurCategory}`);
		}
	}
}

