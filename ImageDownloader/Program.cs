using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;


namespace RiotRuneImageDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            string sURL = "http://ddragon.leagueoflegends.com/cdn/6.10.1/data/en_US/rune.json";
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);
            
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);
            var jsonData = objReader.ReadToEnd();

            var s = JsonConvert.DeserializeObject<SpecialRunerinos>(jsonData);
            List<string> URLs = new List<string>();
            //Save all the names of each rune, could use another Dictionary/Map here to relate the rune URL with the description/name
            List<string> runeName = new List<string>();

            //will cause a lot of KeyNotFoundExceptions due to numbers between values not being related to actual runes
            for (int i = 5001; i < 10001; i++)
            {
                try {
                    string x = s.Runes[i.ToString()].image.full;
                    if (x != null)
                    {
                        URLs.Add(x);
                        runeName.Add(s.Runes[i.ToString()].name);
                    }
                }
                catch (KeyNotFoundException e)
                {
                }
            }

            for (int i = 0; i < URLs.Count; i++)
            {
                string localFilename = @"C:\Users\Ian\Desktop\Lolrunes\" + runeName[i] + ".png";
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        string downloadURL = "http://ddragon.leagueoflegends.com/cdn/6.10.1/img/rune/" + URLs[i];
                        client.DownloadFile(new Uri(downloadURL), localFilename);
                    }
                    catch (WebException e)
                    {
                    }
                }
            }
            Console.WriteLine("Complete");
            Console.ReadLine();
        }
    }
}
