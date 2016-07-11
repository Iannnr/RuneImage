using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDownloader
{

    public class Rootobject
    {
        public string type { get; set; }
        public string version { get; set; }
        public Basic basic { get; set; }
        public Data data { get; set; }
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

    public class Basic
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string sanitizedDescription { get; set; }
        public string colloq { get; set; }
        public string plaintext { get; set; }
        public bool consumed { get; set; }
        public int stacks { get; set; }
        public int depth { get; set; }
        public bool consumeOnFull { get; set; }
        public object[] from { get; set; }
        public object[] into { get; set; }
        public int specialRecipe { get; set; }
        public bool inStore { get; set; }
        public bool hideFromAll { get; set; }
        public string requiredChampion { get; set; }
        public object[] tags { get; set; }
        public Maps maps { get; set; }
        public object image { get; set; }
        public Stats stats { get; set; }
        public Gold gold { get; set; }
        public Rune rune { get; set; }
    }

    public class Maps
    {
        public bool _10 { get; set; }
        public bool _1 { get; set; }
        public bool _8 { get; set; }
        public bool _12 { get; set; }
    }

    public class SpecialItem
    {
        public string name { get; set; }
        public string description { get; set; }
        public int id { get; set; }
        public string plaintext { get; set; }
        public Image image { get; set; }
        public Rune rune { get; set; }
        public Data data { get; set; }
    }

    public class SpecialItemerinos
    {
        public string type { get; set; }
        public string version { get; set; }
        public Basic basic { get; set; }
        [JsonProperty("data")]
        public Dictionary<int, SpecialItem> Items { get; set; }
    }

    public class Stats
    {
        public float rFlatArmorModPerLevel { get; set; }
        public float rFlatArmorPenetrationMod { get; set; }
        public float rFlatArmorPenetrationModPerLevel { get; set; }
        public float rFlatCritChanceModPerLevel { get; set; }
        public float rFlatCritDamageModPerLevel { get; set; }
        public float rFlatEnergyRegenModPerLevel { get; set; }
        public float rFlatDodgeMod { get; set; }
        public float rFlatDodgeModPerLevel { get; set; }
        public float rFlatGoldPer10Mod { get; set; }
        public float rFlatHPModPerLevel { get; set; }
        public float rFlatHPRegenModPerLevel { get; set; }
        public float rFlatMPRegenModPerLevel { get; set; }
        public float rFlatMagicDamageModPerLevel { get; set; }
        public float rFlatMagicPenetrationMod { get; set; }
        public float rFlatMagicPenetrationModPerLevel { get; set; }
        public float rFlatMPModPerLevel { get; set; }
        public float rFlatEnergyModPerLevel { get; set; }
        public float rFlatMovementSpeedModPerLevel { get; set; }
        public float rFlatPhysicalDamageModPerLevel { get; set; }
        public float rFlatSpellBlockModPerLevel { get; set; }
        public float rFlatTimeDeadMod { get; set; }
        public float rFlatTimeDeadModPerLevel { get; set; }
        public float rPercentArmorPenetrationMod { get; set; }
        public float rPercentArmorPenetrationModPerLevel { get; set; }
        public float rPercentAttackSpeedModPerLevel { get; set; }
        public float rPercentCooldownMod { get; set; }
        public float rPercentCooldownModPerLevel { get; set; }
        public float rPercentMagicPenetrationMod { get; set; }
        public float rPercentMagicPenetrationModPerLevel { get; set; }
        public float rPercentMovementSpeedModPerLevel { get; set; }
        public float rPercentTimeDeadMod { get; set; }
        public float rPercentTimeDeadModPerLevel { get; set; }
        public float FlatArmorMod { get; set; }
        public float FlatAttackSpeedMod { get; set; }
        public float FlatBlockMod { get; set; }
        public float FlatCritChanceMod { get; set; }
        public float FlatCritDamageMod { get; set; }
        public float FlatEnergyRegenMod { get; set; }
        public float FlatEnergyPoolMod { get; set; }
        public float FlatEXPBonus { get; set; }
        public float FlatHPPoolMod { get; set; }
        public float FlatHPRegenMod { get; set; }
        public float FlatMPPoolMod { get; set; }
        public float FlatMPRegenMod { get; set; }
        public float FlatMagicDamageMod { get; set; }
        public float FlatMovementSpeedMod { get; set; }
        public float FlatPhysicalDamageMod { get; set; }
        public float FlatSpellBlockMod { get; set; }
        public float PercentArmorMod { get; set; }
        public float PercentAttackSpeedMod { get; set; }
        public float PercentBlockMod { get; set; }
        public float PercentCritChanceMod { get; set; }
        public float PercentCritDamageMod { get; set; }
        public float PercentDodgeMod { get; set; }
        public float PercentEXPBonus { get; set; }
        public float PercentHPPoolMod { get; set; }
        public float PercentHPRegenMod { get; set; }
        public float PercentMPPoolMod { get; set; }
        public float PercentMPRegenMod { get; set; }
        public float PercentMagicDamageMod { get; set; }
        public float PercentMovementSpeedMod { get; set; }
        public float PercentPhysicalDamageMod { get; set; }
        public float PercentSpellBlockMod { get; set; }
        public float PercentSpellVampMod { get; set; }
        public float PercentLifeStealMod { get; set; }
    }

    public class Gold
    {
        public int _base { get; set; }
        public int total { get; set; }
        public int sell { get; set; }
        public bool purchasable { get; set; }
    }

    public class Rune
    {
        public bool isRune { get; set; }
        public string tier { get; set; }
        public string type { get; set; }
    }

    public class Data
    {
        public _1410 _1410 { get; set; }
        public _2009 _2009 { get; set; }
        public _3089 _3089 { get; set; }
        public _3087 _3087 { get; set; }
        public _3086 _3086 { get; set; }
        public _1414 _1414 { get; set; }
        public _3085 _3085 { get; set; }
        public _1413 _1413 { get; set; }
        public _3084 _3084 { get; set; }
        public _1412 _1412 { get; set; }
        public _2003 _2003 { get; set; }
        public _3083 _3083 { get; set; }
        public _1419 _1419 { get; set; }
        public _3082 _3082 { get; set; }
        public _1418 _1418 { get; set; }
        public _1416 _1416 { get; set; }
        public _3285 _3285 { get; set; }
        public _2010 _2010 { get; set; }
        public _3711 _3711 { get; set; }
        public _3098 _3098 { get; set; }
        public _3094 _3094 { get; set; }
        public _2015 _2015 { get; set; }
        public _3097 _3097 { get; set; }
        public _3096 _3096 { get; set; }
        public _3091 _3091 { get; set; }
        public _1083 _1083 { get; set; }
        public _3090 _3090 { get; set; }
        public _1082 _1082 { get; set; }
        public _3092 _3092 { get; set; }
        public _3715 _3715 { get; set; }
        public _3742 _3742 { get; set; }
        public _3599 _3599 { get; set; }
        public _3748 _3748 { get; set; }
        public _2303 _2303 { get; set; }
        public _2301 _2301 { get; set; }
        public _2302 _2302 { get; set; }
        public _1058 _1058 { get; set; }
        public _1056 _1056 { get; set; }
        public _1057 _1057 { get; set; }
        public _3110 _3110 { get; set; }
        public _3111 _3111 { get; set; }
        public _3112 _3112 { get; set; }
        public _3108 _3108 { get; set; }
        public _3102 _3102 { get; set; }
        public _3105 _3105 { get; set; }
        public _3104 _3104 { get; set; }
        public _3100 _3100 { get; set; }
        public _3101 _3101 { get; set; }
        public _3812 _3812 { get; set; }
        public _3801 _3801 { get; set; }
        public _3706 _3706 { get; set; }
        public _3802 _3802 { get; set; }
        public _3800 _3800 { get; set; }
        public _3504 _3504 { get; set; }
        public _3508 _3508 { get; set; }
        public _3361 _3361 { get; set; }
        public _3362 _3362 { get; set; }
        public _3363 _3363 { get; set; }
        public _3364 _3364 { get; set; }
        public _1409 _1409 { get; set; }
        public _2140 _2140 { get; set; }
        public _1408 _1408 { get; set; }
        public _1401 _1401 { get; set; }
        public _1402 _1402 { get; set; }
        public _1400 _1400 { get; set; }
        public _2138 _2138 { get; set; }
        public _2139 _2139 { get; set; }
        public _1004 _1004 { get; set; }
        public _1001 _1001 { get; set; }
        public _3146 _3146 { get; set; }
        public _1006 _1006 { get; set; }
        public _3147 _3147 { get; set; }
        public _3006 _3006 { get; set; }
        public _3003 _3003 { get; set; }
        public _3004 _3004 { get; set; }
        public _3009 _3009 { get; set; }
        public _3007 _3007 { get; set; }
        public _3008 _3008 { get; set; }
        public _3675 _3675 { get; set; }
        public _3341 _3341 { get; set; }
        public _3340 _3340 { get; set; }
        public _3010 _3010 { get; set; }
        public _3156 _3156 { get; set; }
        public _3155 _3155 { get; set; }
        public _3153 _3153 { get; set; }
        public _1011 _1011 { get; set; }
        public _3152 _3152 { get; set; }
        public _3200 _3200 { get; set; }
        public _3151 _3151 { get; set; }
        public _3139 _3139 { get; set; }
        public _3135 _3135 { get; set; }
        public _3136 _3136 { get; set; }
        public _3137 _3137 { get; set; }
        public _3348 _3348 { get; set; }
        public _3345 _3345 { get; set; }
        public _3001 _3001 { get; set; }
        public _3143 _3143 { get; set; }
        public _3142 _3142 { get; set; }
        public _3145 _3145 { get; set; }
        public _3144 _3144 { get; set; }
        public _3401 _3401 { get; set; }
        public _3211 _3211 { get; set; }
        public _3140 _3140 { get; set; }
        public _3124 _3124 { get; set; }
        public _3029 _3029 { get; set; }
        public _3027 _3027 { get; set; }
        public _3028 _3028 { get; set; }
        public _3025 _3025 { get; set; }
        public _3026 _3026 { get; set; }
        public _3512 _3512 { get; set; }
        public _3035 _3035 { get; set; }
        public _3034 _3034 { get; set; }
        public _3033 _3033 { get; set; }
        public _3031 _3031 { get; set; }
        public _3030 _3030 { get; set; }
        public _3222 _3222 { get; set; }
        public _3134 _3134 { get; set; }
        public _3133 _3133 { get; set; }
        public _3113 _3113 { get; set; }
        public _3114 _3114 { get; set; }
        public _3115 _3115 { get; set; }
        public _3116 _3116 { get; set; }
        public _3117 _3117 { get; set; }
        public _3022 _3022 { get; set; }
        public _3024 _3024 { get; set; }
        public _3020 _3020 { get; set; }
        public _3123 _3123 { get; set; }
        public _3122 _3122 { get; set; }
        public _2053 _2053 { get; set; }
        public _2054 _2054 { get; set; }
        public _3048 _3048 { get; set; }
        public _3047 _3047 { get; set; }
        public _2050 _2050 { get; set; }
        public _2051 _2051 { get; set; }
        public _2052 _2052 { get; set; }
        public _1051 _1051 { get; set; }
        public _3197 _3197 { get; set; }
        public _3198 _3198 { get; set; }
        public _1054 _1054 { get; set; }
        public _1055 _1055 { get; set; }
        public _3196 _3196 { get; set; }
        public _1052 _1052 { get; set; }
        public _1053 _1053 { get; set; }
        public _3052 _3052 { get; set; }
        public _3191 _3191 { get; set; }
        public _3053 _3053 { get; set; }
        public _3050 _3050 { get; set; }
        public _3190 _3190 { get; set; }
        public _2047 _2047 { get; set; }
        public _3056 _3056 { get; set; }
        public _3057 _3057 { get; set; }
        public _2049 _2049 { get; set; }
        public _3036 _3036 { get; set; }
        public _3301 _3301 { get; set; }
        public _3303 _3303 { get; set; }
        public _3302 _3302 { get; set; }
        public _1037 _1037 { get; set; }
        public _1036 _1036 { get; set; }
        public _1039 _1039 { get; set; }
        public _1038 _1038 { get; set; }
        public _3187 _3187 { get; set; }
        public _1041 _1041 { get; set; }
        public _1042 _1042 { get; set; }
        public _1043 _1043 { get; set; }
        public _3184 _3184 { get; set; }
        public _3185 _3185 { get; set; }
        public _3040 _3040 { get; set; }
        public _3041 _3041 { get; set; }
        public _3042 _3042 { get; set; }
        public _3181 _3181 { get; set; }
        public _3043 _3043 { get; set; }
        public _3044 _3044 { get; set; }
        public _3046 _3046 { get; set; }
        public _2031 _2031 { get; set; }
        public _2032 _2032 { get; set; }
        public _3901 _3901 { get; set; }
        public _2033 _2033 { get; set; }
        public _3069 _3069 { get; set; }
        public _3903 _3903 { get; set; }
        public _3902 _3902 { get; set; }
        public _1029 _1029 { get; set; }
        public _1028 _1028 { get; set; }
        public _3462 _3462 { get; set; }
        public _1027 _1027 { get; set; }
        public _3461 _3461 { get; set; }
        public _1026 _1026 { get; set; }
        public _3460 _3460 { get; set; }
        public _3070 _3070 { get; set; }
        public _1033 _1033 { get; set; }
        public _3071 _3071 { get; set; }
        public _3174 _3174 { get; set; }
        public _3751 _3751 { get; set; }
        public _1031 _1031 { get; set; }
        public _3078 _3078 { get; set; }
        public _3077 _3077 { get; set; }
        public _3074 _3074 { get; set; }
        public _3075 _3075 { get; set; }
        public _3170 _3170 { get; set; }
        public _3072 _3072 { get; set; }
        public _3073 _3073 { get; set; }
        public _3671 _3671 { get; set; }
        public _3673 _3673 { get; set; }
        public _3672 _3672 { get; set; }
        public _2045 _2045 { get; set; }
        public _2043 _2043 { get; set; }
        public _3158 _3158 { get; set; }
        public _3157 _3157 { get; set; }
        public _1018 _1018 { get; set; }
        public _3060 _3060 { get; set; }
        public _3165 _3165 { get; set; }
        public _3065 _3065 { get; set; }
        public _3067 _3067 { get; set; }
        public _3068 _3068 { get; set; }
    }

    public class _1410
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2009
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class _3089
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3087
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3086
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1414
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3085
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1413
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3084
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1412
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2003
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3083
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1419
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3082
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1418
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1416
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3285
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2010
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
    }

    public class _3711
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3098
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3094
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2015
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3097
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3096
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3091
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1083
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3090
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1082
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3092
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3715
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3742
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3599
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3748
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2303
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2301
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2302
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1058
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1056
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1057
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3110
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3111
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3112
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3108
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3102
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3105
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3104
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3100
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3101
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3812
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3801
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3706
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3802
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3800
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3504
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3508
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3361
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3362
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3363
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3364
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1409
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2140
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1408
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1401
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1402
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1400
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2138
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2139
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1004
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1001
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3146
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1006
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3147
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3006
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3003
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3004
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3009
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3007
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3008
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3675
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class _3341
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3340
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3010
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3156
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3155
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3153
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1011
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3152
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3200
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3151
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3139
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3135
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3136
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3137
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3348
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3345
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3001
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3143
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3142
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3145
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3144
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3401
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3211
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3140
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3124
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3029
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3027
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3028
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3025
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3026
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3512
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3035
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3034
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3033
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3031
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3030
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3222
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3134
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3133
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3113
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3114
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3115
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3116
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3117
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3022
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3024
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3020
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3123
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3122
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2053
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2054
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
    }

    public class _3048
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class _3047
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2050
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class _2051
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2052
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
    }

    public class _1051
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3197
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3198
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1054
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1055
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3196
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1052
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1053
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3052
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3191
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3053
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3050
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3190
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2047
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3056
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3057
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2049
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3036
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3301
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3303
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3302
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1037
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1036
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1039
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1038
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3187
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1041
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1042
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1043
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3184
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3185
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3040
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class _3041
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3042
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class _3181
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3043
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class _3044
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3046
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2031
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2032
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3901
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2033
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3069
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3903
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3902
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1029
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1028
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3462
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1027
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3461
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
    }

    public class _1026
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3460
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
    }

    public class _3070
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1033
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3071
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3174
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3751
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1031
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3078
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3077
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3074
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3075
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3170
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3072
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3073
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3671
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class _3673
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class _3672
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class _2045
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _2043
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3158
    {
        public int id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3157
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _1018
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3060
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3165
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3065
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3067
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

    public class _3068
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
    }

}
