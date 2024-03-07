using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bookstore1
{
    [Serializable]
    public class Books
    {
        
        public List<Book> BooksList { get; set; } = new List<Book>();

    }
    public class Book
    {
        public string Name { get; set; }  
        public string Id { get; set; }  
        public Author Author { get; set; }  
        public decimal Price { get; set; }
        [XmlIgnore]
        public Publisher Publisher { get; set; }
        
        public Book() { }
        public Book(string Name, string Id, decimal Price, Author Author, Publisher Publisher)
        {
            this.Name = Name;
            this.Id = Id;
            this.Price = Price;
            this.Publisher = Publisher;
            this.Author = Author;
        }

    }
}
