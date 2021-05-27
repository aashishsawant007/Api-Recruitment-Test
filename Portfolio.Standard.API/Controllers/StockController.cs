using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Standard.Contracts.BLL;
using Portfolio.Standard.Models;
using Swashbuckle.Swagger.Annotations;
using System;

namespace Portfolio.Standard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IBaseManager _baseManager;
        public StockController(IBaseManager baseManager)
        {
            _baseManager = baseManager;
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK)]
        public ActionResult<TestResultDTO> GetPing()
        {
            return Ok(new TestResultDTO { Now = DateTimeOffset.UtcNow });
        }

        //public async Task<IActionResult> GetPing()
        //{
        //    return Ok(new TestResultDTO { Now = DateTimeOffset.UtcNow });
        //}
    }
}
