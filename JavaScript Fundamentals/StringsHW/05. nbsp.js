/*
Problem 5. nbsp

Write a function that replaces non breaking white-spaces in a text with &nbsp;
*/
function replaceWhiteSpace(input) {
    input = input.replace(',', ' ');
    input = input.replace('.', ' ');
    input = input.split(' ');
    input = input.join('&nbsp');

    return input;
}

// Example
var input = 'Marvel has featured Spider-Man in several comic book series, the first and longest-lasting ' +
    'of which is titled The Amazing Spider-Man.';
console.log(input);
console.log(replaceWhiteSpace(input));