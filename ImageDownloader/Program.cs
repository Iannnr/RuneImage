using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using ImageDownloader;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace RiotRuneImageDownloader
{
    class Program
    {
        static string localFilePath = @"C:\Users\Ian\Desktop\";
        static int count = 0;
        static Queue<string> consoleOutput = new Queue<string>();
        static List<string> itemName = new List<string>();
        static List<string> runeName = new List<string>();

        static void Main(string[] args)
        {

            while (true)
            {
                Example();
            }

        }

        //Uses Riot's Static Data API to download all the currently available runes images and their name to a folder saved on my desktop (preferable to change)
        static async void Example()
        {
            while (count < 1)
            {
                Task.Run(() => getChampionImage());
                Task.Run(() => getRuneData());
                Task.Run(() => getItemData());

                count++;
            }
        }


        static void getRuneData()
        {
            Console.WriteLine("Starting download of rune images and data...");

            string text = "";
            List<string> runeIDs = new List<string>();

            string runeURL = "http://ddragon.leagueoflegends.com/cdn/6.10.1/data/en_US/rune.json";

            //special class created from Edit > Paste Special > Class from JSON
            var s = JsonConvert.DeserializeObject<SpecialRunerinos>(getJSONData(runeURL));

            //Save all the names of each rune, could use another Dictionary/Map here to relate the rune URL with the description/name
            List<string> URLs = new List<string>();


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
            downloadFile("Runes", URLs.Count, URLs);
            //personal use for exporting to Android Studio and using the runes to retrieve a drawable file
            //text = text + "case \"" + runeIDs[j] + "\":" + Environment.NewLine + "return resource.getDrawable(R.drawable." 
            //+ runeName[j].ToLower().Replace(" ", "_") + ");" + Environment.NewLine;

            //File.WriteAllText(@"C:\Users\Ian\Desktop\RuneIDs.txt", text);
            //Console.SetCursorPosition(0, 4);
            //Console.WriteLine("Rune Downloading Complete");
        }

        //this is a list of all the items available in the game at the current patch, URL will need to be updated with subsequent patches
        //uses same technique as grabbing Rune images -
        //gets all item IDs, checks if they have a valid name + image attached and downloads the images and parses the JSON data to get names + description
        static void getItemData()
        {
            Console.WriteLine("Starting download of item images and data...");

            string text = "";

            List<string> itemIDs = new List<string>();
            string itemURL = "http://ddragon.leagueoflegends.com/cdn/6.13.1/data/en_US/item.json";

            //deserialised JSON data
            var itemFromJSON = JsonConvert.DeserializeObject<SpecialItemerinos>(getJSONData(itemURL));
            List<string> URLs = new List<string>();
            //Save all the names of each rune, could use another Dictionary/Map here to relate the rune URL with the description/name

            List<string> itemDescription = new List<string>();
            List<string> itemPlainText = new List<string>();

            //list of known current ID range
            for (int i = 1001; i < 3904; i++)
            {
                try
                {
                    //end of URL to download specific item image from Riot API
                    string item = itemFromJSON.Items[i].image.full;

                    if (item != null)
                    {
                        itemIDs.Add(i.ToString());

                        URLs.Add(item);
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
            downloadFile("Items", URLs.Count, URLs);

            //            /*personal use for exporting to Android Studio and using the item to retrieve a drawable file and some class variables
            //            text = text + "case \"" + itemIDs[j] + "\":" + Environment.NewLine + "item.itemImage = resource.getDrawable(R.drawable." + itemName[j].ToLower().Replace(" ", "_").Replace("-", "_").Replace("\'", "").Replace(":", "")
            //            + ");" + Environment.NewLine + "item.name = \""
            //            + itemName[j] + "\";" + Environment.NewLine + "item.plaintext = \"" + itemPlainText[j] + "\";" + Environment.NewLine + "break;" + Environment.NewLine;

            //File.WriteAllText(@"C:\Users\Ian\Desktop\itemNames.txt", text);
            //Console.SetCursorPosition(0, 3);
            //Console.WriteLine("Items Downloading Complete");
        }

        //gets the full size splash images from every available champion and their skins
        static void getChampionImage()
        {
            Console.WriteLine("Starting download of champion images and data...");

            string text = "";
            List<string> champIDs = new List<string>();

            string champURL = "http://ddragon.leagueoflegends.com/cdn/6.10.1/data/en_US/champion.json";

            //special class created from Edit > Paste Special > Class from JSON
            var champJson = JsonConvert.DeserializeObject<SpecialRunerinos>(getJSONData(champURL));

            //Save all the names of each rune, could use another Dictionary/Map here to relate the rune URL with the description/name
            List<string> championURL = new List<string>();
            List<string> champName = new List<string>();
            makeChampionList lolChamps = new makeChampionList();

            //will cause a lot of KeyNotFoundExceptions due to numbers between values not being related to actual runes
            //gets the values of all the valid runes
            int max = lolChamps.championListNames().Count;
            List<string> skinURLs = new List<string>();
            try
            {
                for (int j = 0; j < max; j++) //cycle through champions
                {
                    string skinURL = "http://ddragon.leagueoflegends.com/cdn/6.14.2/data/en_US/champion/" +
                        lolChamps.championListNames()[j] + ".json";
                    var skinJson = JsonConvert.DeserializeObject<SkinCount>(getJSONData(skinURL));
                    int x = skinJson.champList[lolChamps.championListNames()[j]].skins.Length; //amount of skins per champ, cycle through skins
                    for (int k = 0; k < x; k++)
                    {
                        string removeSKT = skinJson.champList[lolChamps.championListNames()[j]].skins[k].name;
                        if (!removeSKT.Contains("SKT"))
                        {
                            string champ = lolChamps.championListNames()[j];
                            int skinId = skinJson.champList[lolChamps.championListNames()[j]].skins[k].num;
                            skinURLs.Add(champ + "_" + skinId);
                        }
                    }
                }
            }
            catch (KeyNotFoundException e)
            {
                //Don't want it to actually show any errors because it'll slow down the process 
                //Fully understand that some values will be null looking at the values prior to downloading
            }

            downloadFile("Champions", skinURLs.Count, skinURLs);
            
            //Console.SetCursorPosition(0, 5);
            //Console.WriteLine("Champion Splash Art Downloading Complete");
        }

        //retrieves and returns JSON data from the url passed to the method
        static string getJSONData(string URL)
        {
            var jsonData = "";
            try
            {
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

        static void outputToConsole(string outputMessage)
        {
            Queue<string> consoleOutput = new Queue<string>();
            consoleOutput.Enqueue(outputMessage);

            foreach (string item in consoleOutput)
            {
                if (item.Contains("Items"))
                {
                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine(item);
                }
                if (item.Contains("Runes"))
                {
                    Console.WriteLine();
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine(item);
                }
                if (item.Contains("Champions"))
                {
                    Console.WriteLine();
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine(item);
                }
            }
        }

        static void downloadFile(string type, int count, List<string> imageName)
        {

            string localFilename = "";
            using (WebClient client = new WebClient())
            {
                try
                {
                    string downloadURL = "";
                    for (int i = 0; i < count; i++)
                    {
                        switch (type)
                        {
                            case "Champions":
                                    localFilename = localFilePath + @"LoL App\" + type + @"\" + imageName[i].ToLower().Replace(" ", "_") + ".png";
                                    downloadURL = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/" + imageName[i] + ".jpg";
                                break;
                            case "Items":
                                localFilename = localFilePath + @"LoL App\" + type + @"\" + itemName[i].ToLower().Replace(" ", "_")
                            .Replace("-", "_").Replace("\'", "").Replace("'", "").Replace(":", "").Replace("(", "").Replace(")", "") + ".png";
                                downloadURL = "http://ddragon.leagueoflegends.com/cdn/6.13.1/img/item/" + imageName[i];
                                break;
                            case "Runes":
                                localFilename = localFilePath + @"LoL App\" + type + @"\" + runeName[i].ToLower().Replace(" ", "_") + ".png";
                                downloadURL = "http://ddragon.leagueoflegends.com/cdn/6.10.1/img/rune/" + imageName[i];
                                break;
                        }

                        client.DownloadFile(new Uri(downloadURL), localFilename);
                        outputToConsole("Downloaded " + i + " out of " + (imageName.Count-1) + " " + type);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
