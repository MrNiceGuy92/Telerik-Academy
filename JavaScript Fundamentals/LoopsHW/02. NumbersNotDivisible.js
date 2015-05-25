/*
Problem 2. Numbers not divisible

Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
*/

// Use Node.js to test solution

function numsNotDivBy3And7(N) {
    for (var i = 0; i <= N; i++) {
         if (!(i % 3 === 0 && i % 7 === 0)) {
             console.log(i);
         }
    }
}

console.log(numsNotDivBy3And7(100));