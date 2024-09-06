using Dotmim.Sync.Web.Server;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class SyncController : ControllerBase
{
    private readonly WebServerAgent _webServerAgent;

    public SyncController(WebServerAgent webServerAgent)
    {
        _webServerAgent = webServerAgent;
    }

    [HttpPost]
    public async Task Post()
    {
        await _webServerAgent.HandleRequestAsync(HttpContext);
    }
}
