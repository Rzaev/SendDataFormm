using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendDataForm
{
    public class User
    {

        public string Name { get; set; }
        public string Country { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Name} {Country} {Price}";
        }
    }
}
