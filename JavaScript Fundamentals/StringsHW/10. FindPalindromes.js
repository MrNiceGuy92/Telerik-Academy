/*
Problem 10. Find palindromes

Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
*/

// Use Node.js to test solution
function findPalindromes(someText) {
    var palindromesString = ' ',
        counter = 0,
        len,
        i;

    someText = someText.split(' ');

    // Using new for of loop
    for (var word of someText) {
        for (i = 0, len = word.length/2; i < len; i+=1) {
            if (word[i] === word[2*len - i - 1]) {
                counter +=1;
            }
        }

        if (counter === Math.ceil(len)) {
            palindromesString += word;
            palindromesString += ' ';
        }

        counter = 0;
    }

    return palindromesString;
}

// Example
var someText = 'alula ANNA Sofia lamal Paris ABBA madam Lisabon mom Malta exe';
console.log(findPalindromes(someText));