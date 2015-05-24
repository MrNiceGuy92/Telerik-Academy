/*
 Problem 9. Point in Circle and outside Rectangle
 Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3)
 and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */

// I use Node.js to test my solutions

function inCircleOutRect (xCoord, yCoord) {
    var radius = 3,
     xCircle = 1,
     yCircle = 1;

    var inRect = (-1<=xCoord) && (xCoord<=5) && (-1<=yCoord) && (yCoord<=1),
        inCircle = (xCircle-xCoord)*(xCircle-xCoord) + (yCircle-yCoord)*(yCircle-yCoord)<= radius*radius;

    if (inCircle && !inRect) {
        return 'YES';
    }
    else {
        return 'NO';
    }
}

// Examples from problem
console.log(inCircleOutRect(1, 2));
console.log(inCircleOutRect(2.5, 2));
console.log(inCircleOutRect(0, 1));
console.log(inCircleOutRect(2.5, 1));
console.log(inCircleOutRect(2, 0));
console.log(inCircleOutRect(4, 0));
console.log(inCircleOutRect(2.5, 1.5));
console.log(inCircleOutRect(2, 1.5));
console.log(inCircleOutRect(1, 2.5));
console.log(inCircleOutRect(-100, -100));