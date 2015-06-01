/*
Problem 2. Correct brackets

Write a JavaScript function to check if in a given expression the brackets are put correctly.
*/

// Use Node.js to test solution
function checkBrackets(input) {
    var i,
        len,
        counter = 0,
        openingBracket = '(',
        closingBracket = ')';

    for (i = 0, len = input.length; i < len; i+=1) {
        if (input[i] === openingBracket) {
            counter +=1;
        }
        else if (input[i] === closingBracket) {
            counter -=1;
        }
    }

    if (counter === 0) {
        return 'Brackets are placed correctly.';
    }
    else {
        return 'Brackets are NOT placed correctly.';
    }
}

// Example from problem
var correctInput = '((a+b)/5-d)';
console.log(checkBrackets(correctInput));
var wrongInput = ')(a+b))';
console.log(checkBrackets(wrongInput));