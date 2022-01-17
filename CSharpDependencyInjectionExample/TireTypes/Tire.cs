using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDependencyInjectionExample.TireTypes.Types;

namespace CSharpDependencyInjectionExample
{
    public class TireService
    {
        private ITireType _tireType;

        public TireService(ITireType? TireType = null)
        {
            _tireType = TireType ?? new NoTire("");
        }

        public void ShowTire()
        {
            Console.WriteLine("Tire Type: " + _tireType.TireType + "\nTire Brand: " + _tireType.Brand);
        }

        public string ReturnTire()
        {
            return "Tire Type: " + _tireType.TireType + "\nTire Brand: " + _tireType.Brand;
        }
    }
}
