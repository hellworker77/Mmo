namespace Common.Exceptions.Account;

public class UserIdentityNullException : NullReferenceException
{
    public UserIdentityNullException() :
        base("Not found user identity")
    {

    }
}