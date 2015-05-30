/*
Problem 6. Larger than neighbours

Write a function that checks if the element at given position in given array of integers is bigger than its two
neighbours (when such exist).*/

// Use Node.js to check my solution
function compareWithNeighbours(position, someArray) {
    if (position != 0 && position != someArray.length) {
        if (someArray[position] > someArray[position + 1] && someArray[position] > someArray[position -1]) {
            return 'Bigger than neighbours.';
        }
        else {
            return 'Not Bigger than neighbours.';
        }
    }
    else if (position === 0) {
        if (someArray[position] > someArray[position + 1]) {
            return 'Bigger than RIGHT neighbour.';
        }
        else {
            return 'Smaller than RIGHT neighbour.';
        }
    }
    else if (position === someArray.length) { 
        if (someArray[position - 1] > someArray[position - 2]) {
            return 'Bigger than LEFT neighbour.'
        }
        else {
            return 'Smaller than LEFT neighbour.'
        }
    }
}

// Example
var someArray= [1, 3, 4, 2, 5, 6, 3, 7,  8];
console.log(compareWithNeighbours(9, someArray));