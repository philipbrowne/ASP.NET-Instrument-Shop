using AutoMapper;
using InstrumentShop.Data;
using InstrumentShop.Dtos;
using InstrumentShop.Models;
using Microsoft.AspNetCore.JsonPatch;
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
        
        // GET /api/instruments/
        [HttpGet]
        public ActionResult <IEnumerable<InstrumentReadDto>> GetAllInstruments()
        {
            var instrumentItems = _repository.GetAllInstruments();
            return Ok(_mapper.Map<IEnumerable<InstrumentReadDto>>(instrumentItems));
        }
        // GET /api/instruments/{id}
        [HttpGet("{id}", Name="GetInstrumentById")]
        public ActionResult <InstrumentReadDto> GetInstrumentById(int id)
        {
            var instrumentItem = _repository.GetInstrumentById(id);
            if (instrumentItem != null) {
                return Ok(_mapper.Map<InstrumentReadDto>(instrumentItem));
            }
            return NotFound();
        }
        // POST /api/instruments/
        [HttpPost]
         public ActionResult <InstrumentReadDto> CreateInstrument(InstrumentCreateDto instrumentCreateDto)
        {
            var instrumentModel = _mapper.Map<Instrument>(instrumentCreateDto);
            _repository.CreateInstrument(instrumentModel);
            _repository.SaveChanges();
            var instrumentReadDto = _mapper.Map<InstrumentReadDto>(instrumentModel);
            return CreatedAtRoute(nameof(GetInstrumentById), new { Id = instrumentReadDto.Id }, instrumentReadDto);
            // return Ok(instrumentReadDto);
        } 
        // PUT /api/instruments/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateInstrument(int id, InstrumentUpdateDto instrumentUpdateDto)
        {
            var instrumentModelFromRepo = _repository.GetInstrumentById(id);
            if (instrumentModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(instrumentUpdateDto, instrumentModelFromRepo);
            _repository.UpdateInstrument(instrumentModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        //PATCH /api/instruments/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialInstrumentUpdate(int id, JsonPatchDocument<InstrumentUpdateDto> patchDoc)
        {
            var instrumentModelFromRepo = _repository.GetInstrumentById(id);
            if (instrumentModelFromRepo == null)
            {
                return NotFound();
            }
            var instrumentToPatch = _mapper.Map<InstrumentUpdateDto>(instrumentModelFromRepo);
            patchDoc.ApplyTo(instrumentToPatch, ModelState);
            if (!TryValidateModel(instrumentToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(instrumentToPatch, instrumentModelFromRepo);
            _repository.UpdateInstrument(instrumentModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
        //DELETE api/instruments/
        [HttpDelete("{id}")]
        public ActionResult DeleteInstrument(int id)
        {
            var instrumentModelFromRepo = _repository.GetInstrumentById(id);
            if (instrumentModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteInstrument(instrumentModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}