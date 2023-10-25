using Mapster;
using MapsterMapper;
using System.Reflection;

namespace Account.Web.Tests.Fixture;

public  static class MapsterFixture
{
    public static Mapper GetMapper()
    {
        var typeAdapterConfig = TypeAdapterConfig.GlobalSettings;
        typeAdapterConfig.Scan(Assembly.GetExecutingAssembly());
        var mapperConfig = new Mapper(typeAdapterConfig);

        return mapperConfig;
    }
}