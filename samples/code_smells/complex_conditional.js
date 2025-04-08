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







function determineLoanEligibility(age, income, creditScore, existingDebt, employmentStatus) {
	const isOfEligibleAge = age >= 18 && age < 65;
	const isEmployed = employmentStatus === "employed"
	 || employmentStatus === "self-employed";
	const hasExcellentCredit = creditScore >= 700;
	const hasGoodCredit = creditScore >= 600 && creditScore < 700;
	const lowDebtRatioForExcellent = existingDebt < income * 0.4;
	const lowDebtRatioForGood = existingDebt < income * 0.3;

	if (!isOfEligibleAge) {
		return "Loan Denied: Applicant must be at least 18 years old but less than 65";
	}

	if (!isEmployed) {
		return "Loan Denied: Employment status not eligible";
	}

	if (hasExcellentCredit) {
		return evaluateExcellentCredit(lowDebtRatioForExcellent);
	} else if (hasGoodCredit) {
		return evaluateGoodCredit(lowDebtRatioForGood);
	} else {
		return "Loan Denied: Credit score too low";
	}
}

function evaluateExcellentCredit(hasLowDebt) {
	if (hasLowDebt) {
		return "Loan Approved: Excellent conditions";
	} else {
		return "Loan Approved: But consider reducing existing debt";
	}
}

function evaluateGoodCredit(hasLowDebt) {
	if (hasLowDebt) {
		return "Loan Approved: Higher interest rate applicable";
	} else {
		return "Loan Denied: High debt with low credit score";
	}
}
