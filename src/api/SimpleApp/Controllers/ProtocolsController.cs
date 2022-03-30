using Microsoft.AspNetCore.Mvc;

namespace SimpleApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ProtocolsController : ControllerBase
    {
        private readonly ILogger<ProtocolsController> _logger;
        private readonly SimpleAppContext _context;

        public ProtocolsController(ILogger<ProtocolsController> logger, SimpleAppContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProtocols([FromQuery] ProtocolQuery query)
        {
            var protocolsCount = _context.Protocols.Skip(query.Offset).Take(query.Limit).Count();
            var protocols = _context.Protocols.Skip(query.Offset).Take(query.Limit).ToArray();

            var meta = new Dictionary<string, int>
            {
                {"totalCount", protocolsCount},
                {"limit", query.Limit},
                {"offset", query.Offset}
            };

            return Ok(new { meta, protocols });
        }
    }
}