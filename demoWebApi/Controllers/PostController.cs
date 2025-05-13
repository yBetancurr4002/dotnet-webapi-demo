using demoWebApi.Models;
using demoWebApi.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("herramientas/[controller]")]
public class PostController : Controller
{
  private readonly IJsonPlaceholderService _service;

  public PostController(IJsonPlaceholderService service)
  {
    _service = service;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<Post>>> Get () 
  {
    var posts = await _service.GetPostsAsync();
    return Ok(posts); // 200
  }
}