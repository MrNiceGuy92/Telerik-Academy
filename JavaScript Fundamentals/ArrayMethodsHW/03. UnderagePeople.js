/*
 Problem 3. Underage people

 Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)
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

console.log(population);
console.log('------------------------');

console.log('All underage people:');
function findUnderage(array) {
    return (array.age < 18);
}

function iterateAndPrint(afterFilter) {
    console.log(afterFilter.firstName + ' ' + afterFilter.lastName);
}

var afterFilter = population.filter(findUnderage);
var afterIteration = afterFilter.forEach(iterateAndPrint);