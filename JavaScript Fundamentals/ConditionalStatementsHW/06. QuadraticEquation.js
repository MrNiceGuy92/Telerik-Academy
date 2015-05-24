/*
Problem 6. Quadratic equation

Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Calculates and prints its real roots.
    Note: Quadratic equations may have 0, 1 or 2 real roots.
*/

function getRoots(a, b, c) {
    var discriminant = b*b - 4*a*c;
    if (discriminant < 0) {
         return 'No real roots';
    }
    else if (discriminant === 0) {
         return 'X1 = X2 = ' + (-b/(2*a));
    }
    else if (discriminant > 0) {
         return 'X1 = ' + (-b + Math.sqrt(discriminant))/(2*a) + ' ' + 'X2= ' + (-b - Math.sqrt(discriminant))/(2*a);
    }

}

// Examples from problem

console.log(getRoots(2, 5, -3));
console.log(getRoots(-1, 3, 0));
console.log(getRoots(-0.5, 4, -8));
console.log(getRoots(5, 2, 8));