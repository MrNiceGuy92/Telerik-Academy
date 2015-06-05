/*
 Problem 5. Youngest person

 Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstname, lastname and age.
 */

// Use Node.js to test solution
function createPerson(firstName, lastName, age) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age
    }
}

var famousExplorers = [
    createPerson('Marco', 'Polo', 69),
    createPerson('Christopher', 'Columbus', 41),
    createPerson('Ferdinand', 'Magellan', 54),
    createPerson('Jacques', 'Cousteau', 29)
];

function findYoungest(array) {
    var minAge = Infinity,
        fullName,
        i,
        len;

    for (i = 0, len = array.length; i < len; i += 1) {
        if (minAge > array[i].age) {
            minAge = array[i].age;
            fullName = array[i].firstName + ' ' + array[i].lastName;
        }
    }

    return fullName;
}

console.log(findYoungest(famousExplorers));