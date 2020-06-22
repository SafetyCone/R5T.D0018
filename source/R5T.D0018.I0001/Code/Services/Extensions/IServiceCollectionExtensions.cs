using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0018.I0001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="NewXDocumentVisualStudioProjectFileGenerator"/> implementation of <see cref="INewVisualStudioProjectFileGenerator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddNewXDocumentVisualStudioProjectFileGenerator(this IServiceCollection services)
        {
            services.AddSingleton<INewVisualStudioProjectFileGenerator, NewXDocumentVisualStudioProjectFileGenerator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="NewXDocumentVisualStudioProjectFileGenerator"/> implementation of <see cref="INewVisualStudioProjectFileGenerator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<INewVisualStudioProjectFileGenerator> AddNewXDocumentVisualStudioProjectFileGeneratorAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<INewVisualStudioProjectFileGenerator>.New(() => services.AddNewXDocumentVisualStudioProjectFileGenerator());
            return serviceAction;
        }
    }
}
