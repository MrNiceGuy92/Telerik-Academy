/*
Problem 7. Is prime
Write an expression that checks if given positive integer number n (n <= 100) is prime.
*/

// I use Node.js to test my solutions

function checkPrime (someNum) {
    var initialDivider = 2,
        maxDivider = Math.floor(Math.sqrt(someNum)),
        isPrime = true,
        i;

    if(someNum < 2) {
        isPrime = false;
        return someNum + ' is prime? ' + isPrime;
    }

    for (i = initialDivider; i <= maxDivider ; i+=1) {
         if (someNum % i == 0) {
              isPrime = false;
                break;
         }
    }
    return someNum + ' is prime? '+ isPrime;
}


// Examples from problem
console.log(checkPrime((1)));
console.log(checkPrime((2)));
console.log(checkPrime((3)));
console.log(checkPrime((4)));
console.log(checkPrime((9)));
console.log(checkPrime((37)));
console.log(checkPrime((97)));
console.log(checkPrime((51)));
console.log(checkPrime((-3)));
console.log(checkPrime((0)));