using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTASKS
{
    // Book class with properties for nickname, author, and pages per book
    public class Book
    {
        public string nickName;
        public string author;
        public int perPage;
        // Constructor to initialize the Book object with nickname, author, and pages per book
        public Book(string nickName, string author, int perPage)
        {
            this.nickName = nickName;
            this.author = author;
            this.perPage = perPage;
        }
    }
}
