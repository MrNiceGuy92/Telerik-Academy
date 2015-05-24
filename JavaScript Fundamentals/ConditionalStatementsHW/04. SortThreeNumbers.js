/*Problem 4. Sort 3 numbers

Sort 3 real values in descending order.
    Use nested if statements.
    Note: Don’t use arrays and the built-in sorting functionality.
*/

// Use Node.js to test my solutions

function sort(a, b, c) {

    var sorted = [];

    if (a >= b && a > c) {
        if (b >= c) {
           sorted.push(a, b, c);
        }
        else {
            sorted.push(a, c, b);
        }
    }
    else if (b >= c && b > a) {
        if (c >= a) {
            sorted.push(b, c, a);
        }
        else if (a > c) {
            sorted.push(b, a, c);
        }
    }
    else if (c >= a && c > b) {
         if (a >= b) {
             sorted.push(c, a, b);
         }
        else if (b > a) {
             sorted.push(c, b, a);
        }
    }
    else if (a === b && b === c) {
        sorted.push(a, a, a);
    }

    return sorted;
}

// Examples from problem
console.log(sort(5, 1, 2));
console.log(sort(-2, -2, 1));
console.log(sort(-2, 4, 3));
console.log(sort(0, -2.5, 5));
console.log(sort(-1.1, -0.5, -0.1));
console.log(sort(1, 1, 1));