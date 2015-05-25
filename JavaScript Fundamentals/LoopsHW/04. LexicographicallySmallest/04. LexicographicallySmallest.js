/*
Problem 4. Lexicographically smallest

Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
*/

// Use index.html and browser console (F12) to test solution

function getProperties(obj){
    var min = 0;
    var max = 0;

    for(var property in obj){
        if(!min){
            min = property;
        }

        if(!max){
            max = property;
        }

        if(property < min){
            min = property;
        }

        if(property > max){
            max = property;
        }
    }

    console.log('min: ' + min);
    console.log('max: ' + max + '\n\r');
}

console.log('Window:');
getProperties(window);
console.log('Navigator:');
getProperties(navigator);
console.log('Document:');
getProperties(document);