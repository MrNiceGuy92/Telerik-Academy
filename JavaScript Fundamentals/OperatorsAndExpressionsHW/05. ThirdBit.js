/*
Problem 5. Third bit
Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
*/

// I use Node.js to test my solutions

function getBit(position, number) {
    var mask = 1<< position,
        numberAndMask = number & mask,
        bit = numberAndMask >> position;
    return 'The bit at 3rd position is: ' + bit;
}

// Examples from problem
console.log(getBit(3, 5));
console.log(getBit(3, 8));
console.log(getBit(3, 0));
console.log(getBit(3, 15));
console.log(getBit(3, 5343));
console.log(getBit(3, 62241));