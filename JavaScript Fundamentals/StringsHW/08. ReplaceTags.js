/*
Problem 8. Replace tags

Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a>
with corresponding tags [URL=…]…/URL].
*/

// Use Node.js to test solution
function replaceTags(input) {
    var firstTag = '<a href=',
        replaceFirstTag = new RegExp(firstTag, 'g'),
        secondTag = '">',
        replaceSecondTag = new RegExp(secondTag, 'g'),
        thirdTag = '</a>',
        replaceThirdTag = new RegExp(thirdTag, 'g');

    input = input.replace(replaceFirstTag, '[URL=');
    input = input.replace(replaceSecondTag, ']');
    input = input.replace(replaceThirdTag,'[/URL]');

    return input;
}

// Example from problem
var input = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. ' +
    'Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
console.log(replaceTags(input));