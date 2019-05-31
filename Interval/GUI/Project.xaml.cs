using Interval.Logic.Project;
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

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace Interval.GUI
{
    public sealed partial class Project : UserControl
    {
        private Timer timer = new Timer();

        public Project()
        {
            InitializeComponent();
        }

        private void Btn_start_Click(object sender, RoutedEventArgs e)
        {
            if(!timer.running)
            {
                timer.DispatcherStart(timer_text);
            } else
            {
                timer.DispatcherStop();
            }
        }

        private void showProjectDetails(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_remove_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
