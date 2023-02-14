using System.Text.Json.Serialization;

namespace dotNet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,

        Mage = 2,

        Rogue = 3

    }
}