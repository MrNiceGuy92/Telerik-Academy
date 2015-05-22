/*
Problem 3. Rectangle area
Write an expression that calculates rectangle’s area by given width and height.
*/

// I use Node.js to test my solutions

function areaOfRect(width, length) {
    var area = width * length;
    return 'Area of rectangle: ' + area;
}

// Examples from problem
console.log(areaOfRect(3,4));
console.log(areaOfRect(2.5,3));
console.log(areaOfRect(5,5));