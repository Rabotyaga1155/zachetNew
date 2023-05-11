using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachet
{
    class Country
    {
        public int Id { get; set; }
        public string Na { get; set; }
        public Country(int id,string na)
        {
            Id = id;
            Na = na;
        }
            
    }
}
