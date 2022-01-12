using InstrumentShop.Models;
// Interface
namespace InstrumentShop.Data
{
    public interface IInstrumentRepo 
    {
        IEnumerable<Instrument> GetAllInstruments();
        Instrument GetInstrumentById(int id);

    }
}