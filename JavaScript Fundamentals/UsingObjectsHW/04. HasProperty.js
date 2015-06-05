/*
 Problem 4. Has property

 Write a function that checks if a given object contains a given property.
 */

// Use Node.js to test solution
function hasProperty(object, prop) {
    var propertyExists = false;

    if (object.hasOwnProperty(prop)) {
        propertyExists = true;
    }

    return propertyExists;
}

function createPerson(fname, lname, age) {
    return {
        firstName: fname,
        lastName: lname,
        age: age
    }
}

// Test
var johnSmith = createPerson('John', 'Smith', 23);
console.log(hasProperty(johnSmith, 'age'));
