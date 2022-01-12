using InstrumentShop.Models;

namespace InstrumentShop.Data

{
    public class SqlInstrumentRepo : IInstrumentRepo
    {
        private readonly InstrumentContext _context;

        public SqlInstrumentRepo(InstrumentContext context)
        {
            _context = context;
        }
        public IEnumerable<Instrument> GetAllInstruments()
        {
            return _context.Instruments.ToList();
        }

        public Instrument GetInstrumentById(int id)
        {
            return _context.Instruments.FirstOrDefault(p => p.Id == id);
        }
    }
}