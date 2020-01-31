using System;
using System.Collections.Generic;

namespace csharp_vscode_pancake
{
    class Library
    {
        //constructor
        public Library(){
            Books = new List<Book>();
        }
        public string LibraryName;  //this is a "field"
        public List<Book> Books;

        public void Test(){
            var warAndPeace = new Book();
            warAndPeace.Age = 15;
            warAndPeace.Author = "Leo Tolstoy";
        }
    }
}