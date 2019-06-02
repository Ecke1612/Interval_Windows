using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class Clients : UserControl
    {

        private Color myColor;

        public Clients()
        {
            this.InitializeComponent();
        }

        private void confirmColor_Click(object sender, RoutedEventArgs e)
        {
            // Assign the selected color to a variable to use outside the popup.
            myColor = myColorPicker.Color;
            colorPickerButton.Background = new SolidColorBrush(myColor);

            // Close the Flyout.
            colorPickerButton.Flyout.Hide();
        }

        private void cancelColor_Click(object sender, RoutedEventArgs e)
        {
            // Close the Flyout.
            colorPickerButton.Flyout.Hide();
        }

    }
}
