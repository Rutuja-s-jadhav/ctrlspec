using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ctrlspec.DTO;
using ctrlspec.Models;
using ctrlspec.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ctrlspec.Controllers
{
    [ApiController]
    // [Route("[controller]")]
    public class Spec_OptionController : ControllerBase
    {
        private ISpec _spec;
        private readonly IMapper _mapper;

        public Spec_OptionController(ISpec spec, IMapper mapper)
        {
            _spec = spec;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("GetSpec_option")]
         public async Task<IActionResult> GetDetails()
        {

          try
            {
                var data = await _spec.GetQuestions();
                return Ok(_mapper.Map<List<Spec_Option>>(data));
            }
            catch (Exception e) {
                return BadRequest("Error in Controller method GetEmployee"+ e);
            }

        }

        [HttpPost]
        [Route("AddSpec_Option")]
        public async Task<IActionResult> AddSpec_Option(Spec_Option spec)
        {
                //  var result = _mapper.Map<Spec_Option>(spec);

                //Pass Detail to Repository
                var response = await _spec.AddSpec_Option(spec);

                //Convert back to DTO
                // var specDTO = _mapper.Map<Spec_OptionDTO>(response);

                return Ok(response);
        }
        [HttpPut]
        [Route("Edit/{id}")]
        public async Task<IActionResult> EditRequest(double id, Spec_Option spec)
        {
            
            var response = await _spec.EditSpec_Option(id, spec);
            if (response == null)
            {
                return BadRequest();
            }
            return Ok(spec);
            // var usr = await _spec.EditSpec_Option(Ques, spec);
            // if(usr == null)
            // {
            //     return NoContent();
            // }
            // return Ok(usr);
        }
    }
}