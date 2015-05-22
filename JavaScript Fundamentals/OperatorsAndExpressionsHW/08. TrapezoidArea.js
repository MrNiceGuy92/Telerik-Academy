/*
Problem 8. Trapezoid area
Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/

// I use Node.js to test my solutions

function getArea(sideA, sideB, height) {
    var area = 0.5 * (sideA + sideB) * height,
        str = 'The area of the trapezium is: ';
    return str + area;
}

// Examples from problem
console.log(getArea(5, 7, 12));
console.log(getArea(2, 1, 33));
console.log(getArea(8.5, 4.3, 2.7));
console.log(getArea(100, 200, 300));
console.log(getArea(0.222, 0.333, 0.555));