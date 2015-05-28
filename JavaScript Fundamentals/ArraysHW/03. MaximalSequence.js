/*
Problem 3. Maximal sequence

Write a script that finds the maximal sequence of equal elements in an array.
*/

// Use Node.js to test solutions
function maxSequence(numbers) {
    var currentPosition = numbers[0],
        bestNum = 0,
        currentCount = 1,
        maxCount = 0,
        result = '';

    for (var i = 0; i < numbers.length - 1; i+=1) {

        if (numbers[i] != currentPosition) {
            currentCount = 1;
            currentPosition = numbers[i];
        }
        else {
            currentCount+=1;
        }
        if (currentCount > maxCount) {
            maxCount = currentCount;
            bestNum = currentPosition;
        }
    }

    for (var j = 0; j < maxCount; j+=1) {
        result += bestNum + ' ';
    }

    return result;
}

// Example from problem
var numbers = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
console.log(maxSequence(numbers));