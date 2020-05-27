using Importer.Importers.Base;
using Importer.Models;
using System.IO;

namespace Importer.Importers.Gender
{
    public class SussanqqFileImporterGender : SussanqqFileImporterBase<GenderModel>
    {
        public override GenderModel GetModel(string[] values, string fileName)
        {
            return new GenderModel() { IsFemale = values[1] == "1", Filename = Path.GetFileName(fileName) };
        }
    }
}
