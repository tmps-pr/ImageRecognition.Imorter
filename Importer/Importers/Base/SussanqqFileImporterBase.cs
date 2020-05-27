using Importer.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Importer.Importers.Base
{
    /// <summary>
    /// https://susanqq.github.io/UTKFace/?fbclid=IwAR18VuVjTv_jZbBsvKPiGt_OoaLcVP_I9BJUb3AvI66ZT8j7NEZmLQu63Tg
    /// </summary>
    public abstract class SussanqqFileImporterBase<T> : IImporter<T> where T : ModelBase
    {
        public List<T> GetFiles(string pathToSource)
        {
            List<T> ageFiles = new List<T>();
            var files = Directory.GetFiles(pathToSource);
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                var splits = fileName.Split("_");
                try
                {
                    ageFiles.Add(GetModel(splits, fileName));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return ageFiles;
        }

        public abstract T GetModel(string[] values, string fileName);
    }
}
