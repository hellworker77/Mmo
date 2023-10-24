namespace Common.Exceptions.Account;

public class CharacterWithUserIdByIdNotFoundException : NullReferenceException
{
    public CharacterWithUserIdByIdNotFoundException(Guid userId, Guid characterId) :
        base($"Character with userId:{userId} and Id:{characterId} not found")
    {

    }
}