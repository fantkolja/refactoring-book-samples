function processOrder(order) {
	if (!order) {
		return "Invalid order";
	}

	if (!order.items || order.items.length === 0) {
		return "Order has no items";
	}

	if (order.status === "cancelled") {
		return "Order is cancelled";
	}

	let total = 0;
	for (const item of order.items) {
		if (!item.price || item.price < 0) {
			return "Invalid item price";
		}
		total += item.price * (item.quantity || 1);
	}

	if (total === 0) {
		return "Total price cannot be zero";
	}

	if (order.customer && order.customer.isPremium) {
		total *= 0.9; // Apply 10% discount
	}

	return `Order processed. Total: $${total.toFixed(2)}`;
}
