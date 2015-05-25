/*
Problem 3. Min/Max of sequence

Write a script that finds the max and min number from a sequence of numbers.
*/

// Use Node.js to test solution

function minMax(numbers) {
    var min = Number.MAX_VALUE;
    var max = Number.MIN_VALUE;

    for (var i = 0; i < numbers.length ; i++) {
        if (min > numbers[i]) {
             min = numbers[i];
        }
        if (max < numbers[i]) {
            max = numbers[i];
        }
    }

    console.log('Min: ' + min);
    console.log('Max: ' + max);
}

var numbers = [-3, 4, 76, 0, -23, 54];

minMax(numbers);