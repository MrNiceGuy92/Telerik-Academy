/* Task Description */
/* 
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number

 */

function sum(someArray) {
    var i,
        len,
        sum = 0;

    if (someArray.length === 0) {
        return null;
    }

    for (i = 0, len = someArray.length; i < len; i += 1) {
        if (!+someArray[i]) {
            throw new Error('Elements must be of type Number.');
        }

        sum += someArray[i] | 0;
    }

    return sum;
}

module.exports = sum;