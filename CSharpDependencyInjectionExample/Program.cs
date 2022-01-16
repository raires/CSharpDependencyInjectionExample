
using CSharpDependencyInjectionExample;

Console.WriteLine("Hello, World!");

Console.WriteLine();

ITireType DirtBoy = new DirtTire("MK2 Dirt Tires");
TireService DTire = new TireService(DirtBoy);
DTire.ShowTire();

Console.WriteLine();

ITireType StdTire = new StreetTire("Standard Tires");
TireService STire = new TireService(StdTire);
STire.ShowTire();
