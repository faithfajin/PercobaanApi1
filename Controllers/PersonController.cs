using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PercobaanApi1.Models;

namespace PercobaanApi1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("api/person")]
        public ActionResult<Person> ListPerson()
        {
            PersonContext context = new PersonContext();
            List<Person> ListPerson = context.ListPerson();
            return Ok(ListPerson);
        }


        [HttpGet("api/person/{id}")]
        public ActionResult GetPersonId(int id)
        {
            PersonContext context = new PersonContext();
            Person filterid = context.GetPersonId(id);
            
            if (filterid != null)
            {
                return Ok(filterid);
            }
            else
            {
                return NotFound(); 
            }
        }
    }
}