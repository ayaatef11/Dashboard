using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class KeywordController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

  [HttpGet]
    public async Task<ActionResult<IEnumerable<Keyword>>> GetKeywords()
    {
        return await _context.Keywords.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Keyword>> GetKeyword(int id)
    {
        var keyword = await _context.Keywords.FindAsync(id);

        if (keyword == null)
        {
            return NotFound();
        }

        return keyword;
    }

    [HttpPost]
    public async Task<ActionResult<Keyword>> CreateKeyword(Keyword keyword)
    {
        _context.Keywords.Add(keyword);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetKeyword), new { id = keyword.Id }, keyword);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateKeyword(int id, Keyword updatedKeyword)
    {
        if (id != updatedKeyword.Id)
        {
            return BadRequest();
        }

        _context.Entry(updatedKeyword).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!KeywordExists(id))
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
    public async Task<IActionResult> DeleteKeyword(int id)
    {
        var keyword = await _context.Keywords.FindAsync(id);
        if (keyword == null)
        {
            return NotFound();
        }

        _context.Keywords.Remove(keyword);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool KeywordExists(int id)
    {
        return _context.Keywords.Any(e => e.Id == id);
    }
}
