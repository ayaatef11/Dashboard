using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[EnableCors("AllowAngularApp")]

    [Route("api/[controller]")]
    [ApiController]
    public class GeneralInfosController(AppDbContext dbContext) : ControllerBase
    {
        private readonly AppDbContext _dbContext = dbContext;

  [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneralInfo>>> Get()
        {
            var generalInfos = await _dbContext.GeneralInfos.ToListAsync();
            return Ok(generalInfos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GeneralInfo>> Get(string id)
        {
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

