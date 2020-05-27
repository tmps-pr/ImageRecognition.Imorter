using Importer.Importers.Base;
using Importer.Models;
using System.IO;

namespace Importer
{
    public class SusanqqFileImporterAge : SussanqqFileImporterBase<AgeModel>
    {
        public override AgeModel GetModel(string[] values, string fileName)
        {
            return new AgeModel() { Age = int.Parse(values[0]), Filename = Path.GetFileName(fileName) };
        }
    }
}
