/*
Problem 5. Appearance count

Write a function that counts how many times given number appears in given array.
    Write a test function to check if the function is working correctly.
*/

// Use Node.js to test solution
function appearanceCount(givenNumber, someArray) {
    var index = someArray.indexOf(givenNumber),
        counter = 0;

    while(index >= 0) {
        counter +=1;
        index = someArray.indexOf(givenNumber, index + 1);
    }

    return counter;
}

function testFunction(givenNumber, someArray) {
    var lastIndex = someArray.lastIndexOf(givenNumber),
        counter = 0,
        newLastIndex;

    while(lastIndex >= 0) {
        counter +=1;
        newLastIndex = someArray.lastIndexOf(givenNumber, lastIndex - 1);
        if (lastIndex > newLastIndex) {
            lastIndex = newLastIndex;
        }
        else {
            break;
        }
    }

    if (appearanceCount(givenNumber, someArray) === counter) {
        return 'The appearaneCount() function works correctly.';
    }
    else {
        return 'The appearaneCount() function does NOT work correctly.'
    }
}

// Example solution
var someArray = [1,1,1,3,3,4,5,1];

console.log(appearanceCount(1, someArray));
console.log(testFunction(1, someArray));