using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDependencyInjectionExample
{
    public class TireService
    {
        private ITireType _tireType;

        public TireService(ITireType TireType)
        {
            _tireType = TireType;
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
