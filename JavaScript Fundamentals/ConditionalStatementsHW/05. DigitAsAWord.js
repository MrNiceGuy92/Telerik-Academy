/*
Problem 5. Digit as word

Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
    Use a switch statement.
*/

// Use Node.js to test my solutions

function getWord(digit) {
    switch (digit) {
    case 0:  return 'Zero'; break;
    case 1:  return 'One'; break;
    case 2:  return 'Two'; break;
    case 3:  return 'Three'; break;
    case 4:  return 'Four'; break;
    case 5:  return 'Five'; break;
    case 6:  return 'Six'; break;
    case 7:  return 'Seven'; break;
    case 8:  return 'Eight'; break;
    case 9:  return 'Nine'; break;
    default: return 'Not a digit'; break;
    }
}

// Examples from problem
console.log(getWord(2));
console.log(getWord(1));
console.log(getWord(0));
console.log(getWord(5));
console.log(getWord(-0.1));
console.log(getWord('hi'));
console.log(getWord(9));
console.log(getWord(10));