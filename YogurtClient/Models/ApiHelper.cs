using System.Threading.Tasks;
using RestSharp;

namespace YogurtClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      ///do we need to pass the API key here?
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"yogurts", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"yogurts/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}