﻿using Common.Exceptions.Account;
using Common.IServices;
using Common.Models.Domain;
using Common.Models.Dtos.Character;
using Dal.Interfaces;
using Entities.Entity;
using MapsterMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Common.Services;

public class CharacterService : ICharacterService
{
    private readonly ICharacterRepository _characterRepository;
    private readonly IMapper _mapper;
    private readonly IHttpContextAccessor _accessor;

    public CharacterService(ICharacterRepository characterRepository,
        IMapper mapper,
        IHttpContextAccessor accessor)
    {
        _characterRepository = characterRepository;
        _mapper = mapper;
        _accessor = accessor;
    }

    public async Task<Guid> CreateCharacterAsync(CharacterShortDto characterDto,
        Guid userId)
    {
        var character = _mapper.Map<Character>(characterDto);
        character.UserId = userId;

        return await _characterRepository.CreateAsync(character);
    }

    public async Task SelectCharacterAsync(Guid userId,
        Guid characterId)
    {
        var character = await _characterRepository.GetByIdWithUserIdAsync(userId, characterId);

        if (character == null)
        {
            throw new CharacterWithUserIdByIdNotFoundException(userId, characterId);
        }

        _accessor.HttpContext.Session.Set("selectedCharacterId", characterId.ToByteArray());
    }

    public async Task<Guid> GetSelectedCharacterIdAsync()
    {
        var successful = _accessor.HttpContext.Session.TryGetValue("selectedCharacterId", out var data);

        if (!successful)
        {
            throw new CharacterNotSelectedException();
        }
        
        return await Task.FromResult(new Guid(data));
    }

    public async Task ChangeNameAsync(CharacterToNameChangeDto characterDto)
    {
        var character = await _characterRepository.GetByIdWithUserIdAsync(characterDto.UserId, characterDto.Id)
                        ?? throw new CharacterWithUserIdByIdNotFoundException(characterDto.UserId, characterDto.Id);

        character.Name = characterDto.Name;
        
        await _characterRepository.ChangeNameAsync(character);
    }

    public async Task DeleteCharacterAsync(Guid userId,
        Guid characterId)
    {
        var character = await _characterRepository.GetByIdWithUserIdAsync(userId, characterId)
                        ?? throw new CharacterWithUserIdByIdNotFoundException(userId, characterId);

        await _characterRepository.DeleteCharacterAsync(character);
    }

    public Task<IList<CharacterShortDto>> GetChunkAsync(Chunk chunk)
    {
        throw new NotImplementedException();
    }

    public async Task<CharacterShortDto> GetByIdAsync(Guid characterId)
    {
        var character = await _characterRepository.GetByIdAsync(characterId)
                        ?? throw new NullReferenceException();

        var destination = _mapper.Map<CharacterShortDto>(character);

        return destination;
    }

    public Task<IActionResult> EquipCustomItemAsync(Guid userId,
        Guid characterId,
        Guid itemId)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> RemoveItemFromInventoryByIdAsync(Guid userId,
        Guid characterId,
        Guid customItemId)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> DequipCustomItemAsync(Guid userId,
        Guid characterId,
        Guid customItemId)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> AddCustomItemToInventoryAsync(Guid userId,
        Guid characterId,
        Guid itemId)
    {
        throw new NotImplementedException();
    }
}