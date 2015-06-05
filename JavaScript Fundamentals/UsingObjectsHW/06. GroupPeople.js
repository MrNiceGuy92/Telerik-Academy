/*Problem 6.

Write a function that groups an array of people by age, first or last name.
    The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
Use function overloading (i.e. just one function.
*/

// Use Node.js to test solution
function createPerson(firstName, lastName, age) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age
    }
}

var people = [
    createPerson('John', 'Smith', 23),
    createPerson('Johnny', 'Walker', 34),
    createPerson('Joe', 'Black', 23),
    createPerson('Drunk', 'Walker', 56),
    createPerson('John', 'White', 12)
];

function groupPeopleBy (peopleArray, key) {
    if (peopleArray.length === 0) {
        return null;
    }

    // check to see if given key exists in the objects of the array
    if (!peopleArray[0].hasOwnProperty(key)) {
        return null;
    }

    var groupedPeople = {},
        ind;

    for (ind in peopleArray) {
        // check if current object`s key value exists as property name in the resulting associative array and if it doesn`t create it as empty array
        var groupProperty = peopleArray[ind][key];

        if (!groupedPeople.hasOwnProperty(groupProperty)) {
            groupedPeople[groupProperty] = [];
        }
        // if current object`s key value exists as property name in the resulting associative array, add current object to this property in the associative array. This property is also an array, because we would have created it in the previous if statement
        groupedPeople[groupProperty].push(peopleArray[ind]);
    }

    return groupedPeople;
}

var groupedByAge = groupPeopleBy(people, 'age');
console.log(groupedByAge);
var groupByFirstName = groupPeopleBy(people, 'firstName');
console.log(groupByFirstName);
var groupByLastName = groupPeopleBy(people, 'lastName');
console.log(groupByLastName);
