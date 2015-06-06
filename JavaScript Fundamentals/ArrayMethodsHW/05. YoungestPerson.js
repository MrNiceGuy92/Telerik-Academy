/*
 Problem 5. Youngest person

 Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
 */

// Use Node.js to test solution

// Generated array from problem 1
function createPerson(firstName, lastName, age, gender) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: gender
    }
}

var maleFirstNames = ['Petur', 'James', 'John', 'Dimitur', 'Alejandro'],
    maleLastNames = ['Smith', 'Black', 'Popov', 'Nikolov', 'Ivanov'],
    femaleFirstNames = ['Elena', 'Tsvetina', 'Maria', 'Emily', 'Anna'],
    femaleLastNames = ['Petkova', 'Hadjiiska', 'Mateeva', 'Boryanova', 'Deneva'],
    length = maleFirstNames.length - 1,
    population = [],
    i;

for (i = 0; i < 10; i += 1) {
    if (Math.round(Math.random())) {
        population.push(createPerson(maleFirstNames[Math.floor(Math.random() * length)],
            maleLastNames[Math.floor(Math.random() * length)],
            (Math.random() * 100 + 1) | 0, false));
    }
    else {
        population.push(createPerson(femaleFirstNames[Math.floor(Math.random() * length)],
            femaleLastNames[Math.floor(Math.random() * length)],
            (Math.random() * 100 + 1) | 0, true));
    }
}

//console.log(population);
console.log('------------------------');

function findMales(someArray) {
    return !(someArray.gender);
}

var males = population.filter(findMales);
console.log('All Males:');
console.log(males);

console.log('------------------------');

// Polyfill by MDN
if (!Array.prototype.find) {
    Array.prototype.find = function(predicate) {
        if (this == null) {
            throw new TypeError('Array.prototype.find called on null or undefined');
        }
        if (typeof predicate !== 'function') {
            throw new TypeError('predicate must be a function');
        }
        var list = Object(this);
        var length = list.length >>> 0;
        var thisArg = arguments[1];
        var value;

        for (var i = 0; i < length; i++) {
            value = list[i];
            if (predicate.call(thisArg, value, i, list)) {
                return value;
            }
        }
        return undefined;
    };
}

function getNamesOfYoungestMale (males) {
    var youngestMale =  males.sort(function (a, b) {return a.age - b.age;})
        .find(function(person) {return !person.isFemale;});

    return youngestMale.firstName + ' ' + youngestMale.lastName + ' ' + youngestMale.age;
}

console.log(getNamesOfYoungestMale(males));