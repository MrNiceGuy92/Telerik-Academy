/*Problem 4. Third digit
Write an expression that checks for given integer if its third digit (right-to-left) is 7.
*/

// I use Node.js to test my solutions

function checkIfSeven (someNum) {

    if (someNum - (someNum | 0) !== 0) {
        return 'Not a number.';
    }
    if (Math.floor(someNum / 100) % 10 === 7) {
        var result = 'The third digit from right to left is 7.';
        return result;
    }
    else {
        var result = 'The third digit from right to left is NOT 7.';
        return result;
    }
}

// Examples from problem
console.log(checkIfSeven(5));
console.log(checkIfSeven(701));
console.log(checkIfSeven(1732));
console.log(checkIfSeven(9703));
console.log(checkIfSeven(877));
console.log(checkIfSeven(777877));
console.log(checkIfSeven(9999799));
console.log(checkIfSeven('Test'));