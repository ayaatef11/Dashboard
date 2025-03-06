using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

    [Route("api/[controller]")]
    [ApiController]
    public class WidgetController : ControllerBase
    {
        // Temporary in-memory data store for Widgets (You would typically use a database here)
        private static List<Widget> widgets = new List<Widget>
        {
            new Widget("1", "Widget A", true),
            new Widget("2", "Widget B", false)
        };

        // GET: api/Widget
        [HttpGet]
        public ActionResult<IEnumerable<Widget>> Get()
        {
            return Ok(widgets);
        }

        // GET: api/Widget/5
        [HttpGet("{id}")]
        public ActionResult<Widget> Get(string id)
        {
            var widget = widgets.FirstOrDefault(w => w.Id == id);
            if (widget == null)
            {
                return NotFound();
            }

            return Ok(widget);
        }

        // POST: api/Widget
        [HttpPost]
        public ActionResult<Widget> Post([FromBody] Widget widget)
        {
            if (widget == null)
            {
                return BadRequest();
            }

            widgets.Add(widget);
            return CreatedAtAction(nameof(Get), new { id = widget.Id }, widget);
        }

        // PUT: api/Widget/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Widget widget)
        {
            var existingWidget = widgets.FirstOrDefault(w => w.Id == id);
            if (existingWidget == null)
            {
                return NotFound();
            }

            existingWidget.Name = widget.Name;
            existingWidget.Checked = widget.Checked;

            return NoContent();
        }

        // DELETE: api/Widget/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var widget = widgets.FirstOrDefault(w => w.Id == id);
            if (widget == null)
            {
                return NotFound();
            }

            widgets.Remove(widget);
            return NoContent();
        }
    }
