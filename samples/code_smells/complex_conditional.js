function determineLoanEligibility(age, income, creditScore, existingDebt, employmentStatus) {
	if (age >= 18 && age < 65) {
		if (employmentStatus === "employed" || employmentStatus === "self-employed") {
			if (creditScore >= 700) {
				if (existingDebt < income * 0.4) {
					return "Loan Approved: Excellent conditions";
				} else {
					return "Loan Approved: But consider reducing existing debt";
				}
			} else {
				if (creditScore >= 600) {
					if (existingDebt < income * 0.3) {
						return "Loan Approved: Higher interest rate applicable";
					} else {
						return "Loan Denied: High debt with low credit score";
					}
				} else {
					return "Loan Denied: Credit score too low";
				}
			}
		} else {
			return "Loan Denied: Employment status not eligible";
		}
	} else {
		return "Loan Denied: Applicant must be at least 18 years old but less than 65";
	}
}
