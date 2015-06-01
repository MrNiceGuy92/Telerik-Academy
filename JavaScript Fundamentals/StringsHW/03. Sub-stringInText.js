/*
Problem 3. Sub-string in text

Write a JavaScript function that finds how many times a substring is contained in a given text
(perform case insensitive search).
*/

// Use Node.js to test solution
function findSubString(text, word) {
    // Case-insensitive
    word = word.toLowerCase();
    text = text.toLowerCase();

    var counter = 0,
        index = text.indexOf(word);

    while(index >=0) {
        counter +=1;
        index = text.indexOf(word, index +1);
    }

    return counter;
}

// Example from problem
var word = 'IN',
    text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight.' +
        'So we are drinking all the day. We will move out of it in 5 days.';
console.log('The result is: ' + findSubString(text, word));