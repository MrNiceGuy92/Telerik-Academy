/*
Problem 2. Reverse number

Write a function that reverses the digits of given decimal number.
*/

// Use Node.js to test solution
function reverse(someNumber) {
    var numberAsString = someNumber.toString(),
        result = '',
        i,
        len;

    for (i = len, len = numberAsString.length; i > 0; i-=1) {
        result += numberAsString[i-1];
    }

    result = parseFloat(result);
    return result;
}

// Example from problem
console.log(reverse(256));
console.log(reverse(123.45));