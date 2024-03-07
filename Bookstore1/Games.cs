using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore1
{
    [Serializable]
    public class Games
    {
        public List<Game> BooksList { get; set; } = new List<Game>();
    }
    public class Game
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Age Age { get; set; }
        public decimal Price { get; set; }
        public Company Company { get; set; }
        public Game() { }
        public Game(string Name, string Id, decimal Price, Age Age, Company Company)
        {
            this.Name = Name;
            this.Id = Id;
            this.Price = Price;
            this.Company = Company;
            this.Age = Age;
        }

    }
}
