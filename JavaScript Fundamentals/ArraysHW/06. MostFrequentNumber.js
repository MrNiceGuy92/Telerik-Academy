/*
Problem 6. Most frequent number

Write a script that finds the most frequent number in an array.
*/

// Use Node.js to test solutions

function mostFrequentNumber(number) {
    var counter = 1,
        maxCounter = 0,
        result;

    for (var i = 0; i < number.length; i+=1) {
         for (var j = 1; j < number.length; j+=1) {
              if (number[i] === number[j]) {
                  counter+=1;
              }
         }
        if (counter > maxCounter) {
             maxCounter = counter;
            result = number[i];
        }
        counter = 0;
    }

    return 'Result: ' + result + '\n' + 'Number of times: ' + maxCounter;
}

var numbers = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

console.log(mostFrequentNumber(numbers));