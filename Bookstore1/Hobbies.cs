using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore1
{
    [Serializable]
    public class Hobbies
    {
        public List<Hobby> BooksList { get; set; } = new List<Hobby>();
    }
    public class Hobby
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Company Company{ get; set; }
        public decimal Price { get; set; }
        public Specification Specification { get; set; }
        public Hobby() { }
        public Hobby(string Name, string Id, decimal Price, AssemblyCompanyAttribute Company, Specification Specification)
        {
            this.Name = Name;
            this.Id = Id;
            this.Price = Price;
            this.Specification = Specification;
            this.Company = Company;
        }

    }




}

