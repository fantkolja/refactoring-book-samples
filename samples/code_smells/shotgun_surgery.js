// problem #1
class User {
	constructor(firstName, lastName, email) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.email = email;
	}
}

class UserService {
	saveToDatabase(user) {
		const formattedUser = `${user.firstName} ${user.lastName}, Email: ${user.email}`;
		console.log("Saving to database:", formattedUser);
		// Логіка збереження в базу даних
	}
}

class NotificationService {
	sendWelcomeEmail(user) {
		console.log(`Sending email to: ${user.email}`);
	}
}

class ProfilePage {
	displayUser(user) {
		console.log(`User Profile: ${user.firstName} ${user.lastName}, Email: ${user.email}`);
	}
}


// solution
class User {
	constructor(firstName, lastName, email, phoneNumber) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.email = email;
		this.phoneNumber = phoneNumber;
	}

	getFormattedDetails() {
		return `${this.firstName} ${this.lastName}, Email: ${this.email}, Phone: ${this.phoneNumber}`;
	}
}

class UserService {
	saveToDatabase(user) {
		console.log("Saving to database:", user.getFormattedDetails());
		// Логіка збереження в базу даних
	}
}

class NotificationService {
	sendWelcomeEmail(user) {
		console.log(`Sending email to: ${user.email}`);
	}
}

class ProfilePage {
	displayUser(user) {
		console.log(`User Profile: ${user.getFormattedDetails()}`);
	}
}




// problem #2
class Order {
	constructor(totalPrice) {
		this.totalPrice = totalPrice;
	}
}

class DiscountService {
	applyDiscount(order) {
		if (order.totalPrice > 100) {
			return order.totalPrice * 0.9;
		} else {
			return order.totalPrice;
		}
	}
}

class InvoiceService {
	generateInvoice(order) {
		const discountedPrice = order.totalPrice > 100 ? order.totalPrice * 0.9 : order.totalPrice;
		console.log(`Invoice total: $${discountedPrice}`);
	}
}

class ReportingService {
	generateReport(order) {
		const discountedPrice = order.totalPrice > 100 ? order.totalPrice * 0.9 : order.totalPrice;
		console.log(`Order report: Total price after discount: $${discountedPrice}`);
	}
}


// solution
class Order {
	constructor(totalPrice) {
		this.totalPrice = totalPrice;
	}

	getDiscountedPrice() {
		return this.totalPrice > 100 ? this.totalPrice * 0.9 : this.totalPrice;
	}
}

class DiscountService {
	applyDiscount(order) {
		return order.getDiscountedPrice();
	}
}

class InvoiceService {
	generateInvoice(order) {
		console.log(`Invoice total: $${order.getDiscountedPrice()}`);
	}
}

class ReportingService {
	generateReport(order) {
		console.log(`Order report: Total price after discount: $${order.getDiscountedPrice()}`);
	}
}
