/*
 Problem 3. Deep copy

 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.
 */

// Use Node.js to test solution
function deepClone(obj) {
    var cloned = {},
        prop;

    for (prop in obj) {
        cloned[prop] = deepClone(obj[prop]);
    }

    return cloned;
}

console.log(deepClone(5));
console.log(deepClone({name: 'Ninja', age: Infinity}));