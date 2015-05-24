/*
Problem 7. The biggest of five numbers

Write a script that finds the greatest of given 5 variables.
    Use nested if statements.
*/

function greatestNum(numbers) {
    var biggestNum = numbers[0];

    for (var i = 0; i < numbers.length; i+=1) {
         if (numbers[i] > biggestNum) {
             biggestNum = numbers[i];
         }
    }

    return biggestNum;
}

// Test
var numbers = [5, 2, 2, 4, 1];
console.log(greatestNum(numbers));