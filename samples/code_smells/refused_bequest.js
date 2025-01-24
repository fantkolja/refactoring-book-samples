class Employee {
	constructor(name, salary) {
		this.name = name;
		this.salary = salary;
	}

	getDetails() {
		return `Name: ${this.name}, Salary: ${this.salary}`;
	}

	manageTeam() {
		return `${this.name} is managing the team.`;
	}
}

class Developer extends Employee {
	constructor(name, salary, programmingLanguage) {
		super(name, salary);
		this.programmingLanguage = programmingLanguage;
	}

	getDetails() {
		return `${super.getDetails()}, Programming Language: ${this.programmingLanguage}`;
	}

	// Developer class does not need manageTeam(), causing Refused Bequest
	manageTeam() {
		throw new Error('Developer cannot manage a team he is a slave!');
	}
}
