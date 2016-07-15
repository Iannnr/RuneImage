using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RiotRuneImageDownloader
{
    public class Champions
    {
    }

    public class SpecialChampion
    {
        public string type { get; set; }
        public string version { get; set; }
        [JsonProperty("data")]
        public Dictionary<string, UniqueChampion> champions { get; set; }
    }

    public class UniqueChampion
    {
        public string name { get; set; }
        public string title { get; set; }
        public Image image { get; set; }
    }

    public class makeChampionList
    { 
        public List<string> _champions = new List<string>();
        public List<string> champions
        {
            get { return _champions; }
        }

    public List<string> championListNames()
        {
            
            champions.Add("Aatrox");
            champions.Add("Ahri");
            champions.Add("Akali");
            champions.Add("Alistar");
            champions.Add("Amumu");
            champions.Add("Anivia");
            champions.Add("Annie");
            champions.Add("Ashe");
            champions.Add("AurelionSol");
            champions.Add("Azir");
            champions.Add("Bard");
            champions.Add("Blitzcrank");
            champions.Add("Brand");
            champions.Add("Braum");
            champions.Add("Caitlyn");
            champions.Add("Cassiopeia");
            champions.Add("Chogath");
            champions.Add("Corki");
            champions.Add("Darius");
            champions.Add("Diana");
            champions.Add("Draven");
            champions.Add("DrMundo");
            champions.Add("Ekko");
            champions.Add("Elise");
            champions.Add("Evelynn");
            champions.Add("Ezreal");
            champions.Add("FiddleSticks");
            champions.Add("Fiora");
            champions.Add("Fizz");
            champions.Add("Galio");
            champions.Add("Gangplank");
            champions.Add("Garen");
            champions.Add("Gnar");
            champions.Add("Gragas");
            champions.Add("Graves");
            champions.Add("Hecarim");
            champions.Add("Heimerdinger");
            champions.Add("Illaoi");
            champions.Add("Irelia");
            champions.Add("Janna");
            champions.Add("JarvanIV");
            champions.Add("Jax");
            champions.Add("Jayce");
            champions.Add("Jhin");
            champions.Add("Jinx");
            champions.Add("Kalista");
            champions.Add("Karma");
            champions.Add("Karthus");
            champions.Add("Kassadin");
            champions.Add("Katarina");
            champions.Add("Kayle");
            champions.Add("Kennen");
            champions.Add("Khazix");
            champions.Add("Kindred");
            champions.Add("KogMaw");
            champions.Add("Leblanc");
            champions.Add("LeeSin");
            champions.Add("Leona");
            champions.Add("Lissandra");
            champions.Add("Lucian");
            champions.Add("Lulu");
            champions.Add("Lux");
            champions.Add("Malphite");
            champions.Add("Malzahar");
            champions.Add("Maokai");
            champions.Add("MasterYi");
            champions.Add("MissFortune");
            champions.Add("MonkeyKing");
            champions.Add("Mordekaiser");
            champions.Add("Morgana");
            champions.Add("Nami");
            champions.Add("Nasus");
            champions.Add("Nautilus");
            champions.Add("Nidalee");
            champions.Add("Nocturne");
            champions.Add("Nunu");
            champions.Add("Olaf");
            champions.Add("Orianna");
            champions.Add("Pantheon");
            champions.Add("Poppy");
            champions.Add("Quinn");
            champions.Add("Rammus");
            champions.Add("RekSai");
            champions.Add("Renekton");
            champions.Add("Rengar");
            champions.Add("Riven");
            champions.Add("Rumble");
            champions.Add("Ryze");
            champions.Add("Sejuani");
            champions.Add("Shaco");
            champions.Add("Shen");
            champions.Add("Shyvana");
            champions.Add("Singed");
            champions.Add("Sion");
            champions.Add("Sivir");
            champions.Add("Skarner");
            champions.Add("Sona");
            champions.Add("Soraka");
            champions.Add("Swain");
            champions.Add("Syndra");
            champions.Add("TahmKench");
            champions.Add("Taliyah");
            champions.Add("Talon");
            champions.Add("Taric");
            champions.Add("Teemo");
            champions.Add("Thresh");
            champions.Add("Tristana");
            champions.Add("Trundle");
            champions.Add("Tryndamere");
            champions.Add("TwistedFate");
            champions.Add("Twitch");
            champions.Add("Udyr");
            champions.Add("Urgot");
            champions.Add("Varus");
            champions.Add("Vayne");
            champions.Add("Veigar");
            champions.Add("Velkoz");
            champions.Add("Vi");
            champions.Add("Viktor");
            champions.Add("Vladimir");
            champions.Add("Volibear");
            champions.Add("Warwick");
            champions.Add("Xerath");
            champions.Add("XinZhao");
            champions.Add("Yasuo");
            champions.Add("Yorick");
            champions.Add("Zac");
            champions.Add("Zed");
            champions.Add("Ziggs");
            champions.Add("Zilean");
            champions.Add("Zyra");

            return champions;
        }
    }
}
