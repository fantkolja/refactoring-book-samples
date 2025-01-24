class ReportGenerator {
	constructor(data) {
		this.data = data;
		this.tempSummary = null; // Temporary field
	}

	generateReport() {
		this.tempSummary = this.calculateSummary();
		const report = `Report Summary: ${this.tempSummary}`;
		this.tempSummary = null; // Reset temporary field
		return report;
	}

	calculateSummary() {
		return this.data.reduce((sum, item) => sum + item.value, 0);
	}
}

// Example usage
const data = [
	{ value: 100 },
	{ value: 200 },
	{ value: 50 }
];

const reportGenerator = new ReportGenerator(data);
console.log(reportGenerator.generateReport());
