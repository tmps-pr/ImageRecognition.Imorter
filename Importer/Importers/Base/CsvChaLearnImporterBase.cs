using Importer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Importer.Importers.Base
{
    /// <summary>
    /// http://chalearnlap.cvc.uab.es/dataset/18/description/
    /// </summary>
    public abstract class CsvChaLearnImporterBase<T> : IImporter<T> where T :ModelBase
    {
        public List<T> GetFiles(string pathToSource)
        {
            List<T> ageFiles = new List<T>();
            using (var reader = new StreamReader(pathToSource))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    ageFiles.Add(GetModel(values));
                }
            }
            return ageFiles;
        }

        public abstract T GetModel(string[] values);
    }
}
