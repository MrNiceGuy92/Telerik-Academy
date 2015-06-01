/*
Problem 9. Extract e-mails

Write a function for extracting all email addresses from given text.
    All sub-strings that match the format @… should be recognized as emails.
    Return the emails as array of strings.
*/

// Use Node.js to test solution
function extractEmail(input) {
    var result = '';
    input = input.split(' ');

    for (var i = 0; i < input.length; i+=1) {
        var regEx = /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i;
        if(regEx.test(input[i])) {
             result += input[i] + '\n';
        }
    }

    return result;
}

// Example
var input = 'gosho-pesho@yahoo.com pesho @ @@ gosho@com nikiIT@telerik.com babaPenka123@gmail.com';
console.log(extractEmail(input));