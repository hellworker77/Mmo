using Entities.Enums;

#pragma warning disable CS8618
namespace Common.Models.Dtos.Character;

public class CharacterShortDto
{
    public CharacterClass Class {get; set; }
    public string Name { get; set; }
}