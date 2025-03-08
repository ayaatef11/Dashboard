using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[EnableCors("AllowAngularApp")]

    [Route("api/[controller]")]
    [ApiController]
    public class FilesController(AppDbContext dbContext) : ControllerBase
    {
        private readonly AppDbContext _dbContext = dbContext;

  [HttpGet]
        public async Task<ActionResult<IEnumerable<File>>> Get()
        {
            var Files = await _dbContext.Files.ToListAsync();
            return Ok(Files);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<File>> Get(string id)
        {
            var File = await _dbContext.Files.FindAsync(id);
            if (File == null)
            {
                return NotFound();
            }

            return Ok(File);
        }

        [HttpPost]
        public async Task<ActionResult<File>> Post([FromBody] File File)
        {
            if (File == null)
            {
                return BadRequest();
            }

            _dbContext.Files.Add(File);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = File.Id }, File);
        }

        //[HttpPut("{id}")]
        // public async Task<IActionResult> Put(string id, [FromBody] File File)
        // {
        //     var existingFile = await _dbContext.Files.FindAsync(id);
        //     if (existingFile == null)
        //     {
        //         return NotFound();
        //     }

        //     existingFile.Label = File.Label;
        //     existingFile.Type = File.Type;
        //     existingFile.Placeholder = File.Placeholder;
        //     existingFile.Value = File.Value;
        //     existingFile.Disabled = File.Disabled;
        //     existingFile.ShowLink = File.ShowLink;

        //     await _dbContext.SaveChangesAsync();

        //     return NoContent();
        // }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var File = await _dbContext.Files.FindAsync(id);
            if (File == null)
            {
                return NotFound();
            }

            _dbContext.Files.Remove(File);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }

