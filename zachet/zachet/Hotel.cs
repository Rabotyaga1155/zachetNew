using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachet
{
    class Hotel
    {

        public int TypeId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Hotel(int typeId,int id,string name,int price)
        {
            TypeId = typeId;
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
