using Common.Models.Domain;
using Common.Models.Dtos.Character;
using Microsoft.AspNetCore.Mvc;

namespace Common.IServices;

public interface ICharacterService
{
    Task<Guid> CreateCharacterAsync(CharacterShortDto characterDto,
        Guid userId);
    Task SelectCharacterAsync(Guid userId,
        Guid characterId);

    Task<Guid> GetSelectedCharacterIdAsync();
    Task<IActionResult> EditNameAsync(Guid userId,
        Guid characterId,
        string newName);
    Task<IActionResult> DeleteCharacterAsync(Guid userId, 
        Guid characterId);
    Task<IList<CharacterShortDto>> GetChunkAsync(Chunk chunk);
    Task<CharacterShortDto> GetByIdAsync(Guid id);
    Task<IActionResult> EquipCustomItemAsync(Guid userId,
        Guid characterId,
        Guid itemId);
    Task<IActionResult> RemoveItemFromInventoryByIdAsync(Guid userId,
        Guid characterId, 
        Guid customItemId);
    Task<IActionResult> DequipCustomItemAsync(Guid userId,
        Guid characterId,
        Guid customItemId);
    Task<IActionResult> AddCustomItemToInventoryAsync(Guid userId,
        Guid characterId, 
        Guid itemId);

}