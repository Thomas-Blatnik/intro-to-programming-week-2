using GiftingApi.Adapters;

namespace GiftingApi.Controllers;

public class StatusController : ControllerBase
{
    private readonly OnCallLookupApiAdapter _api;

    public StatusController(OnCallLookupApiAdapter api)
    {
        _api = api;
    }

    [HttpGet("/status")]
    public async Task<ActionResult> GetApiStatus()
    {
        var dev = await _api.GetOnCallDeveloperAsync();
        var response = new StatusResponse(
            "All Good!", DateTime.Now, dev!);
        return Ok(response);
    }
}

public record StatusResponse(string Status, DateTime LastChecked, OnCallDeveloperResponse onCallDeveloper);