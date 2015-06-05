/*
 Problem 11. String format

 Write a function that formats a string using placeholders.
 The function should work with up to 30 placeholders and all types.
 */

// Use Node.js to test my solution
function formatString() {
    var args = arguments,
        string = args[0],
        placeholder,
        i,
        len;

    for (i = 1, len = args.length; i < len; i++) {
        placeholder = '{' + (i - 1) + '}';

        while (string.indexOf(placeholder) > -1) {
            string = string.replace(placeholder, args[i]);
        }
    }

    return string;
}

// Example
console.log(formatString('{0}, {1}, {0} text {2}', 1, 'Pesho', 'Gosho'));