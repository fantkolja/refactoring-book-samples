class Processor {
	constructor(brand, speed, cores) {
		this.brand = brand;
		this.speed = speed;
		this.cores = cores;
	}

	getProcessorDetails() {
		return `${this.brand} ${this.speed}GHz, ${this.cores} cores`;
	}

	getCoreCount() {
		return this.cores;
	}

	startProcessing() {
		return "Processing started";
	}
}

class Computer {
	constructor(model, processor) {
		this.model = model;
		this.processor = processor;
	}

	getComputerProcessorDetails() {
		// Middle Man: Delegating Processor method instead of direct access
		return this.processor.getProcessorDetails();
	}

	getComputerCoreCount() {
		return this.processor.getCoreCount();
	}

	startComputerProcessing() {
		return this.processor.startProcessing();
	}
}
