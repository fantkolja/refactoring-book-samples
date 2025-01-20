// smelly
class SmellyTaxer {
	getTaxPeriod(from, to) {}
	calculateTaxesForPeriod(from, to) {}
}



// not so smelly
class NotSoSmellyTaxer {
	getTaxPeriod(datePeriod) {}
	calculateTaxesForPeriod(datePeriod) {}
}

class DatePeriod {
	from;
	to;
}
