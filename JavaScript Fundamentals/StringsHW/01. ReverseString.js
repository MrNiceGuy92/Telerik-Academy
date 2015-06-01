/*
Problem 1. Reverse string

Write a JavaScript function that reverses a string and returns it.
*/

// Use Node.js to test solution
function reverse(someString) {
    var reversedString = '',
        len,
        i;

    for (i = 0, len = someString.length; i < len; i+=1) {
         reversedString += someString[len - i -1];
    }

    return reversedString;
}

// Example from problem
var someString ='sample';

console.log(someString);
console.log(reverse(someString));