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
        //file path will change for different users
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

            //special class created from Edit > Paste Special > Class from JSON
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
                        //if the ID is valid then add it to a list of correct values that relate to rune IDs
                        runeIDs.Add(i.ToString());
                        URLs.Add(rune);
                        runeName.Add(s.Runes[i.ToString()].name);
                    }
                }
                catch (KeyNotFoundException e)
                {
                    //Don't want it to actually show any errors because it'll slow down the process 
                    //Fully understand that some values will be null looking at the values prior to downloading
                }
            }

            for (int i = 0; i < URLs.Count; i++)
            {
                //personal use for exporting to Android Studio and using the runes to retrieve a drawable file
                //text = text + "case \"" + runeIDs[j] + "\":" + Environment.NewLine + "return resource.getDrawable(R.drawable." + runeName[j].ToLower().Replace(" ", "_") + ");" + Environment.NewLine;

                string localFilename = localFilePath + @"newrunes\" + runeName[i].ToLower().Replace(" ", "_") + ".png";
                //Start a web client to download the valid image related to the rune IDs using their unique URL
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

        //this is a list of all the items available in the game at the current patch, URL will need to be updated with subsequent patches
        //uses same technique as grabbing Rune images -
        //gets all item IDs, checks if they have a valid name + image attached and downloads the images and parses the JSON data to get names + description
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
                    /*personal use for exporting to Android Studio and using the item to retrieve a drawable file and some class variables
                    text = text + "case \"" + itemIDs[j] + "\":" + Environment.NewLine + "item.itemImage = resource.getDrawable(R.drawable." + itemName[j].ToLower().Replace(" ", "_").Replace("-", "_").Replace("\'", "").Replace(":", "")
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

        //retrieves and returns JSON data from the url passed to the method
        string getJSONData(string URL)
        {
            var jsonData = "";
            try {
                WebRequest wrGETURL;
                wrGETURL = WebRequest.Create(URL);
                Stream objStream;
                objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);
                jsonData = objReader.ReadToEnd();
                return jsonData.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Malformed/Out of data URL");
                Console.ReadLine();
            }
            return jsonData;
        }
    }
}
