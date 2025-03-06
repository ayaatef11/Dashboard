using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        // Constructor to inject AppDbContext
        public SocialMediaController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/SocialMedia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SocialMedia>>> Get()
        {
            // Retrieve all social media entries from the database
            var socialMedias = await _dbContext.SocialMedias.ToListAsync();
            return Ok(socialMedias);
        }

        // GET: api/SocialMedia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SocialMedia>> Get(string id)
        {
            // Find a specific social media entry by ID
            var socialMedia = await _dbContext.SocialMedias.FindAsync(id);
            if (socialMedia == null)
            {
                return NotFound();
            }

            return Ok(socialMedia);
        }

        // POST: api/SocialMedia
        [HttpPost]
        public async Task<ActionResult<SocialMedia>> Post([FromBody] SocialMedia socialMedia)
        {
            if (socialMedia == null)
            {
                return BadRequest();
            }

            // Add the new social media entry to the database
            _dbContext.SocialMedias.Add(socialMedia);
            await _dbContext.SaveChangesAsync();

            // Return the created social media entry with the location of the new resource
            return CreatedAtAction(nameof(Get), new { id = socialMedia.Id }, socialMedia);
        }

        // PUT: api/SocialMedia/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] SocialMedia socialMedia)
        {
            var existingSocialMedia = await _dbContext.SocialMedias.FindAsync(id);
            if (existingSocialMedia == null)
            {
                return NotFound();
            }

            // Update the existing social media entry's properties
            existingSocialMedia.Icon = socialMedia.Icon;
            existingSocialMedia.Placeholder = socialMedia.Placeholder;

            // Save the changes to the database
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/SocialMedia/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var socialMedia = await _dbContext.SocialMedias.FindAsync(id);
            if (socialMedia == null)
            {
                return NotFound();
            }

            // Remove the social media entry from the database
            _dbContext.SocialMedias.Remove(socialMedia);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
