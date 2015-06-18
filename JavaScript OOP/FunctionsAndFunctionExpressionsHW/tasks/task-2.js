/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function findPrimes(start, end) {
    var i,
        divider = 2,
        maxDivider,
        result = [];

    if (arguments.length < 2) {
        throw Error;
    }

    if (+start < 3) {
        result.push(2,3);
    }

    for (i = start | 0; i <= end | 0; i += 1) {
        maxDivider = Math.sqrt(i);
        for (var j = divider; j <= maxDivider; j += 1) {
            if (i % divider) {
                result.push(i);
                break;
            }
        }
    }

    return result;
}

module.exports = findPrimes;
