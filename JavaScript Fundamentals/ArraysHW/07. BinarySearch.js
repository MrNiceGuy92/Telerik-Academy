/*
Problem 7. Binary search

Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
*/

// Use Node.js to test solutions

function binarySearch(givenArray, soughtNumber) {
    // Sorting the array using selection sort
    var min = Number.MAX_VALUE,
        sortedArray = [];

    while (givenArray.length > 0) {
        for (var i = 0; i < givenArray.length; i += 1) {
            if (min > givenArray[i]) {
                min = givenArray[i];
            }
        }

        var index = givenArray.indexOf(min);
        givenArray.splice(index, 1);
        sortedArray.push(min);
        min = Number.MAX_VALUE;
    }

    // Performing Binary Search
    var maxIndex = sortedArray.length,
        minIndex = 0,
        position = Math.floor((maxIndex - minIndex) / 2);

    for (var k = minIndex; k < maxIndex; k += 1) {
        if (soughtNumber < sortedArray[position]) {
            position = position - 1;
        }
        else if (soughtNumber > sortedArray[position]) {
            position = position + 1;
        }
        else {
            break;
        }
    }

    return position;
}

var numbers = [3, 4, 1, 2, 5, 0, -3, -9, 32],
    soughtNumber = 1;
// sortedArray: [ -9, -3, 0, 1, 2, 3, 4, 5, 32 ]
console.log('Index of ' + soughtNumber + ' is: ' + binarySearch(numbers, soughtNumber));