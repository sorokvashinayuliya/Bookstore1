using System;
using System.Reflection;

namespace Bookstore1
{
    public class Company
    {
        public static implicit operator Company(AssemblyCompanyAttribute v)
        {
            throw new NotImplementedException();
        }
    }
}