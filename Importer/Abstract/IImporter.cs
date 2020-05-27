using Importer.Models;
using System.Collections.Generic;

namespace Importer
{
    public interface IImporter<T> where T: ModelBase
    {
        List<T> GetFiles(string pathToSource);
    }
}
