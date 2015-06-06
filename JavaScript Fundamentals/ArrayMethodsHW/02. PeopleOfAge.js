/*
 Problem 2. People of age

 Write a function that checks if an array of person contains only people of age (with age 18 or greater)
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

var ageArray = [],
    j;
for (j = 0; j < population.length; j += 1) {
    ageArray.push(population[j].age);
}

function greaterThan18(someArray) {
    return (someArray.age >= 18);
}

console.log('Array of all ages, generated above: ' + '[' + ageArray + ']');
console.log('All people 18 or older?: ' + population.every(greaterThan18));