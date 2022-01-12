using InstrumentShop.Models;
// Interface
namespace InstrumentShop.Data
{
    public interface IInstrumentRepo 
    {
        bool SaveChanges();
        IEnumerable<Instrument> GetAllInstruments();
        Instrument GetInstrumentById(int id);
        void CreateInstrument(Instrument inst);
        void UpdateInstrument(Instrument inst);

    }
}