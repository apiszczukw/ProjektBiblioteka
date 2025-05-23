﻿using ProjektBiblioteka.Infrastructure;
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

        public MainPage()
        {
            this.InitializeComponent();


            //BibManager.SavaData();

           

        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItemContainer.Tag.ToString() == "authors" && mainFrame.CurrentSourcePageType != typeof(AuthorsPage))
            {
                mainFrame.Navigate(typeof(AuthorsPage));
            }
            if (args.InvokedItemContainer.Tag.ToString() == "publishers" && mainFrame.CurrentSourcePageType != typeof(PublishersPage))
            {
                mainFrame.Navigate(typeof(PublishersPage));
            }
        }
    }
}
