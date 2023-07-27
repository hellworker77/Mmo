namespace Common.Exceptions.Account;

public class UserNotFoundException : NullReferenceException
{
    public UserNotFoundException(Guid userId) :
        base($"User with id:{userId} not found")
    {

    }
}