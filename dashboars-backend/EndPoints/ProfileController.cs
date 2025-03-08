using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
[EnableCors("AllowAngularApp")]


    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ActivitysController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Activity>>> Get()
        {
            var Activitys = await _dbContext.Activitys.ToListAsync();
            return Ok(Activitys);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> Get(string id)
        {
            var Activity = await _dbContext.Activitys.FindAsync(id);
            if (Activity == null)
            {
                return NotFound();
            }

            return Ok(Activity);
        }

        [HttpPost]
        public async Task<ActionResult<Activity>> Post([FromBody] Activity Activity)
        {
            if (Activity == null)
            {
                return BadRequest();
            }

            _dbContext.Activitys.Add(Activity);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Activity.Id }, Activity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Activity Activity)
        {
            var existingActivity = await _dbContext.Activitys.FindAsync(id);
            if (existingActivity == null)
            {
                return NotFound();
            }

            existingActivity.Label = Activity.Label;
            existingActivity.Checked = Activity.Checked;

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var Activity = await _dbContext.Activitys.FindAsync(id);
            if (Activity == null)
            {
                return NotFound();
            }

            _dbContext.Activitys.Remove(Activity);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }

