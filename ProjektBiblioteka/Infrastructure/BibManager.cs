using ProjektBiblioteka.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ProjektBiblioteka.Infrastructure
{
    public class BibManager
    {

        public static List<Authors> authors;

        public static List<Publishers> publishers;

        public static void SavaData()
        {
            authors = TestData.GetGeneratedAuthors();
            publishers = TestData.GetGeneratedPublishers();

            var path = ApplicationData.Current.LocalFolder.Path;

            XmlHelper.SerializeToXml(authors, Path.Combine(path, Files.AuthorsFile));
            XmlHelper.SerializeToXml(publishers, Path.Combine(path, Files.PublishersFile));
        }

        public static void GetAuthors()
        {
            authors = XmlHelper.DeserializeFromXml<List<Authors>>(Files.AuthorsFilePath);
        }

        internal static void GetPublishers()
        {

            publishers = XmlHelper.DeserializeFromXml<List<Publishers>>(Files.PublishersFilePath);
        }

        public static void SaveAuthors()
        {
            XmlHelper.SerializeToXml(authors, Files.AuthorsFilePath);
        }

        public static void SavePublishers()
        {
            XmlHelper.SerializeToXml(publishers, Files.PublishersFilePath);
        }
    }
}
