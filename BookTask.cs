using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTASKS
{
    public class Book
    {
        public string nickName;
        public string author;
        public int perPage;
        public Book(string nickName, string author, int perPage)
        {
            this.nickName = nickName;
            this.author = author;
            this.perPage = perPage;
        }
    }
}
