using Importer.Importers.Gender;
using Importer.Models;
using System;
using System.IO;

namespace Importer
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string output = "C:\\Project\\input\\age";
            var pathToSource = @"C:\Project\import\Susanqq\part3";
            var source = @"C:\Project\import\Susanqq\part3";

            CopyImages(pathToSource, source, output, new SussanqqFileImporterGender(), CopyGenderImages);
        }
        private static void CopyImages<T>(string pathToSource, string source, string output, IImporter<T> importer, Action<T, string, string> action)
            where T: ModelBase
        {
            var models = importer.GetFiles(pathToSource);
            foreach (var model in models)
            {
                var filePath = Path.Combine(source, model.Filename);
                action(model, filePath, output);
            }
        }

        private static void CopyGenderImages(GenderModel model, string filePath, string output)
        {
            if (model.IsFemale)
            {
                File.Copy(filePath, Path.Combine(output, "Female", model.Filename));
            }
            else
            {
                File.Copy(filePath, Path.Combine(output, "Male", model.Filename));
            }
        }

        private static void CopyAgeImages(AgeModel model, string filePath,  string output)
        {
            switch (model.Age)
            {
                case int age when (age > 0 && age <= 5):
                    File.Copy(filePath, Path.Combine(output, "5", model.Filename));
                    break;
                case int age when (age > 5 && age <= 10):
                    File.Copy(filePath, Path.Combine(output, "10", model.Filename));
                    break;
                case int age when (age > 10 && age <= 15):
                    File.Copy(filePath, Path.Combine(output, "15", model.Filename));
                    break;
                case int age when (age > 15 && age <= 20):
                    File.Copy(filePath, Path.Combine(output, "20", model.Filename));
                    break;
                case int age when (age > 20 && age <= 25):
                    File.Copy(filePath, Path.Combine(output, "25", model.Filename));
                    break;
                case int age when (age > 25 && age <= 30):
                    File.Copy(filePath, Path.Combine(output, "30", model.Filename));
                    break;
                case int age when (age > 30 && age <= 35):
                    File.Copy(filePath, Path.Combine(output, "35", model.Filename));
                    break;
                case int age when (age > 35 && age <= 40):
                    File.Copy(filePath, Path.Combine(output, "40", model.Filename));
                    break;
                case int age when (age > 40 && age <= 45):
                    File.Copy(filePath, Path.Combine(output, "45", model.Filename));
                    break;
                case int age when (age > 45 && age <= 50):
                    File.Copy(filePath, Path.Combine(output, "50", model.Filename));
                    break;
                case int age when (age > 50 && age <= 55):
                    File.Copy(filePath, Path.Combine(output, "55", model.Filename));
                    break;
                case int age when (age > 55 && age <= 60):
                    File.Copy(filePath, Path.Combine(output, "60", model.Filename));
                    break;
                case int age when (age > 60 && age <= 120):
                    File.Copy(filePath, Path.Combine(output, "65", model.Filename));
                    break;
                default:
                    break;
            }
        }
    }
}
