/*
Problem 1. Increase array members

Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
*/

// Use Node.js to test solution
var someArray = [];

for (var i = 0; i < 20; i+=1) {
    someArray[i] = 5*i;
}

console.log(someArray);


