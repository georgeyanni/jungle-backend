using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Jungle.Infrastucture.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // services.AddAuthorizationBuilder()
        //     .AddPolicy(PolicyNames.HasNationality, 
        //         builder => builder.RequireClaim(AppClaimTypes.Nationality, "German", "Polish"))
        //     .AddPolicy(PolicyNames.AtLeast20,
        //         builder => builder.AddRequirements(new MinimumAgeRequirement(20)))
        //     .AddPolicy(PolicyNames.CreatedAtleast2Restaurants, 
        //         builder => builder.AddRequirements(new CreatedMultipleRestaurantsRequirement(2)));

    }
}