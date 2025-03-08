using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[EnableCors("AllowAngularApp")]

    [Route("api/[controller]")]
    [ApiController]
    public class ServerController(AppDbContext dbContext) : ControllerBase
    {
        private readonly AppDbContext _dbContext = dbContext;

  [HttpGet]
        public async Task<ActionResult<IEnumerable<Server>>> Get()
        {
            var servers = await _dbContext.Servers.ToListAsync();
            return Ok(servers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Server>> Get(string id)
        {
            var server = await _dbContext.Servers.FindAsync(id);
            if (server == null)
            {
                return NotFound();
            }

            return Ok(server);
        }

        [HttpPost]
        public async Task<ActionResult<Server>> Post([FromBody] Server server)
        {
            if (server == null)
            {
                return BadRequest();
            }

            _dbContext.Servers.Add(server);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = server.Id }, server);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Server server)
        {
            var existingServer = await _dbContext.Servers.FindAsync(id);
            if (existingServer == null)
            {
                return NotFound();
            }

            existingServer.Name = server.Name;
            existingServer.Checked = server.Checked;

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var server = await _dbContext.Servers.FindAsync(id);
            if (server == null)
            {
                return NotFound();
            }

            _dbContext.Servers.Remove(server);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }

