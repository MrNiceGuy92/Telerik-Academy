/*
 Problem 4. Parse tags

 You are given a text. Write a function that changes the text in all regions:

 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)
 */

// Use Node.js to test solution
function changeText(input) {
    var mixcaseTag = '<mixcase>',
        mixcaseEndTag = '</mixcase>',
        upcaseTag = '<upcase>',
        upcaseEndTag = '</upcase>',
        lowcaseTag = '<lowcase>',
        lowcaseEndTag = '</lowcase>',
        mixcaseIndex = input.indexOf(mixcaseTag),
        mixcaseEndIndex = input.indexOf(mixcaseEndTag),
        upcaseIndex = input.indexOf(upcaseTag),
        upcaseEndIndex = input.indexOf(upcaseEndTag),
        lowcaseIndex = input.indexOf(lowcaseTag),
        lowcaseEndIndex = input.indexOf(lowcaseEndTag),
        randomNum,
        i,
        len,
        initialSubscript,
        subscript;

    while(mixcaseIndex >=0) {
        initialSubscript = input.substring(mixcaseIndex + mixcaseTag.length, mixcaseEndIndex);
        subscript= '';

        for (i = 0, len = initialSubscript.length; i < len; i+=1) {
            randomNum = Math.random();
            if (randomNum <= 0.5) {
                subscript += initialSubscript[i].toUpperCase();
            }
            else {
                subscript +=initialSubscript[i];
            }
        }

        input = input.replace(initialSubscript, subscript);
        mixcaseIndex = input.indexOf(mixcaseTag, mixcaseIndex + 1);
        mixcaseEndIndex = input.indexOf(mixcaseEndTag, mixcaseEndIndex + 1);
    }

    while(upcaseIndex >=0) {
        initialSubscript = input.substring(upcaseIndex + upcaseTag.length, upcaseEndIndex);
        subscript = initialSubscript.toUpperCase();
        input = input.replace(initialSubscript, subscript);
        upcaseIndex = input.indexOf(upcaseTag, upcaseIndex + 1);
        upcaseEndIndex = input.indexOf(upcaseEndTag, upcaseEndIndex + 1);
    }

    while(lowcaseIndex >=0) {
        initialSubscript = input.substring(lowcaseIndex + lowcaseTag.length, lowcaseEndIndex);
        subscript = initialSubscript.toLowerCase();
        input = input.replace(initialSubscript, subscript);
        lowcaseIndex = input.indexOf(lowcaseIndex, lowcaseIndex + 1);
        lowcaseEndIndex = input.indexOf(lowcaseEndTag, lowcaseEndIndex + 1);
    }

    // Removing tags
    input = input.replace(/<mixcase>/g, '');
    input = input.replace(/<\/mixcase>/g, '');
    input = input.replace(/<upcase>/g, '');
    input = input.replace(/<\/upcase>/g, '');
    input = input.replace(/<lowcase>/g, '');
    input = input.replace(/<\/lowcase>/g, '');

    return input;
}

// Example from problem
var input = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>' +
    'don\'t</mixcase> have <lowcase>anyTHING</lowcase> else. <upcase>test</upcase> <mixcase>extratest</mixcase>';
console.log(changeText(input));