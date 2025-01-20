class Store {
	getSeasonalDiscount() {
		//...
	}

	getFees() {
		//...
	}

	// smelly
	discountedPrice(basePrice, seasonDiscount, fees) {
		// ...
	}
	getFinalPrice(quantity, itemPrice) {
		let basePrice = quantity * itemPrice;
		const seasonDiscount = this.getSeasonalDiscount();
		const fees = this.getFees();
		const finalPrice = this.discountedPrice(basePrice, seasonDiscount, fees);
	}
}



// Replace Parameter with Method Call https://refactoring.guru/uk/replace-parameter-with-method-call
class NotSoSmellyStore {
	getSeasonalDiscount() {
		//...
	}

	getFees() {
		//...
	}

	// not so smelly
	discountedPrice(basePrice) {
		const seasonDiscount = this.getSeasonalDiscount();
		const fees = this.getFees();
		return 1;
	}
	getFinalPrice(quantity, itemPrice) {
		let basePrice = quantity * itemPrice;
		const finalPrice = this.discountedPrice(basePrice);
	}
}
