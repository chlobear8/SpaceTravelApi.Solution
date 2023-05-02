using System.Threading.Tasks;
using RestSharp;

namespace SpaceTravel.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://api.nasa.gov");
      RestRequest request = new RestRequest($"planetary/apod?api_key=NASA");
      RestResponse response = await client.ExecuteAsync(request);
      return response.Content;
    }
  }
}