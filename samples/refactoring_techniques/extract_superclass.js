// fixes ../code_smells/refused_bequest.js
class Worker {
	constructor(name, salary) {
		this.name = name;
		this.salary = salary;
	}

	getDetails() {
		return `Name: ${this.name}, Salary: ${this.salary}`;
	}
}

class Manager extends Worker {
	manageTeam() {
		return `${this.name} is managing the team.`;
	}
}

class DeveloperFixed extends Worker {
	constructor(name, salary, programmingLanguage) {
		super(name, salary);
		this.programmingLanguage = programmingLanguage;
	}

	getDetails() {
		return `${super.getDetails()}, Programming Language: ${this.programmingLanguage}`;
	}
}
