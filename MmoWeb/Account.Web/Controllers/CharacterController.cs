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
        public async Task<IActionResult> CreateCharacterAsync(CharacterDto character)
        {
            var userId = _identityService.GetUserIdentity();
            var characterId = await _characterService.CreateCharacterAsync(character, userId);

            return Ok(characterId);
        }

        [HttpPut("selectCharacterId")]
        public async Task<IActionResult> SelectCharacterAsync(Guid characterId)
        {
            var userId = _identityService.GetUserIdentity();

            await _characterService.SelectCharacterAsync(userId, characterId);
            
            return Ok();
        }
        [Authorize]
        [HttpPut("editNickName")]
        public Task EditNickNameAsync(Guid characterId,
            string newNickName)
        { 
            throw new NotImplementedException();
        }
    }
}
