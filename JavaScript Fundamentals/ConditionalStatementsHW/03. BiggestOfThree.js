/*
Problem 3. The biggest of Three

Write a script that finds the biggest of three numbers.
Use nested if statements.
*/

// Use Node.js to test my solutions

function findLargestNum(firstNum, secondNum, thirdNum) {
    var max = firstNum;
    if (secondNum > firstNum) {
        if (secondNum > thirdNum) {
            max = secondNum;
        }
        else {
            max = thirdNum;
        }
    }

    if (thirdNum > firstNum) {
        if (thirdNum > secondNum) {
            max = thirdNum;
        }
        else {
            max = secondNum;
        }
    }

    return 'Biggest number: ' + max;
}

// Examples from problem

console.log(findLargestNum(5, 2, 2));
console.log(findLargestNum(-2, -2, 1));
console.log(findLargestNum(-2, 4, 3));
console.log(findLargestNum(0, -2.5, 5));
console.log(findLargestNum(-0.1, -0.5, -1.1));