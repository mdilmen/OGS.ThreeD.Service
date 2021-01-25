using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OGS.ThreeD.Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.ThreeD.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestLogController : ControllerBase
    {
        private readonly ILogger<RequestLogController> _logger;
        private readonly IRepository _repository;

        public RequestLogController(ILogger<RequestLogController> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        [HttpGet("id")]
        public IActionResult GetRequestLog(int id)
        {
            try
            {
                _logger.LogInformation("GetRequestLog Method Called..");
                //var policeLog = _repository.GetLog(id);
                //if (policeLog != null)
                //{
                //    return Ok(policeLog.RequestXml);
                //}
                //else
                //{
                //    return NotFound();
                //}
                return Ok("123123");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get the log item {ex}");
            }
            return BadRequest("Failed to get the log item");
        }

    }
}
