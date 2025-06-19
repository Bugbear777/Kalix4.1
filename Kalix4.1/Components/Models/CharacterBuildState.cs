namespace Kalix4.Components.Models
{
  public class CharacterBuildState
  {
    public string Species { get; set; }
    public string Culture { get; set; }
    public string Nationality { get; set; }
    public string Background { get; set; }

    public Dictionary<string, int> AbilityScores { get; set; } = new()
        {
            { "Weapon Skill", 0 },
            { "Ballistic Skill", 0 },
            { "Strength", 0 },
            { "Dexterity", 0 },
            { "Constitution", 0 },
            { "Intelligence", 0 },
            { "Wisdom", 0 },
            { "Charisma", 0 }
        };

    public List<string> Skills { get; set; } = new();
    public List<string> Equipment { get; set; } = new();
  }
}

