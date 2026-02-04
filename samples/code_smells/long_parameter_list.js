class Store {
	getSeasonalDiscount() {
		//...
	}
	
	getCustomerDiscount() {
		//...
	}

	getFees() {
		//...
	}

	// smelly
	discountedPrice(basePrice, customerDiscount, seasonDiscount, fees) {
		// ...
	}
	getFinalPrice(quantity, itemPrice) {
		const basePrice = quantity * itemPrice;
		const customerDiscount = this.getCustomerDiscount();
		const seasonDiscount = this.getSeasonalDiscount();
		const fees = this.getFees();
		const finalPrice = this.discountedPrice(basePrice, customerDiscount, seasonDiscount, fees);
	}
}
