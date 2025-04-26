using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BetterAppInstaller
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BrowsersPage : Page
    {
        public BrowsersPage()
        {
            this.InitializeComponent();
        }

        private async void InstallButton_ClickEdge(object sender, RoutedEventArgs e)
        {
            pbEdge.Visibility = Visibility.Visible;
            bnEdge.Content = "Installing..";
            var process = Process.Start("cmd", "/c winget install -h --accept-package-agreements --accept-source-agreements  --id Microsoft.Edge");
            process.WaitForExit();
            bnEdge.Content = "Update";
            pbEdge.Visibility = Visibility.Collapsed;
        }

        private async void InstallButton_ClickChrome(object sender, RoutedEventArgs e)
        {
            pbChrome.Visibility = Visibility.Visible;
            bnChrome.Content = "Installing..";
            var process = Process.Start("cmd", "/c winget install -h --accept-package-agreements --accept-source-agreements --id Google.Chrome");
            process.WaitForExit();
            bnChrome.Content = "Update";
            pbChrome.Visibility = Visibility.Collapsed;
        }

        private async void InstallButton_ClickFirefox(object sender, RoutedEventArgs e)
        {
            pbFirefox.Visibility = Visibility.Visible;
            bnFirefox.Content = "Installing..";
            var process = Process.Start("cmd", "/c winget install -h --accept-package-agreements --accept-source-agreements --id Mozilla.Firefox");
            process.WaitForExit();
            bnChrome.Content = "Update";
            pbFirefox.Visibility = Visibility.Collapsed;
        }

        private async void InstallButton_ClickVivaldi(object sender, RoutedEventArgs e)
        {
            pbVivaldi.Visibility = Visibility.Visible;
            bnVivaldi.Content = "Installing..";
            var process = Process.Start("cmd", "/c winget install -h --accept-package-agreements --accept-source-agreements --id VivaldiTechnologies.Vivaldi");
            process.WaitForExit();
            bnChrome.Content = "Update";
            pbVivaldi.Visibility = Visibility.Collapsed;
        }
    }
}
