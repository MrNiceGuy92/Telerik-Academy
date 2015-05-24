/*
Problem 2. Multiplication Sign
Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    Use a sequence of if operators.
*/

// I use Node.js to test my solutions

function multiplicationSign(numbers) {
    var counter = 0;

    for (var index = 0; index < numbers.length; index+=1) {
        if (numbers[index] == 0) {
            return 'Result: 0';
        }
        else if (numbers[index] < 0) {
            counter+=1;
        }
    }

    if (counter === 0 || counter === 2) {
        return 'Result: +.'
    }
    else {
        return 'Result: -.';
    }
}

// Examples from problem
console.log(multiplicationSign([5, 2, 2]));
console.log(multiplicationSign([-2, -2, 1]));
console.log(multiplicationSign([-2, 4, 3]));
console.log(multiplicationSign([0, -2.5, 4]));
console.log(multiplicationSign([-1, -0.5, -5.1]));