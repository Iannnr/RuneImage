using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using ImageDownloader;

namespace RiotRuneImageDownloader
{
    class Program
    {
        string localFilePath = @"C:\Users\Ian\Desktop\";
        static void Main(string[] args)
        {
            Program itemRuneRetrieval = new Program();
            itemRuneRetrieval.getRuneData();
            itemRuneRetrieval.getItemData();
        }

        //Uses Riot's Static Data API to download all the currently available runes images and their name to a folder saved on my desktop (preferable to change)
        void getRuneData()
        {
            Console.WriteLine("Starting download of rune images and data...");
            string text = "";
            List<string> runeIDs = new List<string>();

            string runeURL = "http://ddragon.leagueoflegends.com/cdn/6.10.1/data/en_US/rune.json";

            var s = JsonConvert.DeserializeObject<SpecialRunerinos>(getJSONData(runeURL));
            //Save all the names of each rune, could use another Dictionary/Map here to relate the rune URL with the description/name
            List<string> URLs = new List<string>();
            List<string> runeName = new List<string>();

            //will cause a lot of KeyNotFoundExceptions due to numbers between values not being related to actual runes
            //gets the values of all the valid runes
            for (int i = 5001; i < 10001; i++)
            {
                try
                {
                    string rune = s.Runes[i.ToString()].image.full;
                    if (rune != null)
                    {
                        runeIDs.Add(i.ToString());

                        URLs.Add(rune);
                        runeName.Add(s.Runes[i.ToString()].name);

                    }
                }
                catch (KeyNotFoundException e)
                {
                }
            }

            for (int i = 0; i < URLs.Count; i++)
            {
                //personal use for exporting to Android Studio and using the runes to retrieve a drawable file
                //text = text + "case \"" + runeIDs[j] + "\":" + Environment.NewLine + "return resource.getDrawable(R.drawable." + runeName[j].ToLower().Replace(" ", "_") + ");" + Environment.NewLine;

                string localFilename = localFilePath + @"newrunes\" + runeName[i].ToLower().Replace(" ", "_") + ".png";
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
            //File.WriteAllText(@"C:\Users\Ian\Desktop\RuneIDs.txt", text);
            Console.WriteLine("Rune Downloading Complete");
            //Console.ReadLine();
        }

        void getItemData()
        {
            Console.WriteLine("Starting download of item images and data...");
            string text = "";

            List<string> itemIDs = new List<string>();
            string itemURL = "http://ddragon.leagueoflegends.com/cdn/6.13.1/data/en_US/item.json";
            
            var itemFromJSON = JsonConvert.DeserializeObject<SpecialItemerinos>(getJSONData(itemURL));
            List<string> URLs = new List<string>();
            //Save all the names of each rune, could use another Dictionary/Map here to relate the rune URL with the description/name
            List<string> itemName = new List<string>();
            List<string> itemDescription = new List<string>();
            List<string> itemPlainText = new List<string>();

            for (int i = 1001; i < 3904; i++)
            {
                try
                {
                    string j = itemFromJSON.Items[i].image.full;

                    if (j != null)
                    {
                        itemIDs.Add(i.ToString());

                        URLs.Add(j);
                        itemName.Add(itemFromJSON.Items[i].name);
                        itemDescription.Add(itemFromJSON.Items[i].description);
                        itemPlainText.Add(itemFromJSON.Items[i].plaintext);
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.ToString());
                }
            }
                        

            for (int i = 0; i < URLs.Count; i++)
            {
                {
                    //personal use for exporting to Android Studio and using the item to retrieve a drawable file and some class variables
                    /*text = text + "case \"" + itemIDs[j] + "\":" + Environment.NewLine + "item.itemImage = resource.getDrawable(R.drawable." + itemName[j].ToLower().Replace(" ", "_").Replace("-", "_").Replace("\'", "").Replace(":", "")
                    + ");" + Environment.NewLine + "item.name = \""
                    + itemName[j] + "\";" + Environment.NewLine + "item.plaintext = \"" + itemPlainText[j] + "\";" + Environment.NewLine + "break;" + Environment.NewLine;
                    //Console.WriteLine(text);*/
                    string localFilename = localFilePath + @"items2\" + itemName[i].ToLower().Replace(" ", "_").Replace("-", "_").Replace("\'", "").Replace("'", "").Replace(":", "").Replace("(", "").Replace(")", "") + ".png";
                    using (WebClient client = new WebClient())
                    {
                        try
                        {
                            string downloadURL = "http://ddragon.leagueoflegends.com/cdn/6.13.1/img/item/" + URLs[i];
                            client.DownloadFile(new Uri(downloadURL), localFilename);
                        }
                        catch (WebException e)
                        {
                        }
                    }
                }
            }
            //File.WriteAllText(@"C:\Users\Ian\Desktop\itemNames.txt", text);
            Console.WriteLine("Item Download Complete, press any key to continue...");
            Console.ReadKey();
        }

        string getJSONData(string URL)
        {
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(URL);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            var jsonData = objReader.ReadToEnd();
            return jsonData.ToString();
        }
    }
}
