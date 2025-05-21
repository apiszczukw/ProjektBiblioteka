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
    public sealed partial class AuthorsPage : Page
    {

        public ObservableCollection<Authors> authors;

        public AuthorsPage()
        {
            this.InitializeComponent();

            BibManager.GetAuthors();
            authors = new ObservableCollection<Authors>(BibManager.authors);
        }

        private void DataGrid_RowEditEnded(object sender, Microsoft.Toolkit.Uwp.UI.Controls.DataGridRowEditEndedEventArgs e)
        {
           // TODO 
           // sprawdzenie stanu edycji i zapis danych

            if(e.EditAction == DataGridEditAction.Commit)
            {
                BibManager.authors = dataGrid.ItemsSource.Cast<Authors>().ToList();

                BibManager.SaveAuthors();
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var newAuthor = new Authors()
            {
                Name = "",
                Surname = "",
                YearOfBirth = 1900,
                Id = (authors.Any() ? authors.Max(x => x.Id) : 0) + 1
            };

            authors.Insert(0, newAuthor);

            BibManager.authors.Add(newAuthor);

            BibManager.SaveAuthors();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var indeks = dataGrid.SelectedIndex;

            if (indeks == -1) return;

            authors.RemoveAt(indeks);

            BibManager.authors = authors.ToList();

            BibManager.SaveAuthors();
        }
    }
}
