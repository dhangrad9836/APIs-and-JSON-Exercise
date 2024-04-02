using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void KanyeQuotes()
        {
            //use HttpClient to provide a base for sending request and receiving Http response from an API/URL
            var client = new HttpClient();

            //create variables to hold the kanye and ron apis
            var kanyeURL = "https://api.kanye.rest/";

            //now we send a GET request ie: GETStringAsync for each of the URLs using the client object returning the JSON in a string and using the .Result 
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            //now we parse through on JSON response and grab the values we are interested in ie: for Kanye using "quote" for key/value pair and Ron accessing the array elements
            //kanye
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"--------------------");
            Console.WriteLine($"Kanye:  '{kanyeQuote}'");
            Console.WriteLine($"--------------------");
        }

        public static void RonSwanQuotes()
        {
            //use HttpClient to provide a base for sending request and receiving Http response from an API/URL
            var client = new HttpClient();

            //create variables to hold the kanye and ron apis
            var ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            //now we send a GET request ie: GETStringAsync for each of the URLs using the client object returning the JSON in a string and using the .Result 
            var ronResponse = client.GetStringAsync(ronSwansonURL).Result;

            //now we parse through on JSON response and grab the values we are interested in ie: for Kanye using "quote" for key/value pair and Ron accessing the array elements
            //kanye
            var ronSwanQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"--------------------");
            Console.WriteLine($"Ron:  '{ronSwanQuote}'");
            Console.WriteLine($"--------------------");

        }
    }
}