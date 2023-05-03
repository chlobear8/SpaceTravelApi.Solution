using System.Threading.Tasks;
using RestSharp;

namespace SpaceTravel.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://api.nasa.gov");
      // RestRequest request = new RestRequest($"planetary/apod?api_key={apiKey}", Method.Get);
      RestRequest request = new RestRequest($"planetary/apod?api_key=OMWEfEkRmo4Yp4Sh7z6Ic6nezdbwPrfS7VE89NqC");
      RestResponse response = await client.ExecuteAsync(request);
      return response.Content;
    }
  }
}