﻿namespace FirstCoreApp.Models
{
    public class App
    {
        public string AppId { get; private set; }
        public string AppName { get; private set; }
        public string Url { get; private set; }
        public string Colour { get; private set; }

        public App (string id, string appName, string colour)
        {
            AppId = id;
            AppName = appName;

            Url = GetUrl(AppName);
            Colour = colour;
        }

        private static string GetUrl(string appName)
        {
            string url;

            switch (appName)
            {
                case "Netflix":
                    url = "https://www.netflix.com/browse";
                    break;
                case "Youtube":
                    url = "https://www.youtube.com/";
                    break;
                default:
                    url = $"https://{appName}.com";
                    break;
            }
            return url ;    
        }

        public string Stringify()
        {
            //Console.WriteLine($"App Name: {AppName} \nURL: {Url} \nColour: {Colour}");

            return AppName;
        }

        public string GetAppColour()
        {
            return Colour;
        }
    }
}
