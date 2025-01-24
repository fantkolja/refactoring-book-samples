// for ../code_smells/long_method.js


class OrderCalculator {
	constructor(order) {
		this.order = order;
	}

	calculateTotal() {
		let total = this.calculateBaseTotal();
		total = this.applyBulkDiscounts(total);
		total = this.applyCustomerDiscounts(total);
		total = this.applyTaxes(total);
		total = this.applyShippingFees(total);
		return total;
	}

	calculateBaseTotal() {
		return this.order.items.reduce((sum, item) => sum + item.price * item.quantity, 0);
	}

	applyBulkDiscounts(amount) {
		return this.order.items.length > 5 ? amount * 0.95 : amount;
	}

	applyCustomerDiscounts(amount) {
		return this.order.customer.isPremium ? amount * 0.9 : amount;
	}

	applyTaxes(amount) {
		return amount * 1.07;
	}

	applyShippingFees(amount) {
		return amount < 100 ? amount + 10 : amount;
	}
}

class Order {
	constructor(items, customer) {
		this.items = items;
		this.customer = customer;
	}

	getTotal() {
		return new OrderCalculator(this).calculateTotal();
	}
}
