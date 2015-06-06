/*
 Problem 1. Make person

 Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders
 */

// Use Node.js to test solution
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
    length = maleFirstNames.length - 1; // All first and last name arrays have the same length
population = [];

for (var i = 0; i < 10; i += 1) {
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

// Output
console.log(population);