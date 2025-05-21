using Microsoft.Toolkit.Uwp.UI.Controls;
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

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjektBiblioteka
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class PublishersPage : Page
    {
        public ObservableCollection<Publishers> publishers;

        public PublishersPage()
        {
            this.InitializeComponent();

            BibManager.GetPublishers();

            publishers = new ObservableCollection<Publishers>(BibManager.publishers);
        }

        private void dataGrid_RowEditEnded(object sender, Microsoft.Toolkit.Uwp.UI.Controls.DataGridRowEditEndedEventArgs e)
        {
            if(e.EditAction == DataGridEditAction.Commit)
            {
                BibManager.publishers = dataGrid.ItemsSource.Cast<Publishers>().ToList();
                BibManager.SavePublishers();
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var newPublisher = new Publishers()
            {
                Name = "",
                Id = (publishers.Any() ? publishers.Max(x => x.Id) : 0) + 1,
                Website = ""
            };

            publishers.Insert(0, newPublisher);

            BibManager.publishers.Add(newPublisher);

            BibManager.SavePublishers();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var indeks = dataGrid.SelectedIndex;

            if (indeks == -1) return;

            publishers.RemoveAt(indeks);

            BibManager.publishers = publishers.ToList();

            BibManager.SavePublishers();
        }
    }
}
