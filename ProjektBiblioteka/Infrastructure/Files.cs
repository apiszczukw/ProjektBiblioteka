using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ProjektBiblioteka.Infrastructure
{
    public static class Files
    {
        public static string AuthorsFile = "daneAutorzy.xml";

        public static string PublishersFile = "daneWydawnictw.xml";

        public static string AuthorsFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, AuthorsFile);

        public static string PublishersFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, PublishersFile);
    }
}
