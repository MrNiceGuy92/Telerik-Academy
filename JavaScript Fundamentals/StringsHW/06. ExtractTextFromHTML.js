/*
 Problem 6. Extract text from HTML

 Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.
 */

// Use Node.js to test solution
function extractText(input) {
    var firstSymbol = '<',
        secondSymbol = '>',
        indexOfFirstSymbol = input.indexOf(firstSymbol),
        indexOfSecondSymbol = input.indexOf(secondSymbol, indexOfFirstSymbol),
        substring = '';

    while (indexOfFirstSymbol >= 0 && indexOfSecondSymbol >= 0) {
        substring = input.substring(indexOfFirstSymbol, indexOfSecondSymbol + 1);
        input = input.replace(substring, '');

        indexOfFirstSymbol = input.indexOf(firstSymbol, indexOfFirstSymbol);
        indexOfSecondSymbol = input.indexOf(secondSymbol, indexOfSecondSymbol - 1);
    }

    return input;
}

// Example from problem
var input = '<html>' +
    '<head>' +
    '<title>Sample site</title>' +
    '</head>' +
    '<body>' +
    '<div>text' +
    '<div>more text</div>' +
    'and more...' +
    '</div>' +
    'in body' +
    '</body>' +
    '</html>';

console.log(extractText(input));