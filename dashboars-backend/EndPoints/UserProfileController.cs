using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class UserProfileController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

  [HttpGet]
    public async Task<ActionResult<IEnumerable<UserProfile>>> GetUserProfiles()
    {
        return await _context.UsersProfiles.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserProfile>> GetUserProfile(int id)
    {
        var userProfile = await _context.UsersProfiles.FindAsync(id);

        if (userProfile == null)
        {
            return NotFound();
        }

        return userProfile;
    }

    [HttpPost]
    public async Task<ActionResult<UserProfile>> CreateUserProfile(UserProfile userProfile)
    {
        _context.UsersProfiles.Add(userProfile);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetUserProfile), new { id = userProfile.Id }, userProfile);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUserProfile(int id, UserProfile updatedUserProfile)
    {
        if (id != updatedUserProfile.Id)
        {
            return BadRequest();
        }

        _context.Entry(updatedUserProfile).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!UserProfileExists(id))
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
    public async Task<IActionResult> DeleteUserProfile(int id)
    {
        var userProfile = await _context.UsersProfiles.FindAsync(id);
        if (userProfile == null)
        {
            return NotFound();
        }

        _context.UsersProfiles.Remove(userProfile);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool UserProfileExists(int id)
    {
        return _context.UsersProfiles.Any(e => e.Id == id);
    }
}
