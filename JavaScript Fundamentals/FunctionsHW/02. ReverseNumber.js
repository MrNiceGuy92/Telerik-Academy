/*
Problem 2. Reverse number

Write a function that reverses the digits of given decimal number.
*/

// Use Node.js to test solution
function reverse(someNumber) {
    var numAsStr = someNumber.toString(),
        result = '';

    for (var i = numAsStr.length; i > 0; i--) {
        result += numAsStr[i-1];
    }

    result = parseFloat(result);
    return result;
}

// Example from problem
console.log(reverse(256));
console.log(reverse(123.45));