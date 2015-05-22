/*
Problem 6. Point in Circle
Write an expression that checks if given point P(x, y) is within a circle K(O, 5).
*/

// I use Node.js to test my solutions

function checkIfInside(xCoord, yCoord) {
    var radius = 5,
        cX = 0,
        cY = 0;
    if ((xCoord - cX)*(xCoord - cX) + (yCoord - cY)*(yCoord - cY) <= radius*radius) {
        return 'Point is INSIDE.';
    }
    else {
        return 'Point is OUTSIDE.';
    }
}

// Examples from problem
console.log(checkIfInside(0, 1));
console.log(checkIfInside(-5, 0));
console.log(checkIfInside(-4, 5));
console.log(checkIfInside(1.5, -3));
console.log(checkIfInside(-4, -3.5));
console.log(checkIfInside(100, -30));
console.log(checkIfInside(0, 0));
console.log(checkIfInside(0.2, -0.8));
console.log(checkIfInside(0.9, -4.93));
console.log(checkIfInside(2, 2.655));