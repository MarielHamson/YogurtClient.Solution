using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YogurtClient.Models
{
  public class Yogurt
  {
    public int YogurtId { get; set; }
    [Required]
    public string Brand { get; set; }
    [Required]
    public string Flavor { get; set; }
    [Required]
    public bool Blended { get; set; }
    [Required]
    public string Type { get; set; }
    [Range(0, 500, ErrorMessage = "Must be between 1 and 500.")]
    public int Protein { get; set; }
    [Range(0, 500, ErrorMessage = "Must be between 1 and 500.")]
    public int Sugar { get; set; }
    [Range(0, 500, ErrorMessage = "Must be between 1 and 500.")]
    public int Fat { get; set; }
    [Range(0, 500, ErrorMessage = "Must be between 1 and 500.")]
    public int Carbs { get; set; }
    [Range(0, 1000, ErrorMessage = "Must be between 1 and 1000.")]
    public int Calories { get; set; }

    public static List<Yogurt> GetYogurts()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Yogurt> yogurtList = JsonConvert.DeserializeObject<List<Yogurt>>(jsonResponse.ToString());

      return yogurtList;
    }

    public static Yogurt GetDetails(int id)
    {
      var apiCallTalk = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Yogurt yogurt = JsonConvert.DeserializeObject<Yogurt>(jsonResponse.ToString());
      return yogurt;
    }
  }
}