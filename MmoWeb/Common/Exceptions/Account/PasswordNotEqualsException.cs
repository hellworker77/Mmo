namespace Common.Exceptions.Account;

public class PasswordNotEqualsException: Exception
{
    public PasswordNotEqualsException() : 
        base("Passwords not equal")
    {
        
    }
}