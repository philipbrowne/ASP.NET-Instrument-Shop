using InstrumentShop.Data;
using InstrumentShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstrumentShop.Controllers 

{
    // /api/commands
    [Route("api/instruments")]
    [ApiController]
    public class InstrumentsController : ControllerBase
    {
        private readonly IInstrumentRepo _repository;
        public InstrumentsController(IInstrumentRepo repository)
        {
            _repository = repository;
        }
        
        // GET api/commands/
        [HttpGet]
        public ActionResult <IEnumerable<Instrument>> GetAllInstruments()
        {
            var instrumentItems = _repository.GetAllInstruments();
            return Ok(instrumentItems);
        }
        // GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Instrument> GetInstrumentById(int id)
        {
            var instrumentItem = _repository.GetInstrumentById(id);
            return Ok(instrumentItem);
        }
    }
}