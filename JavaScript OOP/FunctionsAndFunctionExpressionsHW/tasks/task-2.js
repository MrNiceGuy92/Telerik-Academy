/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function findPrimes(start, end) {
    var i,
        j,
        maxDivider,
        result = [],
        isPrime = true;

    if (arguments.length !== 2) {
        throw new Error('Function needs to have two arguments.');
    } else if ((isNaN(parseInt(start)) || isNaN(parseInt(end)))) {
        throw new Error('Range intervals needs to consist of Numbers.');
    }

    start = parseInt(start);
    end = parseInt(end);

    if (start <= 2) {
        result.push(2);
        start = 3;
    }

    if (start % 2 === 0) {
        start += 1;
    }

    for (i = start; i <= end; i += 2) {
        maxDivider = Math.sqrt(i);
        for (j = 3; j < maxDivider; j += 2) {
            if (i % j) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            result.push(i);
        }
    }

    return result;
}

module.exports = findPrimes;