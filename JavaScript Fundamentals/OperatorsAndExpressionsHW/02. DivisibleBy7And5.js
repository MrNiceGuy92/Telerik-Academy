/*
Problem 2. Divisible by 7 and 5
Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
*/

// I use Node.js to test my solutions

function divBy7And5 (someNum) {
    var bool = false;

    if (someNum - (someNum | 0) !== 0) {
        return 'Not a number.';
    }
    else if ((someNum % 5 === 0) && (someNum % 7 === 0)) {
        bool = true;
        return 'Can the number be divisible by 5 and 7 without remainder?:' + bool;
    }
    else {
        return 'Can the number be divisible by 5 and 7 without remainder?:' + bool;
    }
}

// Examples from problem
console.log(divBy7And5(0));
console.log(divBy7And5(3));
console.log(divBy7And5(5));
console.log(divBy7And5(7));
console.log(divBy7And5(35));
console.log(divBy7And5(140));