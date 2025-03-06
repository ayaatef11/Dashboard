using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[EnableCors("AllowAngularApp")]

    [Route("api/[controller]")]
    [ApiController]
    public class ServerController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        // Constructor to inject AppDbContext
        public ServerController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Server
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Server>>> Get()
        {
            // Retrieve all servers from the database
            var servers = await _dbContext.Servers.ToListAsync();
            return Ok(servers);
        }

        // GET: api/Server/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Server>> Get(string id)
        {
            // Find a specific server by ID
            var server = await _dbContext.Servers.FindAsync(id);
            if (server == null)
            {
                return NotFound();
            }

            return Ok(server);
        }

        // POST: api/Server
        [HttpPost]
        public async Task<ActionResult<Server>> Post([FromBody] Server server)
        {
            if (server == null)
            {
                return BadRequest();
            }

            // Add the new server to the database
            _dbContext.Servers.Add(server);
            await _dbContext.SaveChangesAsync();

            // Return the created server with the location of the new resource
            return CreatedAtAction(nameof(Get), new { id = server.Id }, server);
        }

        // PUT: api/Server/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Server server)
        {
            var existingServer = await _dbContext.Servers.FindAsync(id);
            if (existingServer == null)
            {
                return NotFound();
            }

            // Update the existing server's properties
            existingServer.Name = server.Name;
            existingServer.Checked = server.Checked;

            // Save the changes to the database
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Server/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var server = await _dbContext.Servers.FindAsync(id);
            if (server == null)
            {
                return NotFound();
            }

            // Remove the server from the database
            _dbContext.Servers.Remove(server);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }

