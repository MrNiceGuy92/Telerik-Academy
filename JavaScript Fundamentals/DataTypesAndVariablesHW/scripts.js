/*Problem 1. JavaScript Literals*/
console.log('Problem 1: ')

var integer = 67;
console.log('Integer type: ' + integer);

var floatingPoint = 32.5;
console.log('Floating-point type: ' + floatingPoint);

var str = 'I don\'t have dreams, I have goals.';
console.log('String message: ' + str);

var numberObj = new Number(100);
console.log('Object of type Number: ' + numberObj);

var bool = true;
console.log('Boolean type: ' + bool);

var x = undefined;
console.log('Undefined type: ' + x);

var y = null;
console.log('Null type: ' + y);

var arr = [1,2,3];
console.log('Array: ' + arr);

var object = {name: 'Harvey Specter', age: 32};
console.log('Object type: ' + object.name + ' ' + object.age);
console.log('\n');

/*Problem 2. Quoted Text*/
console.log('Problem 2: ')

var firstQuotedText = '"Stop in the name of Love!" - she said.';
var secondQuotedText = '\'Ok, dear.\' - he said';
console.log(firstQuotedText);
console.log(secondQuotedText);
console.log('\n');

/*Problem 3 & 4. Typeof Variables & Typeof Null and Undefined*/
console.log('Problem 3 & 4: ')

console.log('Typeof integer: ' + typeof(integer));
console.log('Typeof floatingPoint: ' + typeof(floatingPoint));
console.log('Typeof string: ' + typeof(str));
console.log('Typeof boolean: ' + typeof(bool));
console.log('Typeof undefined: ' + typeof(x));
console.log('Typeof null: ' + typeof(y));
console.log('Typeof array: ' + typeof(arr));
console.log('Typeof object: ' + typeof(object));

