using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //static methods of Kanye and Ron
            RonVSKanyeAPI.KanyeQuotes();
            RonVSKanyeAPI.RonSwanQuotes();

            //Display Kanye and Ron having a conversation back and forth with a loop of 5 different conversations

            for (int i = 0; i < 5; i++)
            {
                RonVSKanyeAPI.KanyeQuotes();
                RonVSKanyeAPI.RonSwanQuotes();
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine("Weather Map");
            //the File.ReadAllText() reads everything in the file and puts into a string
            string key = File.ReadAllText("appsettings.json");

            //store the APIKey temporarily from the appsettings file during runtime
            //use our JObject from our Nuget Package to use the .GetValue() which pulls the value from our APIKey
            //"APIKey" is what we named our key from inside the appsettings file
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            //ask user for their zip code location
            Console.WriteLine("Please enter you zip code: ");
            string zipCode = Console.ReadLine();

            //setup apicall endpoint from openWeather app (this comes from openweather map) https://openweathermap.org/current#data
            var apiCall =
                $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIKey}&units=imperial";


            Console.WriteLine();

            Console.WriteLine($"It is currently {OpenWeatherMapAPI.GetTemperature(apiCall)} degrees F in your location.");


            Console.ReadLine();
        }//endmain
    }
}
