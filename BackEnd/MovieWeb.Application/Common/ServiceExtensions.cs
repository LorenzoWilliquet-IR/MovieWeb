using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MovieWeb.Application.Common
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddExtensions(this IServiceCollection services)
        {
            return services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
