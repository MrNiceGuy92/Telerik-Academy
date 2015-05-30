/*
Problem 7. First larger than neighbours

Write a function that returns the index of the first element in array that is larger than its neighbours or -1,
if there’s no such element.
*/

// Use Node.js to check my solution
function firstElementBiggerThanNeighbours(someArray) {
    var position,
        len;

    for (position = 0, len = someArray.length; position <= len; position+=1) {
        if (position != 0 && position != someArray.length) {
            if (someArray[position] > someArray[position + 1] && someArray[position] > someArray[position -1]) {
                return position;
            }
        }
        else if (position === 0) {
            if (someArray[position] > someArray[position + 1]) {
                return position;
            }
        }
        else if (position === someArray.length) {
            if (someArray[position - 1] > someArray[position - 2]) {
                return position;
            }
        }
    }

    return -1;
}

// Example
var someArray= [1, 1, 3, 4, 4, 3, 87];
console.log('The first element in the array that is larger than its neighbours is at position: ' + firstElementBiggerThanNeighbours(someArray));