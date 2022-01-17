using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDependencyInjectionExample.TireTypes.Types
{
    public class StreetTire : ITireType
    {
        public string TireType { get; set; }

        public string Brand { get; set; }

        public StreetTire(string brand)
        {
            TireType = "Street Tire";
            this.Brand = brand;
        }

    }
}
