using CSharpDependencyInjectionExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDependencyInjection.Tests.UnitTests
{
    internal class FakeTire : ITireType
    {
        public string TireType { get; set; }

        public string Brand { get; set; }
    }
}
