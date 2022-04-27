using System;
using System.Threading.Tasks;

using R5T.T0002;
using R5T.T0004;using R5T.T0064;


namespace R5T.D0018.I0001
{[ServiceImplementationMarker]
    public class NewXDocumentVisualStudioProjectFileGenerator : INewVisualStudioProjectFileGenerator,IServiceImplementation
    {
        public Task<IVisualStudioProjectFile> CreateNewVisualStudioProjectFile()
        {
            var xDocumentVisualStudioProjectFile = XDocumentVisualStudioProjectFile.New();

            return Task.FromResult(xDocumentVisualStudioProjectFile as IVisualStudioProjectFile);
        }
    }
}
