using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class FeatureController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

  [HttpGet]
    public async Task<ActionResult<IEnumerable<Feature>>> GetFeatures()
    {
        return await _context.Features.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Feature>> GetFeature(int id)
    {
        var feature = await _context.Features.FindAsync(id);

        if (feature == null)
        {
            return NotFound();
        }

        return feature;
    }

    [HttpPost]
    public async Task<ActionResult<Feature>> CreateFeature(Feature feature)
    {
        _context.Features.Add(feature);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetFeature), new { id = feature.Id }, feature);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateFeature(int id, Feature updatedFeature)
    {
        if (id != updatedFeature.Id)
        {
            return BadRequest();
        }

        _context.Entry(updatedFeature).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!FeatureExists(id))
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
    public async Task<IActionResult> DeleteFeature(int id)
    {
        var feature = await _context.Features.FindAsync(id);
        if (feature == null)
        {
            return NotFound();
        }

        _context.Features.Remove(feature);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool FeatureExists(int id)
    {
        return _context.Features.Any(e => e.Id == id);
    }
}
