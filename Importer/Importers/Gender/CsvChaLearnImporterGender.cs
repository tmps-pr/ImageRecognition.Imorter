using Importer.Importers.Base;
using Importer.Models;

namespace Importer.Importers.Gender
{
    public class CsvChaLearnImporterGender : CsvChaLearnImporterBase<GenderModel>
    {
        public override GenderModel GetModel(string[] values)
        {
            return new GenderModel() { Filename = values[0], IsFemale = (values[2] == "0") };
        }
    }
}
