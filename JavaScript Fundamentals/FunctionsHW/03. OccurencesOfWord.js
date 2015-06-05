/*
 Problem 3. Occurrences of word

 Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.
 */

// Use Node.js to test solution
function findWordCount(text, word, caseSensitive) {
    var textAsArray = text.split(' '),
        len = textAsArray.length,
        i,
        counter = 0;

    if (arguments.length === 2) {
        for (i = 0; i < len; i += 1) {
            if (word == textAsArray[i]) {
                counter += 1;
            }
        }
    }
    else if (arguments.length === 3) {
        word = word.toLowerCase();
        text = text.toLowerCase();
        textAsArray = text.split(' ');

        for (i = 0; i < len; i += 1) {
            if (word == textAsArray[i]) {
                counter += 1;
            }
        }
    }

    return counter;
}

// Example
var text = 'Dog DOg Dog dOg Dog dog Dog dog Dog dog Dog dog Dog DOG Dog DoG';
var word = 'Dog';
var caseSensitive = 'Yes';

console.log(findWordCount(text, word));
console.log(findWordCount(text, word, caseSensitive));