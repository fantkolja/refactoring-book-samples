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

	// Developer не повинен мати метод manageTeam, але змушений його перевизначати
	manageTeam() {
		throw new Error('Developer cannot manage a team he is a slave!');
	}
}












// class Employee {
// 	constructor(name, salary) {
// 		this.name = name;
// 		this.salary = salary;
// 	}

// 	getDetails() {
// 		return `Name: ${this.name}, Salary: ${this.salary}`;
// 	}
// }

// class Manager extends Employee {
// 	manageTeam() {
// 		return `${this.name} is managing the team.`;
// 	}
// }

// class Developer {
// 	constructor(employee, programmingLanguage) {
// 		this.employee = employee;
// 		this.programmingLanguage = programmingLanguage;
// 	}

// 	getDetails() {
// 		return `${this.employee.getDetails()}, Programming Language: ${this.programmingLanguage}`;
// 	}
// }