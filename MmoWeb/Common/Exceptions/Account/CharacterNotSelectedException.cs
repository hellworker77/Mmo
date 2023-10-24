namespace Common.Exceptions.Account;

public class CharacterNotSelectedException : Exception
{
    public CharacterNotSelectedException() :
        base("You did not select character") 
    {
        
    }
}