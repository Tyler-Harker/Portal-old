using Microsoft.AspNetCore.Mvc;
using Portal.Identity.Models;

namespace Portal.Identity.Controllers;

[ApiController]
[Route("[controller]")]
public class ConfigurationController : ControllerBase
{
    private readonly ILogger<ConfigurationController> _logger;

    public ConfigurationController(ILogger<ConfigurationController> logger)
    {
        _logger = logger;
    }

    [HttpGet("AzureAdConfiguration", Name = "GetAzureAdConfiguration")]
    public async Task<AzureAdConfiguration> GetAzureAdConfiguration()
    {
        /*
        *   For now serving static configuration. In the future would pull from some sort of cache / database.
        */
        await Task.CompletedTask;
        return new AzureAdConfiguration {
            ClientId = "fdc8b9bc-0bd2-4fae-b7b3-7d05b7596de0",
            TenantId = "a4aa9f35-9917-4518-b764-5fbbb893a6cd",
            RedirectUri = "http://localhost:4200"
        };
    }
}
