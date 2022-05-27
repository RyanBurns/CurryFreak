using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PivitPan
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            // make sure the canvas is invisable
            cvsSomething.Visibility = System.Windows.Visibility.Collapsed;


            base.OnNavigatedTo(e);
        }

        private void btnShowHide_Click(object sender, RoutedEventArgs e)
        {
            // show and hide some stuff here.
            cvsSomething.Visibility = System.Windows.Visibility.Visible;


        }

        private void btnPivot_Click(object sender, RoutedEventArgs e)
        {
            // show pivot page
            NavigationService.Navigate(new Uri("/PivotPage1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnPanorama_Click(object sender, RoutedEventArgs e)
        {
            // show panorama page
            NavigationService.Navigate(new Uri("/PanoramaPage1.xaml", UriKind.RelativeOrAbsolute));
        }


    }
}