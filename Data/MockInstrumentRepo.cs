using InstrumentShop.Models;

namespace InstrumentShop.Data

{
    public class MockInstrumentRepo : IInstrumentRepo
    {
        public IEnumerable<Instrument> GetAllInstruments()
        {
            var instruments = new List<Instrument>
            {
                new Instrument { Id = 1, Name = "Trumpet", Family = "Brass", Price = 999.99m },
                new Instrument { Id = 2, Name = "Trombone", Family = "Brass", Price = 1999.99m },
                new Instrument { Id = 3, Name = "Tuba", Family = "Brass", Price = 8999.99m },
                new Instrument { Id = 4, Name = "French Horn", Family = "Brass", Price = 12999.99m },
                new Instrument { Id = 5, Name = "Violin", Family = "String", Price = 99999.64m },
                new Instrument { Id = 6, Name = "Clarinet", Family = "Woodwind", Price = 499.54m }
            };
            return instruments;
        }

        public Instrument GetInstrumentById(int id)
        {
            return new Instrument { Id = 4, Name = "French Horn", Family = "Brass", Price = 12999.99m };
        }
    }
}