using InstrumentShop.Models;
using Microsoft.EntityFrameworkCore;

namespace InstrumentShop.Data

{
    public class InstrumentContext : DbContext
    {
        public InstrumentContext(DbContextOptions<InstrumentContext> opt) : base(opt)
        {
            
        }
        public DbSet<Instrument> Instruments { get; set; }
    }   
}