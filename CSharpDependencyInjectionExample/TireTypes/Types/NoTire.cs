using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDependencyInjectionExample.TireTypes.Types
{
    public class NoTire : ITireType
    {
        public string TireType { get; set; }
        public string Brand { get; set; }

        public NoTire(string brand)
        {
            TireType = "No Tire";
            this.Brand = brand;
        }
    }
}
