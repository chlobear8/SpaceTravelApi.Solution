using System.Threading.Tasks;
using RestSharp;

namespace SpaceTravel.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://api.nasa.gov/planetary/apod?api_key=NASA");
      RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET);
      RestResponse response = await client.ExecuteAsync(request);
      return response.Content;
    }
  }
}