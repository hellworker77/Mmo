using Entities.Enums;

#pragma warning disable CS8618
namespace Common.Models.Dtos.Character;

public class CharacterDto
{
    public string Name { get; set; }
    public string Bio { get; set; }
    public int Rating { get; set; }
    public CharacterClass Class { get; set; }
}