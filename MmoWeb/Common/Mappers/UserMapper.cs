using Common.Models.Dtos;
using Entities.Identity;
using Mapster;

namespace Common.Mappers;

public class UserMapper : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.ForType<User, UserDto>().
            Map(destination => destination.UserName, source => source.UserName).
            Map(destination => destination.Email, source => source.Email);
    }
}