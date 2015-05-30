/*Problem 4. Number of elements

Write a function to count the number of div elements on the web page*/

function countTags (tagName) {
    var result;
    result = document.getElementsByTagName(tagName).length;
    return result;
}

// Example
var tagName = 'div';
console.log('Number of divs: ' + countTags(tagName));