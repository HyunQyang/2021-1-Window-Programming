using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfoWIndowApp
{
    class Book
    {
       private string title;
       private string author;
       private int page;
       private string ISBN;
       private string publisher;

        public Book (string title,string author, int page, string ISBN,string publisher)
        {
            
            this.title = title;
            this.author = author;
            this.page = page;
            this.ISBN = ISBN;
            this.publisher = publisher;
            
        }
        public string Title
          {
              get
              {
                  return title;
              }
              set
              {
                  this.title = value;
              }
          }
        
        public override string ToString()
        {
            return "Title: " + title + "\nAutor: "+author + "\npage: "+page+
                "\nISBN:"+ISBN + "\npublisher:"+ publisher;
        }
    }
}
