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

        public void CreateInstrument(Instrument inst)
        {
            if(inst == null)
            {
                throw new ArgumentNullException(nameof(inst));
            }
            _context.Instruments.Add(inst);
        }

        public void DeleteInstrument(Instrument inst)
        {
            if(inst == null)
            {
                throw new ArgumentNullException(nameof(inst));
            }
            _context.Instruments.Remove(inst);
        }

        public IEnumerable<Instrument> GetAllInstruments()
        {
            return _context.Instruments.ToList();
        }

        public Instrument GetInstrumentById(int id)
        {
            return _context.Instruments.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateInstrument(Instrument inst)
        {
        }
    }
}