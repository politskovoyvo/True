using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTestMVVM.Model
{
    class Person
    {
        int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        string Name { get; set; }
        string fName { get; set; }
        string EMail { get; set; }
        string Status { get; set; }
        int k { get; set; }         //личный коэффициент (расчетный со временем)

        public List<Person> persons = new List<Person>();
    }
}
