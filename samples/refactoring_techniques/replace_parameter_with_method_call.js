// for long_parameter_list.js
class NotSoSmellyStore {
	getSeasonalDiscount() {
		//...
	}
		
	getCustomerDiscount() {
		//...
	}

	getFees() {
		//...
	}

	// not so smelly
	discountedPrice(basePrice) {
		const seasonDiscount = this.getSeasonalDiscount();
		const customerDiscount = this.getCustomerDiscount();
		const fees = this.getFees();
		return 1; // Повернення обчисленої ціни
	}
	getFinalPrice(quantity, itemPrice) {
		const basePrice = quantity * itemPrice;
		const finalPrice = this.discountedPrice(basePrice);
	}
}
