using ddd_fiba.archetype.Application.Reader;
using ddd_fiba.archetype.QuickLaunch;

namespace ddd_fiba.archetype.Mvc.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddQuickLaunchCPI(this IServiceCollection services)
        {
            services.AddSingleton<QuickLaunchCPI, DefaultQuickCPI>();

            return services;
        }

        public static IServiceCollection AddApplicationReaders(this IServiceCollection services)
        {
            services.AddSingleton<ApplicationReaders, DefaultApplicationReaders>();

            return services;
        }
    }
}
