using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    class AutoSale
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Car> Cars { get; set; }

        public AutoSale(List<Car> cars, string name = "", string address = "")
        {
            Name = name;
            Address = address;
            Cars = cars;
        }

    }
}
