using NUnit.Framework;
using CSharpDependencyInjectionExample;

namespace CSharpDependencyInjection.Tests.UnitTests
{
    [TestFixture]
    public class TireServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTireService()
        {

            ITireType DirtBoy = new DirtTire("Dirt Boy");
            var tireService = new TireService(DirtBoy);

            var result1 = tireService.ReturnTire();

            Assert.That(result1, Is.Not.Null);
            Assert.That(result1, Does.Contain("Dirt Boy").IgnoreCase.And.Contain("Dirt Tire").IgnoreCase);


            ITireType StdTire = new DirtTire("Street Tires Ltd");
            var tireService2 = new TireService(StdTire);

            var result2 = tireService2.ReturnTire();

            Assert.That(result2, Is.Not.Null);
            Assert.That(result2, Does.Contain("Street Tires Ltd").IgnoreCase.And.Contain("Street Tire").IgnoreCase);
        }
    }
}