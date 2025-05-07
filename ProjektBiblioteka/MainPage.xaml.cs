using ProjektBiblioteka.Infrastructure;
using ProjektBiblioteka.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace ProjektBiblioteka
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public ObservableCollection<Authors> Authors;
        public ObservableCollection<Publishers> Publishers;


        public MainPage()
        {
            this.InitializeComponent();


            BibManager.SavaData();

            BibManager.GetAuthors();
            BibManager.GetPublishers();

            Authors = new ObservableCollection<Authors>(BibManager.authors);
            Publishers = new ObservableCollection<Publishers>(BibManager.publishers);

        }
    }
}
