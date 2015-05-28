/*
 Problem 2. Lexicographically comparison

 Write a script that compares two char arrays lexicographically (letter by letter).
*/

// Use Node.js to test solution
function compareArrays(firstArray, secondArray) {

    if (firstArray.length > secondArray.length) {
        return '['+secondArray+']' + ' is smaller, therefore first.';
    }

    else if (secondArray.length > firstArray.length) {
        return '['+firstArray+']' + ' is smaller, therefore first.';
    }

    else {
        var isFirst = false;

        for (var i = 0; i < firstArray.length; i+=1) {
             if (firstArray[i] > secondArray[i]) {
                 isFirst = true;
                 break;
             }
        }

        if (isFirst) {
             return firstArray;
        }
        else {
            return secondArray;
        }
    }
}

var firstArray = ['b', 'd', 'g', 'y', 'u', 'a'],
    secondArray = ['b', 'w', 't', 'y', 'i', 'o'];

console.log(compareArrays(firstArray, secondArray));
