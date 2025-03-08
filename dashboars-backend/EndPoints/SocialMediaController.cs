using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[EnableCors("AllowAngularApp")]

    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController(AppDbContext dbContext) : ControllerBase
    {
        private readonly AppDbContext _dbContext = dbContext;

  [HttpGet]
        public async Task<ActionResult<IEnumerable<SocialMedia>>> Get()
        {
            // Retrieve all social media entries from the database
            var socialMedias = await _dbContext.SocialMedias.ToListAsync();
            return Ok(socialMedias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SocialMedia>> Get(string id)
        {
            var socialMedia = await _dbContext.SocialMedias.FindAsync(id);
            if (socialMedia == null)
            {
                return NotFound();
            }

            return Ok(socialMedia);
        }

        [HttpPost]
        public async Task<ActionResult<SocialMedia>> Post([FromBody] SocialMedia socialMedia)
        {
            if (socialMedia == null)
            {
                return BadRequest();
            }

            _dbContext.SocialMedias.Add(socialMedia);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = socialMedia.Id }, socialMedia);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] SocialMedia socialMedia)
        {
            var existingSocialMedia = await _dbContext.SocialMedias.FindAsync(id);
            if (existingSocialMedia == null)
            {
                return NotFound();
            }

            existingSocialMedia.Icon = socialMedia.Icon;
            existingSocialMedia.Placeholder = socialMedia.Placeholder;

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var socialMedia = await _dbContext.SocialMedias.FindAsync(id);
            if (socialMedia == null)
            {
                return NotFound();
            }

            _dbContext.SocialMedias.Remove(socialMedia);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
