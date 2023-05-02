using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace SpaceTravel.Models
{
  public class NASA
  {
    public string Url { get; set; }
    public int Count { get; set; }

    public static List<NASA> GetPictures(string apiKey)
    {
      Task<string> apiCallTask = ApiHelper.ApiCall(apiKey);
      string result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<NASA> nasaList = JsonConvert.DeserializeObject<List<NASA>>(jsonResponse["results"].ToString());

      return nasaList;
    }
  }
}