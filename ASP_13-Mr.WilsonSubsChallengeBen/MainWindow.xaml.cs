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

namespace ASP_13_Mr.WilsonSubsChallengeBen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Special.Content = "Welcome To The Shop! \nTodays Special: $2.00 off Foot Long, wheat bread, and American cheese sub!";
        }

        private void PlaceOrder_Click(object sender, RoutedEventArgs e)
        {
            string SammyCon;
            double price = 0;
            if (sizeOption1.IsChecked == true)
            {
                SammyCon = "6\" sub";
                price += 3.5;
                getSammy();
            }
            else if (sizeOption2.IsChecked ==  true)
            {
                SammyCon = "Foot long sub";
                price += 5;
                getSammy();
            }
            else
            {
                SammyCon = "Incomplete order";
                
            }
            void getSammy() {
                if (brdOpt1.IsChecked == true) { SammyCon += ", wheat bread"; }
                if (brdOpt2.IsChecked == true) { SammyCon += ", italian bread"; }
                if (brdOpt3.IsChecked == true) { SammyCon += ", flat bread"; price += .5; }

                if (mtOpt1.IsChecked == true) { SammyCon += ", ham"; }
                if (mtOpt2.IsChecked == true) { SammyCon += ", roasted chicken"; }
                if (mtOpt3.IsChecked == true) { SammyCon += ", meat ball"; price += 1; }
                if (mtOpt4.IsChecked == true) { SammyCon += ", steak"; price += 1.5; }

                if (chOpt1.IsChecked == true) { SammyCon += ", American cheese"; price += .25; }
                if (chOpt2.IsChecked == true) { SammyCon += ", swiss cheese"; price += .30; }
                if (chOpt3.IsChecked == true) { SammyCon += ", pepperjack cheese"; price += .75; }

                if (vgOpt1.IsChecked == true) { SammyCon += ", cucumbers";  }
                if (vgOpt2.IsChecked == true) { SammyCon += ", green beans"; price += .25; }
                if (vgOpt3.IsChecked == true) { SammyCon += ", lettuce"; price += .15; }
                if (vgOpt4.IsChecked == true) { SammyCon += ", red onions"; price += .10; }
                if (vgOpt5.IsChecked == true) { SammyCon += ", cucumbers, green beans, lettuce, red onions"; price += .50; }

                if (brdOpt1.IsChecked == true && sizeOption2.IsChecked == true && mtOpt3.IsChecked == true && chOpt1.IsChecked == true)
                {
                    price -= 2;
                    SammyCon += ", *special sub*";
                }
            }
            YourTotal.Content = "$" + price;
            YourSammyCon.Content = SammyCon;

        }

        private void vgOpt5_Checked(object sender, RoutedEventArgs e)
        {
            vgOpt1.IsChecked = false;
            vgOpt2.IsChecked = false;
            vgOpt3.IsChecked = false;
            vgOpt4.IsChecked = false;
        }
        private void vgOpt1_Checked(object sender, RoutedEventArgs e)
        { vgOpt5.IsChecked = false; }
        private void vgOpt2_Checked(object sender, RoutedEventArgs e)
        { vgOpt5.IsChecked = false; }
        private void vgOpt3_Checked(object sender, RoutedEventArgs e)
        { vgOpt5.IsChecked = false; }
        private void vgOpt4_Checked(object sender, RoutedEventArgs e)
        { vgOpt5.IsChecked = false; }
    }
}
