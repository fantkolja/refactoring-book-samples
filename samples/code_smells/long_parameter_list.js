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
