using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[EnableCors("AllowAngularApp")]

    [Route("api/[controller]")]
    [ApiController]
    public class GeneralInfosController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        // Constructor that injects the AppDbContext
        public GeneralInfosController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/GeneralInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneralInfo>>> Get()
        {
            // Get all GeneralInfo from the database
            var generalInfos = await _dbContext.GeneralInfos.ToListAsync();
            return Ok(generalInfos);
        }

        // GET: api/GeneralInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GeneralInfo>> Get(string id)
        {
            // Find a specific GeneralInfo by id
            var generalInfo = await _dbContext.GeneralInfos.FindAsync(id);
            if (generalInfo == null)
            {
                return NotFound();
            }

            return Ok(generalInfo);
        }

        [HttpPost]
        public async Task<ActionResult<GeneralInfo>> Post([FromBody] GeneralInfo generalInfo)
        {
            if (generalInfo == null)
            {
                return BadRequest();
            }

            _dbContext.GeneralInfos.Add(generalInfo);
            await _dbContext.SaveChangesAsync();

            // Return the created GeneralInfo with the location of the new resource
            return CreatedAtAction(nameof(Get), new { id = generalInfo.Id }, generalInfo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] GeneralInfo generalInfo)
        {
            var existingGeneralInfo = await _dbContext.GeneralInfos.FindAsync(id);
            if (existingGeneralInfo == null)
            {
                return NotFound();
            }

            existingGeneralInfo.Label = generalInfo.Label;
            existingGeneralInfo.Type = generalInfo.Type;
            existingGeneralInfo.Placeholder = generalInfo.Placeholder;
            existingGeneralInfo.Value = generalInfo.Value;
            existingGeneralInfo.Disabled = generalInfo.Disabled;
            existingGeneralInfo.ShowLink = generalInfo.ShowLink;

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var generalInfo = await _dbContext.GeneralInfos.FindAsync(id);
            if (generalInfo == null)
            {
                return NotFound();
            }

            _dbContext.GeneralInfos.Remove(generalInfo);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }

