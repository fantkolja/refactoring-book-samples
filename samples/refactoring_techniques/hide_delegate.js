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
}

// smelly: client knows too much (inappropriate intimacy) about Person and Department
function main() {
	const person = new Person();
	const department = person.getDepartment();
	const manager = department.getManager();
}








// class Person {
// 	department = new Department();
// 	getDepartment() {
// 		return this.department
// 	}
//
// 	getManager() {
// 		return this.department.getManager();
// 	}
// }
// function main() {
// 	const person = new Person();
// 	const manager = person.getManager();
// }
