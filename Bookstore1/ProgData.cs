using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore1
{
    public class ProgData
    {
        public List<Books> Book { get; set; }
        public List<Games> Game { get; set; }
        public List<Hobbies> Hobby { get; set; }

        public ProgData()
        {
            Book = new List<Books>();
            Game = new List<Games>();
            Hobby = new List<Hobbies>();
        }
    }
}
