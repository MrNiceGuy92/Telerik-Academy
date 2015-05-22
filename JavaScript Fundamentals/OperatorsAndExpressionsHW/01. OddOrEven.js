/*
Problem 1. Odd or Even
Write an expression that checks if given integer is odd or even.
*/

// I use Node.js to test my solutions

function oddOrEven(someNumber) {
    if (someNumber - (someNumber | 0) !== 0) {
        return 'Not a number.';
    }
    else if (someNumber % 2 === 0 && someNumber !==0) {
        return 'The number is even.';
    }
    else if (someNumber === 0 || (someNumber % 2 !== 0)) {
        return 'The number is odd.';
    }
}

// Examples from problem
console.log(oddOrEven(3));
console.log(oddOrEven(2));
console.log(oddOrEven(-2));
console.log(oddOrEven('asd'));
console.log(oddOrEven(-1));
console.log(oddOrEven(0));