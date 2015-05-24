/*
Problem 8. Number as words

Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
*/

function getWord(number) {
    var result = ' ',
        tens = Math.floor(number / 10) % 10,
        ones = number % 10,
        hundreds = Math.floor(number / 100) % 10;

    if (number === 0) {
        result = 'zero';
        return result;
    }

    else if (number <= 10) {
        result = oneAsText(number);
        return result;
    }

    else if (10 < number && number <= 20) {
        result = teensAsText(ones);
        return result;
    }

    else if (!hundreds && tens){
        result = tensAsText(tens) + ' ' + oneAsText(ones);
        return result;
    }

    else if (hundreds && (tens % 10) === 1) {
        result = oneAsText(hundreds) + ' hundred and ' + teensAsText(ones);
        return result;
    }

    else if (hundreds && ones === 0) {
        result = oneAsText(hundreds) + ' hundred';
        return result;
    }

    else if (hundreds && tens === 0) {
        result = oneAsText(hundreds) + ' hundred and ' + oneAsText(ones);
        return result;
    }
    
    else if (hundreds && tens !== 0 ) {
        result = oneAsText(hundreds) + ' hundred and' + ' ' + tensAsText(tens) + ' ' + oneAsText(ones);
        return result;
    } 
    
    function oneAsText(num) {
        switch (num) {
            case 1: result = 'one'; break;
            case 2: result = 'two'; break;
            case 3: result = 'three'; break;
            case 4: result = 'four'; break;
            case 5: result = 'five'; break;
            case 6: result = 'six'; break;
            case 7: result = 'seven'; break;
            case 8: result = 'eight'; break;
            case 9: result = 'nine'; break;
            case 10: result = 'ten'; break;
            default: return '';
        }
        return result;
    }

    function teensAsText(num) {
        switch (num) {
            case 1: result = 'eleven'; break;
            case 2: result = 'twelve'; break;
            case 3: result = 'thirteen'; break;
            case 4: result = 'fourteen'; break;
            case 5: result = 'fifteen'; break;
            case 6: result = 'sixteen'; break;
            case 7: result = 'seventeen'; break;
            case 8: result = 'eighteen'; break;
            case 9: result = 'nineteen'; break;
            default: return '';
        }
        return result;
    }

    function tensAsText(num) {
        switch (num) {
            case 2: result = 'twenty'; break;
            case 3: result = 'thirty'; break;
            case 4: result = 'forty'; break;
            case 5: result = 'fifty'; break;
            case 6: result = 'sixty'; break;
            case 7: result = 'seventy'; break;
            case 8: result = 'eighty'; break;
            case 9: result = 'ninety'; break;
            default: return '';
        }
        return result;
    }
}

// Examples from problem
console.log(getWord(0));
console.log(getWord(9));
console.log(getWord(10));
console.log(getWord(12));
console.log(getWord(19));
console.log(getWord(25));
console.log(getWord(98));
console.log(getWord(273));
console.log(getWord(400));
console.log(getWord(501));
console.log(getWord(617));
console.log(getWord(711));
console.log(getWord(999));