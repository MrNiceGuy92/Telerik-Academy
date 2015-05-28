/*
Problem 4. Maximal increasing sequence

Write a script that finds the maximal increasing sequence in an array.
*/

// Use Node.js to test solutions
function maxIncreaseSequence(numbers) {
    var counter = 1,
        bestStart = 0,
        result = [],
        bestLength = 0;

    for (var i = 0; i < numbers.length - 1; i+=1)
    {
        if (numbers[i] < numbers[i + 1]) {
            counter+=1;
        }
        else if (counter >= bestLength) {
            bestLength = counter;
            bestStart = i - bestLength + 1;
            counter = 1;
        }
        else {
            counter = 1;
        }
    }

    if (counter >= bestLength) {
        bestLength = counter;
        bestStart = i - bestLength + 1;
        counter = 1;
    }

    for (var j = bestStart; j < bestStart + bestLength; j+=1) {
       result.push(numbers[j]);
    }

    return result;
}

// Example from problem
var numbers = [3, 2, 3, 4, 2, 2, 4];
console.log(maxIncreaseSequence(numbers));