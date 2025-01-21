// smelly
class SmellyPhone {
	constructor(unformattedNumber) {
		this.unformattedNumber = unformattedNumber;
	}

	getAreaCode() {
		return this.unformattedNumber.substring(0, 3);
	}

	getPrefix() {
		return this.unformattedNumber.substring(3, 6);
	}

	getNumber() {
		return this.unformattedNumber.substring(6, 10);
	}
}

class SmellyCustomer {
	constructor(mobilePhone) {
		this.mobilePhone = mobilePhone;
	}

	getMobilePhoneNumber() {
		return `(${this.mobilePhone.getAreaCode()}) ${this.mobilePhone.getPrefix()}-${this.mobilePhone.getNumber()}`;
	}
}







// not so smelly
class Phone {
	constructor(unformattedNumber) {
		this.unformattedNumber = unformattedNumber;
	}

	getAreaCode() {
		return this.unformattedNumber.slice(0, 3);
	}

	getPrefix() {
		return this.unformattedNumber.slice(3, 6);
	}

	getNumber() {
		return this.unformattedNumber.slice(6, 10);
	}

	getFormattedNumber() {
		return `(${this.getAreaCode()}) ${this.getPrefix()}-${this.getNumber()}`;
	}
}

class Customer {
	constructor(mobilePhone) {
		this.mobilePhone = mobilePhone;
	}

	getMobilePhoneNumber() {
		return this.mobilePhone.getFormattedNumber();
	}
}
