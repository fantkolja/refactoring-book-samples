// fixing ../code_smells/long_method.js
class Order {
	constructor(items, customer) {
		this.items = items;
		this.customer = customer;
	}

	getTotal() {
		let total = 0;
		total = this.getItemsTotal(total);
		total = this.applyBulkDiscount(total);
		total = this.getPremiumDiscount(total);
		total = this.applySalesTax(total);
		total = this.applyShippingFee(total);
		return total;
	}

	applyShippingFee(total) {
		return total < 100 ? total + 10 : total;
	}

	applySalesTax(total) {
		return total * 1.07;
	}

	getItemsTotal(total) {
		return this.items.reduce((sum, item) => sum + (item.price * item.quantity), 0);
	}

	applyBulkDiscount(total) {
		return this.items.length > 5 ? total *= 0.95 : total;
	}

	getPremiumDiscount(total) {
		return this.customer.isPremium ? total * 0.9 : total;
	}
}

// const order = new Order(
// 	[
// 		{ price: 100, quantity: 2 },
// 		{ price: 50, quantity: 1 }
// 	],
// 	{ isPremium: true }
// );
//
// console.log(order.getTotal());
