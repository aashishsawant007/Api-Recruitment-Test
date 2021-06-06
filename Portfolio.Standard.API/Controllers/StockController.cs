using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Standard.Contracts.BLL;
using Portfolio.Standard.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Threading.Tasks;

namespace Portfolio.Standard.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IBaseManager _baseManager;
        public StockController(IBaseManager baseManager)
        {
            _baseManager = baseManager;
        }

        //[HttpGet("PingMe","Ping")]
        //[SwaggerResponse(StatusCodes.Status200OK)]
        //public ActionResult<TestResultDTO> GetPing()
        //{
        //    return Ok(new TestResultDTO { Now = DateTimeOffset.UtcNow });
        //}


        [HttpPost("stock", Name = "Stock")]
        [SwaggerOperation("stock")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [ProducesResponseType(401)]
        [SwaggerResponse(StatusCodes.Status503ServiceUnavailable)]
        public async Task<IActionResult> stock(
           [FromBody] StockDto stock)
        {
            ResponseMessage responseMessage;
            try
            {
                responseMessage = await _baseManager.CreateStock(stock);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, new ResponseMessage { Status = ResponseStatus.Failed, Message =  ex.Message });
            }
            return Ok(responseMessage);
        }
    }
}
