/*
Problem 1. Exchange if greater

Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
As a result print the values a and b, separated by a space.
*/

// I use Node.js to test my solutions

function biggerNum(firstNum, secondNum) {
    var max = secondNum;

    if (firstNum > secondNum) {
        max = firstNum;
        return secondNum + ' ' + max;
    }
    else {
        return firstNum + ' ' + secondNum;
    }
}

// Examples from problem
console.log(biggerNum(5,2));
console.log(biggerNum(3,4));
console.log(biggerNum(5.5,4.5));