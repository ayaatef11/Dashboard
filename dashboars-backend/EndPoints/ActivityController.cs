using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class ActivityController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;


  [HttpGet]
    public async Task<ActionResult<IEnumerable<Activity>>> GetActivitys()
    {
        return await _context.Activitys.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivity(int id)
    {
        var activity = await _context.Activitys.FindAsync(id);

        if (activity == null)
        {
            return NotFound();
        }

        return activity;
    }

    [HttpPost]
    public async Task<ActionResult<Activity>> CreateActivity(Activity activity)
    {
        _context.Activitys.Add(activity);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetActivity), new { id = activity.Id }, activity);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateActivity(int id, Activity updatedActivity)
    {
        if (id != updatedActivity.Id)
        {
            return BadRequest();
        }

        _context.Entry(updatedActivity).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ActivityExists(id))
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
    public async Task<IActionResult> DeleteActivity(int id)
    {
        var activity = await _context.Activitys.FindAsync(id);
        if (activity == null)
        {
            return NotFound();
        }

        _context.Activitys.Remove(activity);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ActivityExists(int id)
    {
        return _context.Activitys.Any(e => e.Id == id);
    }
}
