using AudioPlayer.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AudioPlayer.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDbConnection(
            this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:DefaultConnection"];

            services.AddDbContext<AudioPlayerDbContext>(options => 
                options.UseNpgsql(connectionString));

            services.AddScoped<IAudioPlayerDbContext>(provider => 
                provider.GetRequiredService<AudioPlayerDbContext>());

            return services;
        }   
    }
}
