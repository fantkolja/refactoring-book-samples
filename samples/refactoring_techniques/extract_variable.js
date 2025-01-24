// smelly
function doSomethingSmelly() {
	if ((platform.toUpperCase().indexOf('MAC') > -1) &&
		(browser.toUpperCase().indexOf('IE') > -1) &&
		wasInitialized() && resize > 0) {
		// do something
	}
}


// not so smelly
function doSomethingNonSmelly() {
	const isMacOs = platform.toUpperCase().indexOf("MAC") > -1;
	const isIE = browser.toUpperCase().indexOf("IE") > -1;
	const wasResized = resize > 0;

	if (isMacOs && isIE && wasInitialized() && wasResized) {
		// do something
	}
}
