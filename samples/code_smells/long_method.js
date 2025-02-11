class Order {
	constructor(items, customer) {
		this.items = items;
		this.customer = customer;
	}

	getTotal() {
		let total = 0;
		for (const item of this.items) {
			total += item.price * item.quantity; // get base price
		}

		if (this.items.length > 5) {
			total *= 0.95; // 5% discount for bulk orders
		}

		if (this.customer.isPremium) {
			total *= 0.9; // 10% discount for premium customers
		}

		total *= 1.07; // 7% sales tax

		if (total < 100) {
			total += 10; // $10 shipping fee for orders under $100
		}

		return total;
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
