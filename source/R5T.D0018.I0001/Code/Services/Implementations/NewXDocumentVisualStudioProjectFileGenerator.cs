using System;
using System.Threading.Tasks;

using R5T.T0002;
using R5T.T0004;


namespace R5T.D0018.I0001
{
    public class NewXDocumentVisualStudioProjectFileGenerator : INewVisualStudioProjectFileGenerator
    {
        public Task<IVisualStudioProjectFile> CreateNewVisualStudioProjectFile()
        {
            var xDocumentVisualStudioProjectFile = XDocumentVisualStudioProjectFile.New();

            return Task.FromResult(xDocumentVisualStudioProjectFile as IVisualStudioProjectFile);
        }
    }
}
