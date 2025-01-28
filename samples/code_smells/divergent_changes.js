// smelly: any change in formatting logic would require changes in several methods

class UserService {
	constructor(user) {
		this.user = user;
	}

	// Formats user data before saving to a database
	saveToDatabase() {
		const formattedUser = `${this.user.firstName} ${this.user.lastName}, Age: ${this.user.age}`;
		console.log("Saving to database:", formattedUser);
		// Database save logic here
	}

	// Formats user data before saving to local storage
	saveToLocalStorage() {
		const formattedUser = `${this.user.firstName} ${this.user.lastName}, Age: ${this.user.age}`;
		console.log("Saving to local storage:", formattedUser);
		localStorage.setItem("user", formattedUser);
	}

	// Formats user data before displaying on UI
	displayUser() {
		const formattedUser = `${this.user.firstName} ${this.user.lastName}, Age: ${this.user.age}`;
		console.log("Displaying user:", formattedUser);
		// UI rendering logic here
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
