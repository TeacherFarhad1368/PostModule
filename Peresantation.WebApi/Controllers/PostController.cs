using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostModule.Application.Contract.PostApplication;

namespace Peresantation.WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/Post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostApplication _postApplication;
        public PostController(IPostApplication postApplication)
        {
            _postApplication = postApplication;
        }
        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var model = _postApplication.GetAll();
            return Ok(model);
        }
        [HttpGet("[action]/{id}")]
        public IActionResult Get(int id)
        {
            var model = _postApplication.GetForEdit(id);
            return Ok(model);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreatePost model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = _postApplication.Create(model);
            if (res.Success) return Ok();
            return BadRequest(new { message = res.Message });
        }
        [HttpPatch("[action]")]
        public IActionResult Edit([FromBody] EditPost model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var res = _postApplication.Edit(model);
            if (res.Success) return NoContent();
            return BadRequest(new { message = res.Message });
        }
        [HttpPatch("[action]/{id}")]
        public IActionResult ChangeActive(int id)
        {
            if (_postApplication.ActivationChange(id)) return StatusCode(200);
            return NotFound();
        }
        [HttpPatch("[action]/{id}")]
        public IActionResult ChangeInsideCity(int id)
        {
            if (_postApplication.InsideCityChange(id)) return StatusCode(200);
            return NotFound();
        }
        [HttpPatch("[action]/{id}")]
        public IActionResult ChangeOutSideCity(int id)
        {
            if (_postApplication.OutSideCityChange(id)) return StatusCode(200);
            return NotFound();
        }
    }
}
