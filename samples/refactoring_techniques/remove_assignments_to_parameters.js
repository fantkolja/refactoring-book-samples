// smelly
function smellyDiscount(inputVal, quantity) {
	if (quantity > 50) {
		inputVal -= 2;
	}
	// ...
}




// cured with local variable
function discount(inputVal, quantity) {
	let result = inputVal;
	if (quantity > 50) {
		result -= 2;
	}
	// ...
}




// cured with return
function discountV2(inputVal, quantity) {
	return quantity > 50 ? inputVal - 2 : inputVal;
}
