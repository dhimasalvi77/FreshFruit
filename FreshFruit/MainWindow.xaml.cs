using FreshFruit.Controler;
using FreshFruit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller toni;

        public MainWindow()
        {
            InitializeComponent();

            Bucket keranjangBUah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBUah, this);

            toni = new Seller("Toni", bucketController);

            ListBoxBucket.ItemsSource = keranjangBUah.findAll();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message);
        }

        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("anggur");
            toni.addFruit(anggur);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("apple");
            toni.addFruit(apple);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit pisang = new Fruit("banana");
            toni.addFruit(pisang);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("orange");
            toni.addFruit(orange);

            ListBoxBucket.Items.Refresh();
        }




    }
}
