// smelly
class SmellyAddress {
	constructor(street, city, zipCode) {
		this.street = street;
		this.city = city;
		this.zipCode = zipCode;
	}
}

class SmellyUser {
	constructor(name, address) {
		this.name = name;
		this.address = address;
	}

	printAddress() {
		// Inappropriate intimacy:
		console.log(`${this.name} lives at ${this.address.street}, ${this.address.city}, ${this.address.zipCode}`);
	}
}




// not so smelly
class Address {
	constructor(street, city, zipCode) {
		this.street = street;
		this.city = city;
		this.zipCode = zipCode;
	}

	getFullAddress() {
		return `${this.street}, ${this.city}, ${this.zipCode}`;
	}
}

class User {
	constructor(name, address) {
		this.name = name;
		this.address = address;
	}

	printAddress() {
		// Inappropriate intimacy:
		console.log(`${this.name} lives at ${this.address.getFullAddress()}`);
	}
}
