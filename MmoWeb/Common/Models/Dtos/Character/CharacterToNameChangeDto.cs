
#pragma warning disable CS8618
namespace Common.Models.Dtos.Character;

public class CharacterToNameChangeDto
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; }
    public string Name { get; set; }
}