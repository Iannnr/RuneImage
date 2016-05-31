using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace RiotRuneImageDownloader
{
    //Generated from the JSON at http://ddragon.leagueoflegends.com/cdn/6.10.1/data/en_US/rune.json 
    public class Rune
    {
        public bool isrune { get; set; }
        public int tier { get; set; }
        public string type { get; set; }
    }

    public class Gold
    {
        public int total { get; set; }
        public int sell { get; set; }
        public bool purchasable { get; set; }
    }

    public class Stats
    {
        public int FlatHPPoolMod { get; set; }
        public int rFlatHPModPerLevel { get; set; }
        public int FlatMPPoolMod { get; set; }
        public int rFlatMPModPerLevel { get; set; }
        public int PercentHPPoolMod { get; set; }
        public int PercentMPPoolMod { get; set; }
        public int FlatHPRegenMod { get; set; }
        public int rFlatHPRegenModPerLevel { get; set; }
        public int PercentHPRegenMod { get; set; }
        public int FlatMPRegenMod { get; set; }
        public int rFlatMPRegenModPerLevel { get; set; }
        public int PercentMPRegenMod { get; set; }
        public int FlatArmorMod { get; set; }
        public int rFlatArmorModPerLevel { get; set; }
        public int PercentArmorMod { get; set; }
        public int rFlatArmorPenetrationMod { get; set; }
        public int rFlatArmorPenetrationModPerLevel { get; set; }
        public int rPercentArmorPenetrationMod { get; set; }
        public int rPercentArmorPenetrationModPerLevel { get; set; }
        public int FlatPhysicalDamageMod { get; set; }
        public int rFlatPhysicalDamageModPerLevel { get; set; }
        public int PercentPhysicalDamageMod { get; set; }
        public int FlatMagicDamageMod { get; set; }
        public int rFlatMagicDamageModPerLevel { get; set; }
        public int PercentMagicDamageMod { get; set; }
        public int FlatMovementSpeedMod { get; set; }
        public int rFlatMovementSpeedModPerLevel { get; set; }
        public int PercentMovementSpeedMod { get; set; }
        public int rPercentMovementSpeedModPerLevel { get; set; }
        public int FlatAttackSpeedMod { get; set; }
        public int PercentAttackSpeedMod { get; set; }
        public int rPercentAttackSpeedModPerLevel { get; set; }
        public int rFlatDodgeMod { get; set; }
        public int rFlatDodgeModPerLevel { get; set; }
        public int PercentDodgeMod { get; set; }
        public int FlatCritChanceMod { get; set; }
        public int rFlatCritChanceModPerLevel { get; set; }
        public int PercentCritChanceMod { get; set; }
        public int FlatCritDamageMod { get; set; }
        public int rFlatCritDamageModPerLevel { get; set; }
        public int PercentCritDamageMod { get; set; }
        public int FlatBlockMod { get; set; }
        public int PercentBlockMod { get; set; }
        public int FlatSpellBlockMod { get; set; }
        public int rFlatSpellBlockModPerLevel { get; set; }
        public int PercentSpellBlockMod { get; set; }
        public int FlatEXPBonus { get; set; }
        public int PercentEXPBonus { get; set; }
        public int rPercentCooldownMod { get; set; }
        public int rPercentCooldownModPerLevel { get; set; }
        public int rFlatTimeDeadMod { get; set; }
        public int rFlatTimeDeadModPerLevel { get; set; }
        public int rPercentTimeDeadMod { get; set; }
        public int rPercentTimeDeadModPerLevel { get; set; }
        public int rFlatGoldPer10Mod { get; set; }
        public int rFlatMagicPenetrationMod { get; set; }
        public int rFlatMagicPenetrationModPerLevel { get; set; }
        public int rPercentMagicPenetrationMod { get; set; }
        public int rPercentMagicPenetrationModPerLevel { get; set; }
        public int FlatEnergyRegenMod { get; set; }
        public int rFlatEnergyRegenModPerLevel { get; set; }
        public int FlatEnergyPoolMod { get; set; }
        public int rFlatEnergyModPerLevel { get; set; }
        public int PercentLifeStealMod { get; set; }
        public int PercentSpellVampMod { get; set; }
    }

    public class Basic
    {
        public string name { get; set; }
        public Rune rune { get; set; }
        public Gold gold { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string colloq { get; set; }
        public string plaintext { get; set; }
        public bool consumed { get; set; }
        public int stacks { get; set; }
        public int depth { get; set; }
        public bool consumeOnFull { get; set; }
        public IList<object> from { get; set; }
        public IList<object> into { get; set; }
        public int specialRecipe { get; set; }
        public bool inStore { get; set; }
        public bool hideFromAll { get; set; }
        public string requiredChampion { get; set; }
        public Stats stats { get; set; }
        public IList<object> tags { get; set; }
    }

    public class Image
    {
        public string full { get; set; }
        public string sprite { get; set; }
        public string group { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
    }
    public class SpecialRune
    {
        public string name { get; set; }
        public string description { get; set; }
        public Image image { get; set; }
        public Rune rune { get; set; }
    }

    public class SpecialRunerinos
    {
        public string type { get; set; }
        public string version { get; set; }
        public Basic basic { get; set; }
        [JsonProperty("data")]
        public Dictionary<string, SpecialRune> Runes { get; set; }
    }
}
