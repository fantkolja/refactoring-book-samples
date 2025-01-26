// smelly
function DoStuff(foo)
{
	if (foo == null) return;

	const localParam = 'local';

	if (foo > 3) {
		return 1;
	}

	console.log(foo);

	return 0;
}

















// smelly
function isSmellyIfCorrect(param1, param2, param3) {
	let correct = false;
	if (param1 !== param2) {
		if (param1 === (param3 * 2)) {
			if (param2 === (param3 / 3)) {
				correct = true;
			} else {
				console.error('IS NOT ONE THIRD');
			}
		} else {
			console.error('IS NOT DOUBLE');
		}
	} else {
		console.error('IS EQUAL');
	}
	return correct;
}




// not smelly???
function isMultipleReturnCorrect(param1, param2, param3) {
	if (param1 === param2) {
		console.error('IS EQUAL');
		return false;
	}

	if (param1 !== (param3 * 2)) {
		console.error('IS NOT DOUBLE');
		return false;
	}

	if (param2 !== (param3 / 3)) {
		console.error('IS NOT ONE THIRD');
		return false;
	}

	return true;
}










// a little bit better
// function isEqual(param1, param2) {
// 	const equal = param1 === param2;
// 	if (equal) {
// 		console.error('IS EQUAL');
// 	}
// 	return equal;
// }
//
// function isDouble(param1, param3) {
// 	const double = param1 !== (param3 * 2);
// 	if (!double) {
// 		console.error('IS NOT DOUBLE');
// 	}
// 	return double;
// }
//
// function isOneThird(param2, param3) {
// 	const oneThird = param2 === (param3 / 3);
// 	if (!oneThird) {
// 		console.error('IS NOT ONE THIRD');
// 	}
// 	return oneThird;
// }
//
// function isCorrect(param1, param2, param3) {
// 	return !isEqual(param1, param2)
// 		&& isDouble(param1, param3)
// 		&& isOneThird(param2, param3);
// }








// even better
function isEqualError(param1, param2) {
	const equal = param1 === param2;
	return equal ? 'IS EQUAL' : false;
}

function isNotDoubleError(param1, param3) {
	const double = param1 !== (param3 * 2);
	return !double ? 'IS NOT DOUBLE' : false;
}

function isNotOneThirdError(param2, param3) {
	const oneThird = param2 === (param3 / 3);
	return !oneThird ? 'IS NOT ONE THIRD' : false;
}

function isCorrect(param1, param2, param3) {
	const error = isEqualError(param1, param2)
		|| isNotDoubleError(param1, param3)
		|| isNotOneThirdError(param2, param3);
	if (error) {
		console.error(error);
	}
	return !error;
}
