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

    public static async Task Post(string newYogurt)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"yogurts", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newYogurt);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newYogurt)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest ($"animals/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newYogurt);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"yogurts/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}