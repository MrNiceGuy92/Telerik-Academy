/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * method removeAttribute(attribute)
 * throw Error if attribute does not exist in the domElement
 */


/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */


function solve() {
    var domElement = (function () {
        function isValidType(type) {
            var regex = /^[a-z0-9]+$/gi;

            if (typeof type !== 'string') {
                return false;
            }

            return regex.test(name)
        }

        function isValidAttributeName(name) {
            var regex = /^[a-z0-9\-]+$/gi;

            return regex.test(name);
        }

        function sortAttributes(attributes) {
            var sorted = attributes.slice(0);

            sorted.sort(function (a, b) {
                if (a.name === b.name) {
                    return 0;
                }
                return a.name > b.name ? 1 : -1;
            });

            return sorted;
        }

        var domElement = {
            init: function (type) {
                this.type = type;
                this.content = '';
                this.attributes = [];
                this.children = [];
                this.parent = '';

                return this;
            },
            appendChild: function (child) {
                this.children.push(child);
                
                if (typeof child === 'object') {
                    child.parent = this;
                }

                return this;
            },
            addAttribute: function (name, value) {
                var attribute = {},
                    currentAttribute,
                    isTheSameName = false;

                if (!isValidAttributeName(name)) {
                    throw new Error;
                } 

                attribute.name = name;
                attribute.value = value;
                
                for (var i = 0; i < this.attributes.length; i+=1) {
                     currentAttribute =this.attributes[i];
                    if (name === currentAttribute) {
                        currentAttribute.value = value,
                            isTheSameName = true;
                    }
                } 
                
                if (!isTheSameName) {
                     this.attributes.push(attribute);
                } 

                return this;
            }
        }
    })
}

module.exports = solve;
