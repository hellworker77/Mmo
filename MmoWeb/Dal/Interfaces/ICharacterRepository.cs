using Entities.Entity;

namespace Dal.Interfaces;

public interface ICharacterRepository
{
    Task<Character?> GetByIdAsync(Guid characterId);

    Task<Character?> GetByIdWithUserIdAsync(Guid userId,
        Guid characterId);
    Task<Guid> CreateAsync(Character character);
}