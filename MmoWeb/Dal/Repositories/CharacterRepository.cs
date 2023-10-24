using Dal.Data;
using Dal.Interfaces;
using Entities.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dal.Repositories;

public class CharacterRepository : ICharacterRepository
{
    private readonly ApplicationContext _applicationContext;
    private readonly DbSet<Character> _characterDbSet;

    public CharacterRepository(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
        _characterDbSet = applicationContext.Set<Character>();
    }

    public async Task<Character?> GetByIdAsync(Guid characterId) => 
        await _characterDbSet
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == characterId);

    public async Task<Character?> GetByIdWithUserIdAsync(Guid userId,
        Guid characterId) =>
        await _characterDbSet
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == characterId && x.UserId == userId);

    public async Task<Guid> CreateAsync(Character character)
    {
        _applicationContext.Entry(character).State = EntityState.Added;
        await _applicationContext.SaveChangesAsync();
        
        return character.Id;
    }
}