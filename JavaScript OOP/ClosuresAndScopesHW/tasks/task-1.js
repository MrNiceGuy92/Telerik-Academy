/* Task Description */
/*
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function () {
        var books = [],
            categories = [];

        function listBooks(parameter) {
            if(arguments.length > 0) {
                if(typeof parameter.category !== 'undefined') {
                    return typeof categories[parameter.category] !== 'undefined' ?
                        categories[parameter.category].books : [];
                }

                if(typeof parameter.author !== 'undefined') {

                    var booksToList = [];

                    for(var ind = 0, len = books.length; ind < len; ind += 1) {
                        if(books[ind].author === parameter.author) {
                            booksToList.push(books[ind]);
                        }
                    }

                    return booksToList;
                }
            }

            return books;
        }

        function checkParameters(book) {
            for (var param in book) {
                if(typeof book[param] === 'undefined') {
                    throw new Error(param + 'cannot be undefined.');
                }
            }
        }

        function validateTitle(input) {
            if (input.length < 2 || input.length > 100) {
                throw new Error('Title must between 2 and 100 symbols.');
            }
        }

        function validateCategory(input) {
            if (input.length < 2 || input.length > 100) {
                throw new Error('Category must between 2 and 100 symbols.');
            }
        }

        function validateAuthor(input) {
            if (input === '') {
                throw new Error('Author name cannot be empty string.');
            }
        }

        function validateISBN(input) {
            if (input.length !== 10 || input.length !== 13) {
                throw new Error('ISBN must be either 10 or 13 characters long.');
            }
        }

        function checkRepeatingParameters() {
            for (var i = 0; i < books.length; i+=1) {
                if (books[i].title === book.title) {
                    throw new Error('Title already exists.');
                }
                if (books[i].isbn === book.isbn) {
                    throw new Error('ISBN already exists.');
                }
            }
        }

        function addCategory(name) {
            categories[name] = {
                books: [],
                ID: categories.length + 1
            };
        }

        function addBook(book) {

            book.ID = books.length + 1;

            checkParameters(book);
            validateTitle(book.title);
            validateCategory(book.category);
            validateAuthor(book.author);
            validateISBN(book.isbn);
            checkRepeatingParameters();
            categories[book.category].books.push(book);

            books.push(book);
            return book;
        }

        function listCategories(category) {

            var categoriesNames = [];
            Array.prototype.push.apply(categoriesNames, Object.keys(categories));

            return categoriesNames;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());

    return library;
}

module.exports = solve;
