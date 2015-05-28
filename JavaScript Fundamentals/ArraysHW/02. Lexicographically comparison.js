/*
 Problem 2. Lexicographically comparison

 Write a script that compares two char arrays lexicographically (letter by letter).
*/

// Use Node.js to test solution
function compareArrays(firstArr, secondArr) {

    if (firstArr.length > secondArr.length) {
        return '['+secondArr+']' + ' is smaller, therefore first.';
    }

    else if (secondArr.length > firstArr.length) {
        return '['+firstArr+']' + ' is smaller, therefore first.';
    }

    else {
        var isFirst = false;

        for (var i = 0; i < firstArr.length; i+=1) {
             if (firstArr[i] > secondArr[i]) {
                 isFirst = true;
                 break;
             }
        }

        if (isFirst) {
             return firstArr;
        }
        else {
            return secondArr;
        }
    }
}

var firstArr = ['b', 'd', 'g', 'y', 'u', 'a'],
    secondArr = ['b', 'w', 't', 'y', 'i', 'o'];

console.log(compareArrays(firstArr, secondArr));
