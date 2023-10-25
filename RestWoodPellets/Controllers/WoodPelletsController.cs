using WoodPelletsLib;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace RestWoodPellets.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WoodPelletsController : ControllerBase
    {
        private WoodPelletRepository _data;

        public WoodPelletsController(WoodPelletRepository data)
        {
            _data = data;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get()
        {
            IEnumerable<WoodPellet> woodpellets = _data.GetAllPellets();

            if (woodpellets.ToList().Count == 0)
            {
                return NoContent();
            }
            return Ok(woodpellets);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                WoodPellet woodpellet = _data.GetById(id);
                return Ok(woodpellet);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok(value); 
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok(value);
        }


        
    }
}
