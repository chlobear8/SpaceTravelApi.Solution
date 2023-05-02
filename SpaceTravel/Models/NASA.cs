using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace SpaceTravel.Models
{
  public class NASA
  {
    public string Title { get; set; }

    public int Date { get; set; }

    public string Url {get; set;}

    public static byte[] GetPictures(string apiKey)
    {
      var apiCallTask = ApiHelper.ApiCall(apiKey);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      var nasaList = JsonConvert.DeserializeObject<NASA>(jsonResponse["results"].ToString());
      return null;
    }

    public static string GP(string apiKey) 
    {
      var apiCallTask = ApiHelper.ApiCall(apiKey);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      if (!jsonResponse.ContainsKey("url"))
      {
        return "";
      }
      System.Console.WriteLine(jsonResponse);
      return jsonResponse["url"].ToString();
    }
  }
}