class Manager {

}
class Department {
	getManager() {
		return new Manager();
	}
}

// smelly
class Person {
	department = new Department();
	getDepartment() {
		return this.department
	}

	getManager() {
		return this.department.getManager();
	}
}

// smelly: client knows too much (inappropriate intimacy) about Person and Department
function main() {
	const person = new Person();
	const manager = person.getManager();
}
