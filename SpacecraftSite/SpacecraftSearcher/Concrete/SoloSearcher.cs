using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Threading.Tasks;
using SpacecraftData.Entities;
using SpacecraftSearcher.Interfaces;
using Google.Cloud.Translation.V2;
using HtmlAgilityPack;

namespace SpacecraftSearcher.Concrete
{
    public class SoloSearcher : ISoloSearcher
    {
        public async Task<Spacecraft> SearchForSpacecraft(string NSSDCA)
        {
            Spacecraft spacecraft = new Spacecraft{NSSDC = NSSDCA};

            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "sateliteproject-f52711ea42f5.json");

            using (var client = new HttpClient())
            {
                var nasaSearchResult = await client.GetAsync("https://nssdc.gsfc.nasa.gov/nmc/spacecraft/display.action?id=" + NSSDCA);
                var searchResultHtml = nasaSearchResult.Content.ReadAsStringAsync().Result;
                bool error = !nasaSearchResult.IsSuccessStatusCode || searchResultHtml.Contains("A valid spacecraft ID must be specified.");
                {
                    return new Spacecraft { Name = "NoData" };
                }

                TranslationClient tclient = TranslationClient.Create();

                spacecraft.Name = tclient.TranslateTextAsync(GetSpacecraftName(searchResultHtml), LanguageCodes.Ukrainian, LanguageCodes.English).Result.TranslatedText;
                spacecraft.Country = new Country { Name = tclient.TranslateTextAsync(GetSpacecraftCountry(searchResultHtml), LanguageCodes.Ukrainian, LanguageCodes.English).Result.TranslatedText };
                spacecraft.Operator = tclient.TranslateTextAsync(GetSpacecraftOperator(searchResultHtml), LanguageCodes.Ukrainian, LanguageCodes.English).Result.TranslatedText;
                spacecraft.Type = tclient.TranslateTextAsync(GetSpacecraftType(searchResultHtml), LanguageCodes.Ukrainian, LanguageCodes.English).Result.TranslatedText;
                spacecraft.Mass = GetSpacecraftMass(searchResultHtml);
                spacecraft.Mission = tclient.TranslateTextAsync(GetSpacecraftMission(searchResultHtml), LanguageCodes.Ukrainian, LanguageCodes.English).Result.TranslatedText;
                spacecraft.Launch = new Launch
                {
                    Rocket = new Rocket { Name = tclient.TranslateTextAsync(GetSpacecraftLaunchVehicle(searchResultHtml), LanguageCodes.Ukrainian, LanguageCodes.English).Result.TranslatedText },
                    LaunchDate = GetSpacecraftLaunchDate(searchResultHtml),
                    LaunchSite = tclient.TranslateTextAsync(GetSpacecraftLaunchSite(searchResultHtml), LanguageCodes.Ukrainian, LanguageCodes.English, TranslationModel.ServiceDefault).Result.TranslatedText,
                    Success = true
                };
            }
            return spacecraft;
        }

        private string GetSpacecraftName(string html)
        {
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            return htmlDocument.DocumentNode.SelectSingleNode("//h1").InnerText;
        }

        private string GetSpacecraftCountry(string html)
        {
            if (!html.Contains("<h2>Funding Agency</h2><ul><li>")) return "";
            var country = html.Substring(html.IndexOf("<h2>Funding Agency</h2><ul><li>") + 31);
            country = country.Substring(country.IndexOf("(") + 1, country.IndexOf(")") - (country.IndexOf("(") + 1));
            return country;
        }

        private string GetSpacecraftOperator(string html)
        {
            if (!html.Contains("<h2>Funding Agency</h2><ul><li>")) return "";
            var Operator = html.Substring(html.IndexOf("<h2>Funding Agency</h2><ul><li>") + 31);
            Operator = Operator.Substring(0, Operator.IndexOf("("));
            return Operator.Trim();
        }

        private string GetSpacecraftType(string html)
        {
            if (!html.Contains("<h2>Disciplines</h2><ul>")) return "";
            var type = html.Substring(html.IndexOf("<h2>Disciplines</h2><ul>") + 24);
            type = type.Substring(0, type.IndexOf("</ul>"));
            var typesHtml = new HtmlDocument();
            typesHtml.LoadHtml(type);
            string types = "";
            foreach (var htmlNode in typesHtml.DocumentNode.ChildNodes)
            {
                types = types + htmlNode.InnerText + ", ";
            }
            types = types.Substring(0, types.Length - 3);
            return types;
        }

        private double GetSpacecraftMass(string html)
        {
            if (!html.Contains("<strong>Mass:</strong>")) return 0.0;
            string MassString = html.Substring(html.IndexOf("<strong>Mass:</strong>") + 23);
            MassString = MassString.Substring(0, MassString.IndexOf("<"));
            MassString = Regex.Replace(MassString, "[^0-9.]", "");
            MassString = MassString.Replace(".", ",");
            var Mass = Convert.ToDouble(MassString);
            return Mass;
        }

        private string GetSpacecraftMission(string html)
        {
            var missionHtml = new HtmlDocument();
            missionHtml.LoadHtml(html);
            var missions = missionHtml.DocumentNode.SelectSingleNode(".//*[contains(@class,'urone')]").ChildNodes.ToList();
            missions.RemoveAt(0);
            string mainText = "";
            foreach (var textNode in missions)
            {
                mainText = mainText + textNode.InnerText;
            }
            return mainText;
        }

        private DateTime GetSpacecraftLaunchDate(string html)
        {
            if (!html.Contains("<strong>Launch Date:</strong>")) return new DateTime();
            string LaunchDateString = html.Substring(html.IndexOf("<strong>Launch Date:</strong>") + 30);
            LaunchDateString = LaunchDateString.Substring(0, LaunchDateString.IndexOf("<"));
            var date = Convert.ToDateTime(LaunchDateString);
            return date;
        }

        private string GetSpacecraftLaunchVehicle(string html)
        {
            if (!html.Contains("<strong>Launch Vehicle:</strong>")) return "";
            Console.WriteLine(html.Contains("<strong>Launch Vehicle:</strong>"));
            string LaunchVehicle = html.Substring(html.IndexOf("<strong>Launch Vehicle:</strong>") + 33);
            LaunchVehicle = LaunchVehicle.Substring(0, LaunchVehicle.IndexOf("<"));
            return LaunchVehicle;
        }

        private string GetSpacecraftLaunchSite(string html)
        {
            if (!html.Contains("<strong>Launch Site:</strong>")) return "";
            string LaunchSite = html.Substring(html.IndexOf("<strong>Launch Site:</strong>") + 30);
            LaunchSite = LaunchSite.Substring(0, LaunchSite.IndexOf("<"));
            return LaunchSite;
        }
    }
}
