using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static double GetTemperature(string apiCall)
        {
            var client = new HttpClient();

            //this takes the apiCall key that is passed as a parameter to the method and Result is returned as a string
            var response = client.GetStringAsync(apiCall).Result;

            //store the temp that we first obtain from the response by passing the JSON into the JObject.Parse method..we then obtain the information from the fields ["main"]["temp"] which is then returned as a string from ToString(); note that if you put the api endpoint inside postman you can see the JSON and the breakdown of the the main -> temp
            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            return temp;

        } //end method
    }// end Class
}
