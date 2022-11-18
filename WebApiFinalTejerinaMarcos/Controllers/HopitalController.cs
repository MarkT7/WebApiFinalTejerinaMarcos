using Microsoft.AspNetCore.Mvc;
using System;
using WebApiFinalTejerinaMarcos.DataAccess;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiFinalTejerinaMarcos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HopitalController : ControllerBase
    {
        // GET: api/<HopitalController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HopitalController>/5
        [HttpGet("{id}")]
        public string GetDoctor()
        {
            return await Hospital.Doctor.ToListAsync();
        }

        // POST api/<HopitalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HopitalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var result = await appDbContext.Hospital.AddAsync(Doctor);
            await Hospital.SaveChangesAsync();
            return result.Entity;
        }

        // DELETE api/<HopitalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Doctor doc = Hospital.GetDoctor(id);
            
            _doc.Remove(doc);
            var response = new HttpResponseMessage();
            response.Headers.Add("DeleteMessage", "Eliminado");
            return response;
        }
    }
}
