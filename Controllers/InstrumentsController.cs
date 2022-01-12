using AutoMapper;
using InstrumentShop.Data;
using InstrumentShop.Dtos;
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
        private readonly IMapper _mapper;

        public InstrumentsController(IInstrumentRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        // GET api/instruments/
        [HttpGet]
        public ActionResult <IEnumerable<InstrumentReadDto>> GetAllInstruments()
        {
            var instrumentItems = _repository.GetAllInstruments();
            return Ok(_mapper.Map<IEnumerable<InstrumentReadDto>>(instrumentItems));
        }
        // GET api/instruments/{id}
        [HttpGet("{id}")]
        public ActionResult <InstrumentReadDto> GetInstrumentById(int id)
        {
            var instrumentItem = _repository.GetInstrumentById(id);
            if (instrumentItem != null) {
                return Ok(_mapper.Map<InstrumentReadDto>(instrumentItem));
            }
            return NotFound();
        }
        // POST api/instruments/
        [HttpPost]
         public ActionResult <InstrumentReadDto> CreateInstrument(InstrumentCreateDto instrumentCreateDto)
        {
            var instrumentModel = _mapper.Map<Instrument>(instrumentCreateDto);
            _repository.CreateInstrument(instrumentModel);
            _repository.SaveChanges();
            return Ok(instrumentModel);
        } 
    }
}