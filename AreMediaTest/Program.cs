using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace AreMediaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("AreMediaBackend.json");
            var rootObj = JsonConvert.DeserializeObject<AreMedia>(json);

            var sb = new StringBuilder();
            sb.AppendLine("id,imageUrl");
            foreach (var datum in rootObj.data)
            {
                sb.AppendLine($"{datum.id},{datum.contentImageUrl}");
            }

            var csv = sb.ToString();
            File.WriteAllText("AreMediaBackend.csv", csv);

            Console.WriteLine("Enter API Key: ");
            var apiKey = Console.ReadLine(); //cysAsep7
            Console.WriteLine("Enter V2 API Secret: ");
            var apiSecret = Console.ReadLine(); //nSU2wiEeWu45Zbv8Sg4xRmInWlRCc1FWRkxNSE5VYW5WSU1ISnZja052V214elN6RnQn

            sb = new StringBuilder();
            foreach (var datum in rootObj.data)
            {
                var request = WebRequest.Create($"https://api.jwplayer.com/v2/sites/{apiKey}/media/{datum.id}");
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Headers.Add("authorization", apiSecret);
                request.Headers.Add("accept", "application/json");

                var response = request.GetResponse();
                JwPlayerResponse resp;
                using (var dataStream = response.GetResponseStream())
                {
                    var reader = new StreamReader(dataStream);
                    var responseFromServer = reader.ReadToEnd();
                    resp = JsonConvert.DeserializeObject<JwPlayerResponse>(responseFromServer);
                }

                //no property references a high res url
                //it doesnt seem to exist in v1, either
                sb.AppendLine($"{resp.id},{resp.metadata.title},{resp.metadata.permalink},{resp.metadata.permalink}");

                response.Close();
            }

            csv = sb.ToString();
            File.WriteAllText("JwResponse.csv", csv);

            Console.WriteLine("Finished. Press any key to close.");
            Console.ReadKey();
        }
    }
}
