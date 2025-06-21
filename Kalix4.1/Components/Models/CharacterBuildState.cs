namespace Kalix4.Components.Models
{
  public class CharacterBuildState
  {
    public string Species { get; set; }
    public string Culture { get; set; }
    public string Destiny { get; set; }
    public string Background { get; set; }
    public string Class { get; set; }

    public Dictionary<string, int> AbilityScores { get; set; } = new()
        {
            { "Strength", 10 },
            { "Dexterity", 10 },
            { "Constitution", 10 },
            { "Intelligence", 10 },
            { "Wisdom", 10 },
            { "Charisma", 10 }
        };

    public List<string> Skills { get; set; } = new();
    public List<string> Equipment { get; set; } = new();
  }
}

