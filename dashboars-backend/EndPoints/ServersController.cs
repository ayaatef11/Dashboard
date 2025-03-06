using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


    [Route("api/[controller]")]
    [ApiController]
    public class ServerController : ControllerBase
    {
        // Temporary in-memory data store for Servers (You would typically use a database here)
        private static List<Server> servers = new List<Server>
        {
            new Server("1", "Server A", true),
            new Server("2", "Server B", false)
        };

        // GET: api/Server
        [HttpGet]
        public ActionResult<IEnumerable<Server>> Get()
        {
            return Ok(servers);
        }

        // GET: api/Server/5
        [HttpGet("{id}")]
        public ActionResult<Server> Get(string id)
        {
            var server = servers.FirstOrDefault(s => s.Id == id);
            if (server == null)
            {
                return NotFound();
            }

            return Ok(server);
        }

        // POST: api/Server
        [HttpPost]
        public ActionResult<Server> Post([FromBody] Server server)
        {
            if (server == null)
            {
                return BadRequest();
            }

            servers.Add(server);
            return CreatedAtAction(nameof(Get), new { id = server.Id }, server);
        }

        // PUT: api/Server/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Server server)
        {
            var existingServer = servers.FirstOrDefault(s => s.Id == id);
            if (existingServer == null)
            {
                return NotFound();
            }

            existingServer.Name = server.Name;
            existingServer.Checked = server.Checked;

            return NoContent();
        }

        // DELETE: api/Server/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var server = servers.FirstOrDefault(s => s.Id == id);
            if (server == null)
            {
                return NotFound();
            }

            servers.Remove(server);
            return NoContent();
        }
    }

