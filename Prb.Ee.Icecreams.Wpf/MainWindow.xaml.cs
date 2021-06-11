using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Prb.Ee.Icecreams.Core.Entities;
using Prb.Ee.Icecreams.Core.Services;
using Prb.Ee.Icecreams.Core.Enums;

namespace Prb.Ee.Icecreams.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShopService shopService = new ShopService();
        public MainWindow()
        {
            InitializeComponent();
            cmbPackage.Items.Add(PackageType.Hoortnje);
            cmbPackage.Items.Add(PackageType.Potje);
            cmbPackage.Items.Add(PackageType.Wafel);
            cmbPackage.SelectedItem = PackageType.Hoortnje;
            
            lstAvailableFlavours.Items.Add("Chocolade, 0.7M");
            lstAvailableFlavours.Items.Add("Mokka, 0.8M " );
            lstAvailableFlavours.Items.Add("Vanille, 1M");

            grdFlavours.Visibility = Visibility.Hidden;
            if(btnSellIcecream.IsPressed )
            {
                lstSoldIcecreams.ItemsSource = $"{ cmbPackage.SelectedItem.ToString()} met {lstAvailableFlavours.Items.Count} smaken ";
            }
        }
       
        private void btnCreateNewIcecream_Click(object sender, RoutedEventArgs e)
        {
            if(cmbPackage.SelectedItem != null)
            {
                grdFlavours.Visibility = Visibility.Visible;
                //lstAvailableFlavours.ItemsSource = shopService.Flavours;
            }
        }

        private void btnAddFlavour_Click(object sender, RoutedEventArgs e)
        {
            lstChosenFlavours.ItemsSource = lstAvailableFlavours.SelectedItem.ToString();
        }

        private void btnSellIcecream_Click(object sender, RoutedEventArgs e)
        {
            //lstSoldIcecreams.ItemsSource = shopService.SellIcecream();
        }
    }
}
