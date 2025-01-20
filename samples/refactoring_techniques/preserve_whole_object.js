// smelly
function calculateTaxes(taxer) {
	const fee = taxer.getFee();
	const period = taxer.getPeriod();
	const payerCategory = taxer.getPayerCategory();
	return taxCalculator(fee, period, payerCategory);
}

// not so smelly
function calculateTaxesInASmarterWay(taxer) {
	const fee = taxer.getFee();
	const period = taxer.getPeriod();
	const payerCategory = taxer.getPayerCategory();
	return taxCalculator(taxer);
}
