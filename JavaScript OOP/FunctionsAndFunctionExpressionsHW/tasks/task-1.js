/* Task Description */
/* 
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number

 */

function getSum(someArray) {
    var sum;

    if (typeof someArray === 'undefined') {
        throw {
            message: 'Array cannot be empty!'
        };
    }

    if (someArray.length === 0) {
        return null;
    }

    sum = someArray.reduce(function (sum, number) {
        if (isNaN(parseInt(number))) {
            throw new Error('Only numbers in the array are allowed!');
        }
        return sum + parseInt(number);
    }, 0);

    return sum;
}

module.exports = getSum;