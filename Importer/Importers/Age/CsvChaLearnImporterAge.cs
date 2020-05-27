using Importer.Importers.Base;
using Importer.Models;

namespace Importer
{
    public class CsvChaLearnImporterAge : CsvChaLearnImporterBase<AgeModel>
    {
        public override AgeModel GetModel(string[] values)
        {
            return new AgeModel { Age = int.Parse(values[1]), Filename = values[0] };
        }
    }
}
