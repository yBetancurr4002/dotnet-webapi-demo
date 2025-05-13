
using demoWebApi.Models;
namespace demoWebApi.Services
{
  public interface IJsonPlaceholderService 
  {
    Task<IEnumerable<Post>> GetPostsAsync();
  }

}