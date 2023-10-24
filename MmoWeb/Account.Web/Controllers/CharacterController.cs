using Common.IServices;
using Common.Models.Dtos.Character;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Account.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly IIdentityService _identityService;

        public CharacterController(ICharacterService characterService, 
            IIdentityService identityService)
        {
            _characterService = characterService;
            _identityService = identityService;
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetByIdAsync(Guid characterId)
            => Ok(await _characterService.GetByIdAsync(characterId));
        
        [Authorize]
        [HttpGet("getSelectedCharacterId")]
        public async Task<IActionResult> GetSelectedCharacterIdAsync()
        {
            var selectedCharacterId = await _characterService.GetSelectedCharacterIdAsync();

            return Ok(selectedCharacterId);
        }
        [Authorize]
        [HttpPost("createCharacter")]
        public async Task<IActionResult> CreateCharacterAsync(CharacterShortDto character)
        {
            var userId = _identityService.GetUserIdentity();
            var characterId = await _characterService.CreateCharacterAsync(character, userId);

            return Ok(characterId);
        }

        [Authorize]
        [HttpPut("selectCharacterId")]
        public async Task<IActionResult> SelectCharacterAsync(Guid characterId)
        {
            var userId = _identityService.GetUserIdentity();

            await _characterService.SelectCharacterAsync(userId, characterId);
            
            return Ok("Character selected");
        }
        [Authorize]
        [HttpPut("editNickName")]
        public async Task<IActionResult> ChangeNameAsync(Guid characterId,
            string newName)
        {
            var userId = _identityService.GetUserIdentity();
            
            await _characterService.ChangeNameAsync(userId, characterId, newName);

            return Ok("Name changed");
        }

        [Authorize]
        [HttpDelete("deleteById")]
        public async Task<IActionResult> DeleteByIdAsync(Guid characterId)
        {
            var userId = _identityService.GetUserIdentity();

            await _characterService.DeleteCharacterAsync(userId, characterId);
            
            return Ok();
        }
        
    }
}
