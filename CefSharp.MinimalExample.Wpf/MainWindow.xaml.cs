using CefSharp.WinForms;
using System.Windows;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var browser = new ChromiumWebBrowser("www.google.com");
            windowsFormsHost.Child = browser;

        }
    }
}
