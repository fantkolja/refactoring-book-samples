// 1.
// magic numbers
const productCategory = "laptop";

if (chosenCategory === "laptop") {}

if (userInput === "laptop") {}

if (screenWidth < 600) {}

// 2.
// constants in global scope
const LAPTOP_CATEGORY = "laptop"
// ...

// constants as static properties
class CategoryHandler {
	LAPTOP_CATEGORY = "laptop";
	TABLET_CATEGORY = "tablet";
	// ...
}

class Resizer {
	SMALL_SCREEN_WIDTH = 600;
	MEDIUM_SCREEN_WIDTH = 600;
}


// enum
const CATEGORY = {
	LAPTOP: "laptop",
	TABLET: "tablet",
};


// 3.
// smelly object-like primitive
const wifePhoneNumber = "+380638976512";
const friendPhoneNumber = "+380955671274";

// not so smelly object
// const wifePhoneNumber = new PhoneNumber("+38", "0638976512");
// const friendPhoneNumber = new PhoneNumber("+38", "0955671274");


class PhoneNumber
{
	#countryCode;
	#number;

	constructor(countryCode, number)
	{
		this.#countryCode = countryCode;
		this.#number = number;
	}

	toString() {
		return `${this.#countryCode}${this.#number}`;
	}
}
