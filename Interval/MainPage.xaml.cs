using Interval.GUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace Interval
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Btn_newProject_Click(object sender, RoutedEventArgs e)
        {
            Splitview_Menu.IsPaneOpen = !Splitview_Menu.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ProjectsListBoxItem.IsSelected)
            {
                MainFrame.Navigate(typeof(ProjectsPage));
            } else if(ClientsListBoxItem.IsSelected)
            {
                
            } else if(ReportsListBoxItem.IsSelected)
            {
                
            }
        }
    }
}
