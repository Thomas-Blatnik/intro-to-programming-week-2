using Microsoft.AspNetCore.Mvc;

namespace GiftingApi.Controllers;

public class PeopleController : ControllerBase
{
    private readonly ICatalogPeople _personCatalog;

    public PeopleController(ICatalogPeople personCatalog)
    {
        _personCatalog = personCatalog;
    }


    // GET /people
    [HttpGet("/people")]
    public async Task<ActionResult> GetAllPeople()
    {
        PersonResponse response = await _personCatalog.GetPeopleAsync();
        return Ok(response);
    }
}
