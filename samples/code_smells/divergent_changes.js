// smelly: any change in formatting logic would require changes in several methods

class UserService {
	constructor(user) {
		this.user = user;
	}

	// Форматування перед збереженням у базу даних
	saveToDatabase() {
		const formattedUser = `${this.user.firstName} ${this.user.lastName}, Age: ${this.user.age}`;
		console.log("Saving to database:", formattedUser);
		// Логіка збереження в базу даних
	}

	// Форматування перед збереженням у локальне сховище
	saveToLocalStorage() {
		const formattedUser = `${this.user.firstName} ${this.user.lastName}, Age: ${this.user.age}`;
		console.log("Saving to local storage:", formattedUser);
		localStorage.setItem("user", formattedUser);
	}

	// Форматування перед відображенням у UI
	displayUser() {
		const formattedUser = `${this.user.firstName} ${this.user.lastName}, Age: ${this.user.age}`;
		console.log("Displaying user:", formattedUser);
		// Логіка відображення користувача
	}
}





// also smelly
class User {
	role = 0;

	createTeam() {
		if (this.role === 0) {
			// creating team
		} else if (this.role === 1) {
			// prompting to create a premium subscription
		} else {
			throw new Error();
		}
	}

	orderProduct() {
		if (this.role === 0) {
			// ordering any product
		} else if (this.role === 1) {
			// order from reduced list
		} else {
			throw new Error();
		}
	}
}
