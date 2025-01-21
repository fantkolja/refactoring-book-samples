class User {
	constructor(name, email) {
		this.name = name;
		this.email = email;
	}

	getDisplayName() {
		return this.name;
	}

	getEmail() {
		return this.email;
	}

	isRegistered() {
		return true;
	}
}

// smelly
class SmellyUserFactory {
	static getUser(userId) {
		switch (userId) {
			case 1:
				return new User("Alice", "alice@example.com");
			case 2:
				return new User("Bob", "bob@example.com");
			default:
				return null;
		}
	}
}

function consumeSmellyUser() {
	const user = SmellyUserFactory.getUser(3);  // User ID 3 does not exist, so null is returned
	if (user) {
		console.log(user.getDisplayName());
	} else {
		console.log('Guest');
	}

	if (user) {
		console.log(user.getEmail());
	} else {
		console.log('No Email Available');
	}

	if (user) {
		console.log(user.isRegistered());
	} else {
		console.log(false);
	}
}




// not so smelly
class NullUser {
	isNull() {
		return true;
	}
	getDisplayName() {
		return "Guest";
	}

	getEmail() {
		return "No Email Available";
	}

	isRegistered() {
		return false;
	}
}


class UserFactory {
	static getUser(userId) {
		switch (userId) {
			case 1:
				return new User("Alice", "alice@example.com");
			case 2:
				return new User("Bob", "bob@example.com");
			default:
				return new NullUser();
		}
	}
}

// Example Usage
function consumeNullUser() {
	const user = UserFactory.getUser(3);  // User ID 3 does not exist, so NullUser is returned
	console.log(user.getDisplayName());  // Output: "Guest"
	console.log(user.getEmail());        // Output: "No Email Available"
	console.log(user.isRegistered());    // Output: false
}
