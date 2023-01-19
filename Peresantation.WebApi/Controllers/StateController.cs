using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostModule.Application.Contract.StateQuery;

namespace Peresantation.WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/State")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateQuery _stateQuery;
        public StateController(IStateQuery stateQuery)
        {
            _stateQuery = stateQuery;
        }
        /// <summary>
        /// دریافت لیست استان ها به همره شهرهای آن و کد شهر
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _stateQuery.GetStatesWithCity();
            return Ok(model);
        }
    }
}
