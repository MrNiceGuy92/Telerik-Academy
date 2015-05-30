/*Problem 2. Remove elements

Write a function that removes all elements with a given value.
    Attach it to the array type.
    Read about prototype and how to attach methods.
*/

// Use Node.js to test solution
Array.prototype.removeAll = function (element) {
    var len,
        i;

    for (i = 0, len = this.length; i < len; i+=1) {
         if (this[i] === element) {
             this.splice(i,1);
         }
    }

    return this;
};

// Example from problem
var someArray = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
console.log(someArray.removeAll(1));