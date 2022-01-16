using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDependencyInjectionExample
{
    public class DirtTire : ITireType
    {
        public string TireType { get; set; }
        public string Brand { get; set; }

        public DirtTire(string brand)
        {
            TireType = "Dirt Tire";
            this.Brand = brand;
        }

    }
}
