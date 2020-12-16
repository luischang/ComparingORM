using ComparingORM.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ComparingORM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPerson()
        {
            var persons = await _personRepository.GetPerson();
            //var customersDTO = _mapper.Map<IEnumerable<CustomerDTO>>(customers);
            //var response = new ApiResponse<IEnumerable<CustomerDTO>>(customersDTO);
            return Ok(persons);
        }



    }
}
