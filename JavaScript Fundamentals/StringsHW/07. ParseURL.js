/*
Problem 7. Parse URL

Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from
it the [protocol], [server] and [resource] elements.
Return the elements in a JSON object.
*/

// Use Node.js to test solution
function parseURL(url) {
    var index = url.indexOf('://'),
        secondIndex = url.indexOf('/', index + 3),
        protocol = '',
        server = '',
        resource= '';

    protocol = url.substring(0, index);
    server = url.substring(index + 3, secondIndex);
    resource = url.substring(secondIndex, url.length);

    return { protocol:protocol, server:server, resource:resource};
}

// Example from problem
var url = 'http://telerikacademy.com/Courses/Courses/Details/239';
console.log(parseURL(url));