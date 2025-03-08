using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class SocialPlatformController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

  [HttpGet]
    public async Task<ActionResult<IEnumerable<SocialPlatform>>> GetSocialPlatforms()
    {
        return await _context.SocialPlatforms.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SocialPlatform>> GetSocialPlatform(int id)
    {
        var socialPlatform = await _context.SocialPlatforms.FindAsync(id);

        if (socialPlatform == null)
        {
            return NotFound();
        }

        return socialPlatform;
    }

    [HttpPost]
    public async Task<ActionResult<SocialPlatform>> CreateSocialPlatform(SocialPlatform socialPlatform)
    {
        _context.SocialPlatforms.Add(socialPlatform);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetSocialPlatform), new { id = socialPlatform.Id }, socialPlatform);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSocialPlatform(int id, SocialPlatform updatedPlatform)
    {
        if (id != updatedPlatform.Id)
        {
            return BadRequest();
        }

        _context.Entry(updatedPlatform).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!SocialPlatformExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSocialPlatform(int id)
    {
        var socialPlatform = await _context.SocialPlatforms.FindAsync(id);
        if (socialPlatform == null)
        {
            return NotFound();
        }

        _context.SocialPlatforms.Remove(socialPlatform);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool SocialPlatformExists(int id)
    {
        return _context.SocialPlatforms.Any(e => e.Id == id);
    }
}
