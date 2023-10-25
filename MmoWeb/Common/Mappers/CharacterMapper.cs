using Common.Models.Dtos.Character;
using Entities.Entity;
using Mapster;

namespace Common.Mappers;

public class CharacterMapper : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.ForType<Character, CharacterShortDto>()
            .Map(destination => destination.Class, source => source.Class)
            .Map(destination => destination.Name, source => source.Name);
        
        config.ForType<Character, Character>()
            .Map(destination => destination.Class, source => source.Class)
            .Map(destination => destination.Bio, source => source.Bio)
            .Map(destination => destination.Rating, source => source.Rating)
            .Map(destination => destination.Name, source => source.Name);
    }
}