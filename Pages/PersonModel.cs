using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickGrid.Pages
{
    public class Person
    {
        public int Id { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }
        public bool Active { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}