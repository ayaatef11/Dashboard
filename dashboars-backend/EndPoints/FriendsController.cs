using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[EnableCors("AllowAngularApp")]

    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController(AppDbContext dbContext) : ControllerBase
    {
        private readonly AppDbContext _dbContext = dbContext;

  [HttpGet]
        public async Task<ActionResult<IEnumerable<Friend>>> Get()
        {
            var Friends = await _dbContext.Friends.ToListAsync();
            return Ok(Friends);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Friend>> Get(string id)
        {
            var Friend = await _dbContext.Friends.FindAsync(id);
            if (Friend == null)
            {
                return NotFound();
            }

            return Ok(Friend);
        }

        [HttpPost]
        public async Task<ActionResult<Friend>> Post([FromBody] Friend Friend)
        {
            if (Friend == null)
            {
                return BadRequest();
            }

            _dbContext.Friends.Add(Friend);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Friend.Id }, Friend);
        }

        //[HttpPut("{id}")]
        // public async Task<IActionResult> Put(string id, [FromBody] Friend Friend)
        // {
        //     var existingFriend = await _dbContext.Friends.FindAsync(id);
        //     if (existingFriend == null)
        //     {
        //         return NotFound();
        //     }

        //     existingFriend.Label = Friend.Label;
        //     existingFriend.Type = Friend.Type;
        //     existingFriend.Placeholder = Friend.Placeholder;
        //     existingFriend.Value = Friend.Value;
        //     existingFriend.Disabled = Friend.Disabled;
        //     existingFriend.ShowLink = Friend.ShowLink;

        //     await _dbContext.SaveChangesAsync();

        //     return NoContent();
        // }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var Friend = await _dbContext.Friends.FindAsync(id);
            if (Friend == null)
            {
                return NotFound();
            }

            _dbContext.Friends.Remove(Friend);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }

