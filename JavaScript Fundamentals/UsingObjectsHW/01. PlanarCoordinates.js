/*
 Problem 1. Planar coordinates

 Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.
 */

// Use Node.js to check solution
function createPoint(xCoordinate, yCoordinate) {
    return {
        xCoordinate: xCoordinate,
        yCoordinate: yCoordinate
    };
}

function createLine(PointA, PointB) {
    return {
        beginning: PointA,
        end: PointB
    };
}

function distanceBetweenPoints(PointA, PointB) {
    var xDistance,
        yDistance,
        distance;

    xDistance = (PointA.xCoordinate - PointB.xCoordinate) * (PointA.xCoordinate - PointB.xCoordinate);
    yDistance = (PointA.yCoordinate - PointB.yCoordinate) * (PointA.yCoordinate - PointB.yCoordinate);
    distance = Math.sqrt(xDistance + yDistance);

    return distance;
}

function formTriangle(LineA, LineB, LineC) {
    var lineADist = distanceBetweenPoints(LineA.beginning, LineB.end),
        lineBDist = distanceBetweenPoints(LineB.beginning, LineC.end),
        lineCDist = distanceBetweenPoints(LineA.beginning, LineC.end);

    // Triangle inequality (could also be solved with permutations)
    var firstCheck = lineADist < lineBDist + lineCDist,
        secondCheck = lineBDist < lineADist + lineCDist,
        thirdCheck = lineCDist < lineADist + lineBDist;

    if (firstCheck || secondCheck || thirdCheck) {
        return 'Triangle can be formed.'
    }
    else {
        return 'Triangle CANNOT be formed.'
    }
}

// Test functions

// Create Points
var PointA = createPoint(1, 1);
var PointB = createPoint(0, 0);

var PointC = createPoint(2, 3);
var PointD = createPoint(7, 4);

var PointE = createPoint(-3, 5);
var PointF = createPoint(6, -9);

// Distance Between Points
console.log('Distance between points A and B: ' + distanceBetweenPoints(PointA, PointB));
console.log('Distance between points C and D: ' + distanceBetweenPoints(PointC, PointD));
console.log('Distance between points E and F: ' + distanceBetweenPoints(PointE, PointF) + '\n');

// Create three line segments
var LineA = createLine(PointA, PointB);
var LineB = createLine(PointC, PointD);
var LineC = createLine(PointE, PointF);

// Form Triangle?
console.log(formTriangle(LineA, LineB, LineC));