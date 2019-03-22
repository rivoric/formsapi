using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dicci.forms.api.Models;

namespace dicci.forms.api.Controllers
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Context _context;

        public ValuesController(Context context)
        {
            _context = context;

            if (_context.Items.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all Items.
                _context.Items.Add(new ListItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListItem>>> Get()
        {
            return await _context.Items.ToListAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
