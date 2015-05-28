/*
Problem 5. Selection sort

Sorting an array means to arrange its elements in increasing order.
    Write a script to sort an array.
    Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
    Hint: Use a second array.
*/

// Use Node.js to test solutions

function sortArray(numbers) {
    var min = Number.MAX_VALUE,
        sortedArray = [];

    while (numbers.length > 0) {
        for (var i = 0; i < numbers.length; i+=1) {
            if (min > numbers[i]) {
                min = numbers[i];
            }
        }
        var index = numbers.indexOf(min);
        numbers.splice(index, 1);
        sortedArray.push(min);
        min = Number.MAX_VALUE;
    }

    return sortedArray;
}

// Test case
var numbers = [3, 4, 1, 2, 5, 0, -3, -9, 32];
console.log(sortArray(numbers));