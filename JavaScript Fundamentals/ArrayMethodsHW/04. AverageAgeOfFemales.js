/*
 Problem 4. Average age of females

 Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
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

//console.log(population);
console.log('------------------------');

function findFemales(someArray) {
    return !!(someArray.gender);
}

var females = population.filter(findFemales);
console.log('All females:');
console.log(females);
console.log('------------------------');

var agesArray = [];

function getAge(someArray) {
    agesArray.push(someArray.age);
}

var ages = females.forEach(getAge);
console.log('Ages of females: ' + '[' + agesArray + ']');

var sum = agesArray.reduce(function (sum, number) {
    return sum + number;
});

var average = sum / agesArray.length;

console.log('Sum: ' + sum);
console.log('Average age: ' + average);